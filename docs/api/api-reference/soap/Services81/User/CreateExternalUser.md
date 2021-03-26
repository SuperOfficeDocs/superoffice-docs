---
uid: services81-user-createexternaluser
title: Services81.UserAgent.CreateExternalUser SOAP
Generated: true
---

# Services81 User CreateExternalUser SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.CreateExternalUser">SuperOffice.Services81.IUserAgent.CreateExternalUser</see> method.

## CreateExternalUser

Creates an associate of type external user.

* **personId:** The personId to create an external user for.
* **userName:** Login username.
* **password:** Login password.
* **roleId:** Id of role for the external user. The role must be a role of type external users.
* **isActive:** Set isActive to true to enable the external user to log in.

**Returns:** Returns the created associateId.


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateExternalUser Request

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
   <User:CreateExternalUser>
    <User:PersonId xsi:type="xsd:int">0</User:PersonId>
    <User:UserName xsi:type="xsd:string"></User:UserName>
    <User:Password xsi:type="xsd:string"></User:Password>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
   </User:CreateExternalUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateExternalUser Response

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
  <User:CreateExternalUserResponse>
   <User:Response xsi:type="xsd:int">0</User:Response>
  </User:CreateExternalUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

