---
uid: services88-user-changepasswordfromname
title: Services88.UserAgent.ChangePasswordFromName SOAP
Generated: true
---

# Services88 User ChangePasswordFromName SOAP

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.ChangePasswordFromName">SuperOffice.Services88.IUserAgent.ChangePasswordFromName</see> method.

## ChangePasswordFromName

Change password for a user.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **associateName:** Username of the user to change password for.
* **oldPassword:** The current password of the user.  Administrators can leave this blank to force a new password upon a user.
* **newPassword:** The new password for the user

**Returns:** True if the password was successfully changed.


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangePasswordFromName Request

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
   <User:ChangePasswordFromName>
    <User:AssociateName xsi:type="xsd:string"></User:AssociateName>
    <User:OldPassword xsi:type="xsd:string"></User:OldPassword>
    <User:NewPassword xsi:type="xsd:string"></User:NewPassword>
   </User:ChangePasswordFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangePasswordFromName Response

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
  <User:ChangePasswordFromNameResponse>
   <User:Response xsi:type="xsd:boolean">false</User:Response>
  </User:ChangePasswordFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

