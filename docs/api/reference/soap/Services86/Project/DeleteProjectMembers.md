---
title: Services86.ProjectAgent.DeleteProjectMembers SOAP
generated: 1
uid: Services86-Project-DeleteProjectMembers
---

# Services86 Project DeleteProjectMembers

SOAP request and response examples **Remote/Services86/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IProjectAgent.DeleteProjectMembers">SuperOffice.Services86.IProjectAgent.DeleteProjectMembers</see> method.

## DeleteProjectMembers

Delete the given project members from a project

* **projectEntityId:** Project to remove members from
* **memberIds:** Project member ids



[WSDL file for Services86/Project](../Services86-Project.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteProjectMembers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:DeleteProjectMembers>
    <Project:ProjectEntityId xsi:type="xsd:int">0</Project:ProjectEntityId>
    <Project:MemberIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </Project:MemberIds>
   </Project:DeleteProjectMembers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteProjectMembers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Project:DeleteProjectMembersResponse>
  </Project:DeleteProjectMembersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

