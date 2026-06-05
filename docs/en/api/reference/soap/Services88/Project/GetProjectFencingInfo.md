---
title: Services88.ProjectAgent.GetProjectFencingInfo SOAP
generated: true
uid: Services88-Project-GetProjectFencingInfo
content_type: reference
---

# Services88 Project GetProjectFencingInfo

SOAP request and response examples **Remote/Services88/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IProjectAgent.GetProjectFencingInfo">SuperOffice.Services88.IProjectAgent.GetProjectFencingInfo</see> method.

## GetProjectFencingInfo





[WSDL file for Services88/Project](../Services88-Project.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectFencingInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetProjectFencingInfo>
   </Project:GetProjectFencingInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectFencingInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Project:GetProjectFencingInfoResponse>
   <Project:Response xsi:type="Project:FencingInfo">
    <Project:ActiveCount xsi:type="xsd:int">0</Project:ActiveCount>
    <Project:Maximum xsi:type="xsd:int">0</Project:Maximum>
    <Project:IsNearingMaximum xsi:type="xsd:boolean">false</Project:IsNearingMaximum>
    <Project:HasReachedMaximum xsi:type="xsd:boolean">false</Project:HasReachedMaximum>
    <Project:WarningMessage xsi:type="xsd:string"></Project:WarningMessage>
    <Project:WarningTooltip xsi:type="xsd:string"></Project:WarningTooltip>
   </Project:Response>
  </Project:GetProjectFencingInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

