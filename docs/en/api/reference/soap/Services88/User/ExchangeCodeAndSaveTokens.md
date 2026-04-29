---
title: Services88.UserAgent.ExchangeCodeAndSaveTokens SOAP
generated: true
uid: Services88-User-ExchangeCodeAndSaveTokens
content_type: reference
---

# Services88 User ExchangeCodeAndSaveTokens

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.ExchangeCodeAndSaveTokens">SuperOffice.Services88.IUserAgent.ExchangeCodeAndSaveTokens</see> method.

## ExchangeCodeAndSaveTokens





[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExchangeCodeAndSaveTokens Request

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
   <User:ExchangeCodeAndSaveTokens>
    <User:Provider xsi:type="xsd:string"></User:Provider>
    <User:AuthorizationCode xsi:type="xsd:string"></User:AuthorizationCode>
    <User:Nonce xsi:type="xsd:string"></User:Nonce>
    <User:PkceVerifier xsi:type="xsd:string"></User:PkceVerifier>
    <User:RedirectUri xsi:type="xsd:string"></User:RedirectUri>
   </User:ExchangeCodeAndSaveTokens>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExchangeCodeAndSaveTokens Response

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
  <User:ExchangeCodeAndSaveTokensResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:ExchangeCodeAndSaveTokensResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

