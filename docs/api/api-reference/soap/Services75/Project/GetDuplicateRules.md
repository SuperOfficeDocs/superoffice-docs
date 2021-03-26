---
uid: services75-project-getduplicaterules
title: Services75.ProjectAgent.GetDuplicateRules SOAP
Generated: true
---

# Services75 Project GetDuplicateRules SOAP

SOAP request and response examples **Remote/Services75/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IProjectAgent.GetDuplicateRules">SuperOffice.Services75.IProjectAgent.GetDuplicateRules</see> method.

## GetDuplicateRules

Retrieve all available duplicate rules for project


**Returns:** All available duplicate rules


[WSDL file for Services75/Project](../Services75-Project.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDuplicateRules Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetDuplicateRules>
   </Project:GetDuplicateRules>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDuplicateRules Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Project:GetDuplicateRulesResponse>
   <Project:Response xsi:type="Project:ArrayOfDuplicateRule">
    <Project:DuplicateRule xsi:type="Project:DuplicateRule">
     <Project:Name xsi:type="xsd:string"></Project:Name>
     <Project:DisplayName xsi:type="xsd:string"></Project:DisplayName>
     <Project:DisplayTooltip xsi:type="xsd:string"></Project:DisplayTooltip>
     <Project:IsActive xsi:type="xsd:boolean">false</Project:IsActive>
    </Project:DuplicateRule>
   </Project:Response>
  </Project:GetDuplicateRulesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

