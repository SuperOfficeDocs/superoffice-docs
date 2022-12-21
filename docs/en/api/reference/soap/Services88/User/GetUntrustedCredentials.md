---
title: Services88.UserAgent.GetUntrustedCredentials SOAP
generated: 1
uid: Services88-User-GetUntrustedCredentials
---

# Services88 User GetUntrustedCredentials

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GetUntrustedCredentials">SuperOffice.Services88.IUserAgent.GetUntrustedCredentials</see> method.

## GetUntrustedCredentials

Get a set of credentials of a specified type for authenticated user.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **type:** Type of credential(Ex: "imap", "smtp").

**Returns:** Array of credentials of the specified type.

[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUntrustedCredentials Request

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
   <User:GetUntrustedCredentials>
    <User:Type xsi:type="xsd:string"></User:Type>
   </User:GetUntrustedCredentials>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## GetUntrustedCredentials Response

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
  <User:GetUntrustedCredentialsResponse>
   <User:Response xsi:type="User:ArrayOfUntrustedCredentials">
    <User:UntrustedCredentials xsi:type="User:UntrustedCredentials">
     <User:ValidFrom xsi:type="xsd:dateTime">2022-08-26T09:00:49Z</User:ValidFrom>
     <User:ValidTo xsi:type="xsd:dateTime">2022-08-26T09:00:49Z</User:ValidTo>
     <User:Comment xsi:type="xsd:string"></User:Comment>
     <User:SecretValue xsi:type="xsd:string"></User:SecretValue>
     <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
     <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
    </User:UntrustedCredentials>
   </User:Response>
  </User:GetUntrustedCredentialsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
