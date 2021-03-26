---
uid: services75-user-deleteusergroup
title: Services75.UserAgent.DeleteUserGroup SOAP
Generated: true
---

# Services75 User DeleteUserGroup SOAP

SOAP request and response examples **Remote/Services75/User.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IUserAgent.DeleteUserGroup">SuperOffice.Services75.IUserAgent.DeleteUserGroup</see> method.

## DeleteUserGroup

Delete a usergroup and move its members to another usergroup

* **userGroupToDelete:** The id of the userGroup to delete
* **userGroupToMoveTo:** The id of the userGroup to move the members to



[WSDL file for Services75/User](../Services75-User.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteUserGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:DeleteUserGroup>
    <User:UserGroupToDelete xsi:type="xsd:int">0</User:UserGroupToDelete>
    <User:UserGroupToMoveTo xsi:type="xsd:int">0</User:UserGroupToMoveTo>
   </User:DeleteUserGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteUserGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <User:DeleteUserGroupResponse>
  </User:DeleteUserGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

