---
uid: services87-project-deleteprojectevententityfromprojectid
title: Services87.ProjectAgent.DeleteProjectEventEntityFromProjectId SOAP
Generated: true
---

# Services87 Project DeleteProjectEventEntityFromProjectId SOAP

SOAP request and response examples **Remote/Services87/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IProjectAgent.DeleteProjectEventEntityFromProjectId">SuperOffice.Services87.IProjectAgent.DeleteProjectEventEntityFromProjectId</see> method.

## DeleteProjectEventEntityFromProjectId

Delete a project event based on a project id. Does not delete the project, but does delete the published and ExternalEvent and AudienceVisibility records.

* **projectId:** The project id of the external event to delete.

**Returns:** Nothing


[WSDL file for Services87/Project](../Services87-Project.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteProjectEventEntityFromProjectId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:DeleteProjectEventEntityFromProjectId>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:DeleteProjectEventEntityFromProjectId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteProjectEventEntityFromProjectId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Project:DeleteProjectEventEntityFromProjectIdResponse>
  </Project:DeleteProjectEventEntityFromProjectIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

