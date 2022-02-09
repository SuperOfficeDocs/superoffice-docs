---
title: Services86.ProjectAgent.DeleteProjectMember SOAP
generated: 1
uid: Services86-Project-DeleteProjectMember
---

# Services86 Project DeleteProjectMember

SOAP request and response examples **Remote/Services86/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IProjectAgent.DeleteProjectMember">SuperOffice.Services86.IProjectAgent.DeleteProjectMember</see> method.

## DeleteProjectMember

Deletes the ProjectMember

* **projectMemberId:** The identity of the ProjectMember



[WSDL file for Services86/Project](../Services86-Project.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteProjectMember Request

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
   <Project:DeleteProjectMember>
    <Project:ProjectMemberId xsi:type="xsd:int">0</Project:ProjectMemberId>
   </Project:DeleteProjectMember>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteProjectMember Response

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
  <Project:DeleteProjectMemberResponse>
  </Project:DeleteProjectMemberResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

