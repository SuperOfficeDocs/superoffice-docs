---
title: Services88.UserAgent.GetOrRegisterAccessGatewayInfo SOAP
generated: 1
uid: Services88-User-GetOrRegisterAccessGatewayInfo
---

# Services88 User GetOrRegisterAccessGatewayInfo

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetOrRegisterAccessGatewayInfo">SuperOffice.Services88.IUserAgent.GetOrRegisterAccessGatewayInfo</see> method.

## GetOrRegisterAccessGatewayInfo

Returns accessgateway registration info and registers a new or adds the url if necessary
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **redirectUri:** This is the registered redirect\_uri for AccessGateway OIDC.



[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetOrRegisterAccessGatewayInfo Request

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
   <User:GetOrRegisterAccessGatewayInfo>
    <User:RedirectUri xsi:type="xsd:string"></User:RedirectUri>
   </User:GetOrRegisterAccessGatewayInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetOrRegisterAccessGatewayInfo Response

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
  <User:GetOrRegisterAccessGatewayInfoResponse>
   <User:Response xsi:type="User:AccessGatewayInfo">
    <User:ClientId xsi:type="xsd:string"></User:ClientId>
    <User:RedirectUri xsi:type="xsd:string"></User:RedirectUri>
   </User:Response>
  </User:GetOrRegisterAccessGatewayInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

