---
title: Services84.UserAgent.SetExternalUserInfo SOAP
generated: 1
uid: Services84-User-SetExternalUserInfo
---

# Services84 User SetExternalUserInfo

SOAP request and response examples **Remote/Services84/User.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IUserAgent.SetExternalUserInfo">SuperOffice.Services84.IUserAgent.SetExternalUserInfo</see> method.

## SetExternalUserInfo

Modifies an external user. Changes external users information according to the flags set in  externalUserInfoModification.

* **associateId:** The associateId to alter.
* **userName:** Login username.
* **password:** Login password.
* **isActive:** Set isActive to true to enable the external user to log in.
* **roleId:** Id of role for the external user. The role must be a role of type external users.
* **externalUserInfoModification:** externalUserInfoModification is a flag describing what to change. <see cref="T:SuperOffice.CRM.Services.Util.ExternalUserInfoModification" />.



[WSDL file for Services84/User](../Services84-User.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetExternalUserInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:SetExternalUserInfo>
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:UserName xsi:type="xsd:string"></User:UserName>
    <User:Password xsi:type="xsd:string"></User:Password>
    <User:IsActive xsi:type="xsd:boolean">false</User:IsActive>
    <User:RoleId xsi:type="xsd:int">0</User:RoleId>
    <User:ExternalUserInfoModification xsi:type="User:ExternalUserInfoModification">UserName</User:ExternalUserInfoModification>
   </User:SetExternalUserInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetExternalUserInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <User:SetExternalUserInfoResponse>
  </User:SetExternalUserInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

