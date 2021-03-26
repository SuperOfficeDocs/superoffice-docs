---
uid: services81-user-getusergrouplist
title: Services81.UserAgent.GetUserGroupList SOAP
Generated: true
---

# Services81 User GetUserGroupList SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.GetUserGroupList">SuperOffice.Services81.IUserAgent.GetUserGroupList</see> method.

## GetUserGroupList

Gets an array of UserGroup objects.

* **userGroupIds:** The identifiers of the UserGroup object

**Returns:** Array of UserGroup objects


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserGroupList Request

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
   <User:GetUserGroupList>
    <User:UserGroupIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
    </User:UserGroupIds>
   </User:GetUserGroupList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserGroupList Response

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
  <User:GetUserGroupListResponse>
   <User:Response xsi:type="User:ArrayOfUserGroup">
    <User:UserGroup xsi:type="User:UserGroup">
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Deleted xsi:type="xsd:short">0</User:Deleted>
    </User:UserGroup>
   </User:Response>
  </User:GetUserGroupListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

