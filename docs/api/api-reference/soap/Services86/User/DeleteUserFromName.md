---
uid: services86-user-deleteuserfromname
title: Services86.UserAgent.DeleteUserFromName SOAP
Generated: true
---

# Services86 User DeleteUserFromName SOAP

SOAP request and response examples **Remote/Services86/User.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IUserAgent.DeleteUserFromName">SuperOffice.Services86.IUserAgent.DeleteUserFromName</see> method.

## DeleteUserFromName

Delete a user, with lookup based on the user name.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **userName:** User name of the user to delete.

**Returns:** This method has no return value


[WSDL file for Services86/User](../Services86-User.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteUserFromName Request

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
   <User:DeleteUserFromName>
    <User:UserName xsi:type="xsd:string"></User:UserName>
   </User:DeleteUserFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteUserFromName Response

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
  <User:DeleteUserFromNameResponse>
  </User:DeleteUserFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

