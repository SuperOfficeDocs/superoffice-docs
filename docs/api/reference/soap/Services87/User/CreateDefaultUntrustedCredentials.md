---
title: Services87.UserAgent.CreateDefaultUntrustedCredentials SOAP
generated: 1
uid: Services87-User-CreateDefaultUntrustedCredentials
---

# Services87 User CreateDefaultUntrustedCredentials

SOAP request and response examples **Remote/Services87/User.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserAgent.CreateDefaultUntrustedCredentials">SuperOffice.Services87.IUserAgent.CreateDefaultUntrustedCredentials</see> method.

## CreateDefaultUntrustedCredentials

Loading default values into a new UntrustedCredentials.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.


**Returns:** New UntrustedCredentials with default values


[WSDL file for Services87/User](../Services87-User.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultUntrustedCredentials Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:CreateDefaultUntrustedCredentials>
   </User:CreateDefaultUntrustedCredentials>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultUntrustedCredentials Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <User:CreateDefaultUntrustedCredentialsResponse>
   <User:Response xsi:type="User:UntrustedCredentials">
    <User:ValidFrom xsi:type="xsd:dateTime">2022-08-26T08:58:03Z</User:ValidFrom>
    <User:ValidTo xsi:type="xsd:dateTime">2022-08-26T08:58:03Z</User:ValidTo>
    <User:Comment xsi:type="xsd:string"></User:Comment>
    <User:SecretValue xsi:type="xsd:string"></User:SecretValue>
    <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
    <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
   </User:Response>
  </User:CreateDefaultUntrustedCredentialsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

