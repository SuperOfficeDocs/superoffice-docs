---
title: Services88.UserAgent.DecryptAndSaveExternalTokens SOAP
generated: 1
uid: Services88-User-DecryptAndSaveExternalTokens
---

# Services88 User DecryptAndSaveExternalTokens

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.DecryptAndSaveExternalTokens">SuperOffice.Services88.IUserAgent.DecryptAndSaveExternalTokens</see> method.

## DecryptAndSaveExternalTokens

First asks AccessGateway to decrypt the tokens, then saves the external tokens to the DB and returns a key that can be used to retrieve them
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **tokenManagementInfo:** Token information.

**Returns:** Key that can be used to retrieve the tokens


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DecryptAndSaveExternalTokens Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:DecryptAndSaveExternalTokens>
    <User:TokenManagementInfo xsi:type="User:TokenManagementInfo">
     <User:Provider xsi:type="xsd:string"></User:Provider>
     <User:AccessToken xsi:type="xsd:string"></User:AccessToken>
     <User:RefreshToken xsi:type="xsd:string"></User:RefreshToken>
    </User:TokenManagementInfo>
   </User:DecryptAndSaveExternalTokens>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DecryptAndSaveExternalTokens Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:DecryptAndSaveExternalTokensResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:DecryptAndSaveExternalTokensResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

