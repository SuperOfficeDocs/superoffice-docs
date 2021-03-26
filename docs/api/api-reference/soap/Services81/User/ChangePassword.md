---
uid: services81-user-changepassword
title: Services81.UserAgent.ChangePassword SOAP
Generated: true
---

# Services81 User ChangePassword SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.ChangePassword">SuperOffice.Services81.IUserAgent.ChangePassword</see> method.

## ChangePassword

Change password for a user.

* **associateId:** AssociateId of the user to change password for.
* **oldPassword:** The current password of the user.  Administrators can leave this blank to force a new password upon a user.
* **newPassword:** The new password for the user

**Returns:** True if the password was successfully changed.


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangePassword Request

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
   <User:ChangePassword>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:OldPassword xsi:type="xsd:string"></User:OldPassword>
    <User:NewPassword xsi:type="xsd:string"></User:NewPassword>
   </User:ChangePassword>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangePassword Response

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
  <User:ChangePasswordResponse>
   <User:Response xsi:type="xsd:boolean">false</User:Response>
  </User:ChangePasswordResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

