---
uid: services83-project-deleteprojectmemberbyids
title: Services83.ProjectAgent.DeleteProjectMemberByIds SOAP
Generated: true
---

# Services83 Project DeleteProjectMemberByIds SOAP

SOAP request and response examples **Remote/Services83/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IProjectAgent.DeleteProjectMemberByIds">SuperOffice.Services83.IProjectAgent.DeleteProjectMemberByIds</see> method.

## DeleteProjectMemberByIds

Deletes projectmembers rows.

* **projectMemberIds:** An Array of projectmember ids.



[WSDL file for Services83/Project](../Services83-Project.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteProjectMemberByIds Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:DeleteProjectMemberByIds>
    <Project:ProjectMemberIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </Project:ProjectMemberIds>
   </Project:DeleteProjectMemberByIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteProjectMemberByIds Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Project:DeleteProjectMemberByIdsResponse>
  </Project:DeleteProjectMemberByIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

