const crypto = require('crypto');
const moment = require('moment');
const fs = require('fs');
const axios = require('axios');
const jwt = require('jsonwebtoken');

// specify the environment
// sod      => development
// qastage  => stage
// online   => production
const env = 'sod';

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

const getSystemUserTicket = async () => {
  try {
    const privateKeyFile = fs.readFileSync(privKeyFile,'utf8');
    const publicKeyFile  = fs.readFileSync(publKeyFile, 'utf8');
  
    // prepare the datetime stamp
    const utcTimestamp = moment.utc().format('YYYYMMDDHHmm');
    const data = `${systemToken}.${utcTimestamp}`;
    
    log('Token.Time: ' + data);
  
    // sign the System User token
    let sign = crypto.createSign('SHA256');
    sign.update(data);
    sign.end();
    sign = sign.sign(privateKeyFile, 'base64');
    const signedToken = `${data}.${sign}`;
    
    log('Signed Token: ' + signedToken);
  
    // send the request
  
    var postData = {
        'SignedSystemToken': `${signedToken}`,
        'ApplicationToken': `${appToken}`,
        'ContextIdentifier': `${contextId}`,
        'ReturnTokenType': 'JWT'
    };
    
    let axiosConfig = {
      headers: {
          'Content-Type': 'application/json;charset=UTF-8',
          "Accept": "application/json;charset=UTF-8"
      }
    };
  
    const jwtRes = await axios.post(`https://${env}.superoffice.com/Login/api/PartnerSystemUser/Authenticate`, postData, axiosConfig);
  
    if(jwtRes.data.IsSuccessful)
    {
      var token = jwtRes.data.Token;
  
      var verifyOptions = {
        ignoreExpiration: true,
        algorithm: ["RS256"]
      };
    
      // validate the JWT and extract the claims
      var decoded = jwt.verify(token, publicKeyFile, verifyOptions);
      
      // write out the ticket to the console, DONE!
      const ticket = decoded["http://schemes.superoffice.net/identity/ticket"];
      return ticket;
    } else {
      log('Getting the System User ticket was unsuccessful: ' + jwtRes.data.ErrorMessage);
    } 
  } catch (error) {
    log("Error: " + error);
  }  
}

function log(message) {
  console.log('')
  console.log(message)
}

// Finally, execute the function to get the system user ticket!

(async () => {
  try {
    const result = await getSystemUserTicket();
    log("System User Ticket: " + result);
  } catch (error) {
    log(error);
  }
})();