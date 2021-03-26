---
uid: services86-user-getusergroup
title: Services86.UserAgent.GetUserGroup SOAP
Generated: true
---

# Services86 User GetUserGroup SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.GetUserGroup">SuperOffice.Services86.IUserAgent.GetUserGroup</see> method.

## GetUserGroup

Gets a UserGroup object.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **userGroupId:** The identifier of the UserGroup object

**Returns:** UserGroup


[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:GetUserGroup>
    <User:UserGroupId xsi:type="xsd:int">0</User:UserGroupId>
   </User:GetUserGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <User:GetUserGroupResponse>
   <User:Response xsi:type="User:UserGroup">
    <User:Value xsi:type="xsd:string"></User:Value>
    <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
    <User:Id xsi:type="xsd:int">0</User:Id>
    <User:Rank xsi:type="xsd:short">0</User:Rank>
    <User:Deleted xsi:type="xsd:short">0</User:Deleted>
   </User:Response>
  </User:GetUserGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

