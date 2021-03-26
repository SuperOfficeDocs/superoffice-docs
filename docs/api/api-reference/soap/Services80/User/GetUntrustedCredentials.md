---
uid: services80-user-getuntrustedcredentials
title: Services80.UserAgent.GetUntrustedCredentials SOAP
Generated: true
---

# Services80 User GetUntrustedCredentials SOAP

SOAP request and response examples **Remote/Services80/User.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IUserAgent.GetUntrustedCredentials">SuperOffice.Services80.IUserAgent.GetUntrustedCredentials</see> method.

## GetUntrustedCredentials

Get a set of credentials of a specified type for authenticated user.

* **type:** Type of credential(Ex: "imap", "smtp").

**Returns:** Array of credentials of the specified type.


[WSDL file for Services80/User](../Services80-User.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUntrustedCredentials Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <User:GetUntrustedCredentialsResponse>
   <User:Response xsi:type="User:ArrayOfUntrustedCredentials">
    <User:UntrustedCredentials xsi:type="User:UntrustedCredentials">
     <User:ValidFrom xsi:type="xsd:dateTime">2021-03-25T21:34:20Z</User:ValidFrom>
     <User:ValidTo xsi:type="xsd:dateTime">2021-03-25T21:34:20Z</User:ValidTo>
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

