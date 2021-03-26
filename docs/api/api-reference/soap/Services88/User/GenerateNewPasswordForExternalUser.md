---
uid: services88-user-generatenewpasswordforexternaluser
title: Services88.UserAgent.GenerateNewPasswordForExternalUser SOAP
Generated: true
---

# Services88 User GenerateNewPasswordForExternalUser SOAP

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.GenerateNewPasswordForExternalUser">SuperOffice.Services88.IUserAgent.GenerateNewPasswordForExternalUser</see> method.

## GenerateNewPasswordForExternalUser

Generates a new password for an external user.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **associateName:** The name of the associate to change the password for.

**Returns:** Returns the generated password.


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateNewPasswordForExternalUser Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:GenerateNewPasswordForExternalUserResponse>
   <User:Response xsi:type="xsd:string"></User:Response>
  </User:GenerateNewPasswordForExternalUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

