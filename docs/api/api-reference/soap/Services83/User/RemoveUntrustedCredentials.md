---
uid: services83-user-removeuntrustedcredentials
title: Services83.UserAgent.RemoveUntrustedCredentials SOAP
Generated: true
---

# Services83 User RemoveUntrustedCredentials SOAP

SOAP request and response examples **Remote/Services83/User.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IUserAgent.RemoveUntrustedCredentials">SuperOffice.Services83.IUserAgent.RemoveUntrustedCredentials</see> method.

## RemoveUntrustedCredentials

Remove a credentials entry for authenticated user.

* **type:** Type of credential(Ex: "imap", "smtp")
* **publicValue:** PublicValue field of credentials to remove.



[WSDL file for Services83/User](../Services83-User.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveUntrustedCredentials Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:RemoveUntrustedCredentials>
    <User:Type xsi:type="xsd:string"></User:Type>
    <User:PublicValue xsi:type="xsd:string"></User:PublicValue>
   </User:RemoveUntrustedCredentials>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveUntrustedCredentials Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <User:RemoveUntrustedCredentialsResponse>
  </User:RemoveUntrustedCredentialsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

