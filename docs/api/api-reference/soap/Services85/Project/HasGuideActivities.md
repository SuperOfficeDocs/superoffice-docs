---
uid: services85-project-hasguideactivities
title: Services85.ProjectAgent.HasGuideActivities SOAP
Generated: true
---

# Services85 Project HasGuideActivities SOAP

SOAP request and response examples **Remote/Services85/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IProjectAgent.HasGuideActivities">SuperOffice.Services85.IProjectAgent.HasGuideActivities</see> method.

## HasGuideActivities



* **projectId:** 



[WSDL file for Services85/Project](../Services85-Project.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasGuideActivities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:HasGuideActivities>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:HasGuideActivities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasGuideActivities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Project:HasGuideActivitiesResponse>
   <Project:Response xsi:type="xsd:boolean">false</Project:Response>
  </Project:HasGuideActivitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

