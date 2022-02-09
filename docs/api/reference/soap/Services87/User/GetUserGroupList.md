---
title: Services87.UserAgent.GetUserGroupList SOAP
generated: 1
uid: Services87-User-GetUserGroupList
---

# Services87 User GetUserGroupList

SOAP request and response examples **Remote/Services87/User.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserAgent.GetUserGroupList">SuperOffice.Services87.IUserAgent.GetUserGroupList</see> method.

## GetUserGroupList

Gets an array of UserGroup objects.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **userGroupIds:** The identifiers of the UserGroup object

**Returns:** Array of UserGroup objects


[WSDL file for Services87/User](../Services87-User.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserGroupList Request

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
   <User:GetUserGroupList>
    <User:UserGroupIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <User:GetUserGroupListResponse>
   <User:Response xsi:type="User:ArrayOfUserGroup">
    <User:UserGroup xsi:type="User:UserGroup">
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
    </User:UserGroup>
   </User:Response>
  </User:GetUserGroupListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

