---
title: Services88.UserAgent.GetAccessToken SOAP
generated: 1
uid: Services88-User-GetAccessToken
---

# Services88 User GetAccessToken

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetAccessToken">SuperOffice.Services88.IUserAgent.GetAccessToken</see> method.

## GetAccessToken

Get an access token based on the current user's session.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **app_token:** Application token to get access on behalf of. Optional.
* **includeCsSession:** Initialize CS session for this access token?.

**Returns:** An access token. "8A:xyz123=="


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAccessToken Request

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
   <User:GetAccessToken>
    <User:AppToken xsi:type="xsd:string"></User:AppToken>
    <User:IncludeCsSession xsi:type="xsd:boolean">false</User:IncludeCsSession>
   </User:GetAccessToken>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAccessToken Response

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
  <User:GetAccessTokenResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:GetAccessTokenResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

