---
uid: services82-user-deleterole
title: Services82.UserAgent.DeleteRole SOAP
Generated: true
---

# Services82 User DeleteRole SOAP

SOAP request and response examples **Remote/Services82/User.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IUserAgent.DeleteRole">SuperOffice.Services82.IUserAgent.DeleteRole</see> method.

## DeleteRole

This method will delete the specified role and move all users associated with the role to the replacingRoleId

* **roleIdToDelete:** The roleId to delete
* **replacingRoleId:** The roleId which all associated users will be moved to.



[WSDL file for Services82/User](../Services82-User.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteRole Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:DeleteRole>
    <User:RoleIdToDelete xsi:type="xsd:int">0</User:RoleIdToDelete>
    <User:ReplacingRoleId xsi:type="xsd:int">0</User:ReplacingRoleId>
   </User:DeleteRole>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteRole Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <User:DeleteRoleResponse>
  </User:DeleteRoleResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

