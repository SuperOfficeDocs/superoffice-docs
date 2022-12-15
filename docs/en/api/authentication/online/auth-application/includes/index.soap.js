const crypto = require('crypto');
const moment = require('moment');
const fs = require('fs');
const request = require('request');
const jwt = require('jsonwebtoken');
const xml2js = require('xml2js');

// Partner Application Token (AKA Client Secret)
const appToken = 'YOUR_APPLICATION_TOKEN_GOES_HERE';

// Your Online Sandbox Customer Identifier
const contextId = 'Cust12345';

// SystemUserToken provided as a claim in the callback (Redirect URL)
// when a tenant administrator successfully signs into SuperID.
const systemToken = 'YOUR_SYSTEM_USER_TOKEN_GOES_HERE';

// Partners private key
const privKeyFile = 'privatekey.pem';

// SuperOffice public key (SOD) 
// Open SuperOfficeFederatedLogin.crt in notepad,
// save contents as SuperOfficeFederatedLogin.pem

const publKeyFile = 'SuperOfficeFederatedLogin.pem';

fs.readFile(privKeyFile, 'utf8', function (err, rsaPrivateKey) {

  if (err) {
      return console.log(err);
  }
  console.log(rsaPrivateKey);
  const utcTimestamp = moment.utc().format('YYYYMMDDHHmm');
  const data = `${systemToken}.${utcTimestamp}`;
  console.log('');
  console.log('Token.Time: ' + data);
  let sign = crypto.createSign('SHA256');
  sign.update(data);
  sign.end();
  sign = sign.sign(rsaPrivateKey, 'base64');
  const signedToken = `${data}.${sign}`;
  console.log('');
  console.log('Signed Token: ' + signedToken);
  var soapEnvelope = `<?xml version="1.0" encoding="UTF-8"?>
  <SOAP-ENV:Envelope xmlns:ns0="http://schemas.xmlsoap.org/soap/envelope/"
                                      xmlns:ns1="http://www.superoffice.com/superid/partnersystemuser/0.1"
                                      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                                      xmlns:tns="http://www.superoffice.com/superid/partnersystemuser/0.1"
                                      xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/">
    <SOAP-ENV:Header>
      <tns:ApplicationToken>${appToken}</tns:ApplicationToken>
      <tns:ContextIdentifier>${contextId}</tns:ContextIdentifier>
    </SOAP-ENV:Header>
    <ns0:Body>
      <ns1:AuthenticationRequest>
          <ns1:SignedSystemToken>${signedToken}</ns1:SignedSystemToken>
          <ns1:ReturnTokenType>Jwt</ns1:ReturnTokenType>
      </ns1:AuthenticationRequest>
    </ns0:Body>
  </SOAP-ENV:Envelope>`;
  console.log('');
  console.log('SOAP: ' + soapEnvelope);
  // send the SOAP envelope to SuperOffice!
  request.post({
    url: 'https://sod.superoffice.com/login/services/PartnerSystemUserService.svc',
    body: soapEnvelope,
    headers: {
      "Content-Type": "text/xml;charset=UTF-8",
      "SOAPAction": "http://www.superoffice.com/superid/partnersystemuser/0.1/IPartnerSystemUserService/Authenticate"
    }
  }, function (error, response, body) {
    if (!error) {
      // convert the XML response to JSON!
      console.log('');
      console.log('Response: ' + body);
      xml2js.parseString(body, { tagNameProcessors: [xml2js.processors.stripPrefix] }, function (err, result) {
        console.log('');
        if (err) {
            console.log('Error converting XML to JSON!');
        } else {
          console.log('Converted to JSON: ' + JSON.stringify(result));
          // drill into the JSON to determine if token was received.
          var successful = result.Envelope.Body[0].AuthenticationResponse[0].IsSuccessful[0];
          if (successful === 'true') {
            // extract the token
            var token = result.Envelope.Body[0].AuthenticationResponse[0].Token[0];
            console.log('');
            console.log('Token: ' + JSON.stringify(token));
            var verifyOptions = {
              ignoreExpiration: true,
              algorithm: ["RS256"]
            };
            try {
              var publicKEY = fs.readFileSync(publKeyFile, 'utf8');
              // Verify the public SuperOffice certificate is loaded
              // this is used to validate the JWT sent back from SuperOffice
              if (publicKEY) {
                  console.log("good to go!");
              } else {
                  console.log("NOT good to go!");
                  return;
              }
              // validate the JWT and extract the claims
              var decoded = jwt.verify(token, publicKEY, verifyOptions);
              // write out the ticket to the console, DONE!
              console.log('');
              console.log('System User Ticket: ' + decoded["http://schemes.superoffice.net/identity/ticket"]);
            } catch (err) {
              console.log('');
              console.log('Error: ' + err);
              return false;
            }
          } else {
              console.log('Authentication failed and no token was received!');
          }
        }
      });
      } else {
          console.log('Error: ' + error);
      }
  });
});
