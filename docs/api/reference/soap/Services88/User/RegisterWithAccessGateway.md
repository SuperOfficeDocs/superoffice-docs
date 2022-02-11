---
title: Services88.UserAgent.RegisterWithAccessGateway SOAP
generated: 1
uid: Services88-User-RegisterWithAccessGateway
---

# Services88 User RegisterWithAccessGateway

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.RegisterWithAccessGateway">SuperOffice.Services88.IUserAgent.RegisterWithAccessGateway</see> method.

## RegisterWithAccessGateway

Registers with access gateway if not already done, otherwise will attempt to update
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **redirectUri:** This is the registered redirect\_uri for AccessGateway OIDC.



[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegisterWithAccessGateway Request

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
   <User:RegisterWithAccessGateway>
    <User:RedirectUri xsi:type="xsd:string"></User:RedirectUri>
   </User:RegisterWithAccessGateway>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RegisterWithAccessGateway Response

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
  <User:RegisterWithAccessGatewayResponse>
   <User:Response xsi:type="User:AccessGatewayInfo">
    <User:ClientId xsi:type="xsd:string"></User:ClientId>
    <User:RedirectUri xsi:type="xsd:string"></User:RedirectUri>
   </User:Response>
  </User:RegisterWithAccessGatewayResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

