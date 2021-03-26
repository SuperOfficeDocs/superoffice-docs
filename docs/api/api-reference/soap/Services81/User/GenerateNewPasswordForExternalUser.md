---
uid: services81-user-generatenewpasswordforexternaluser
title: Services81.UserAgent.GenerateNewPasswordForExternalUser SOAP
Generated: true
---

# Services81 User GenerateNewPasswordForExternalUser SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.GenerateNewPasswordForExternalUser">SuperOffice.Services81.IUserAgent.GenerateNewPasswordForExternalUser</see> method.

## GenerateNewPasswordForExternalUser

Generates a new password for an external user.

* **associateName:** The name of the associate to change the password for.

**Returns:** Returns the generated password.


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateNewPasswordForExternalUser Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GenerateNewPasswordForExternalUser>
    <User:AssociateName xsi:type="xsd:string"></User:AssociateName>
   </User:GenerateNewPasswordForExternalUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateNewPasswordForExternalUser Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <User:GenerateNewPasswordForExternalUserResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:GenerateNewPasswordForExternalUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

