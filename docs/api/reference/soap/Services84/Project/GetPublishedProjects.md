---
title: Services84.ProjectAgent.GetPublishedProjects SOAP
generated: 1
uid: Services84-Project-GetPublishedProjects
---

# Services84 Project GetPublishedProjects

SOAP request and response examples **Remote/Services84/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IProjectAgent.GetPublishedProjects">SuperOffice.Services84.IProjectAgent.GetPublishedProjects</see> method.

## GetPublishedProjects

Get published projects by project ids.

* **projectIds:** The array of project ids

**Returns:** Projects


[WSDL file for Services84/Project](../Services84-Project.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPublishedProjects Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetPublishedProjects>
    <Project:ProjectIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Project:ProjectIds>
   </Project:GetPublishedProjects>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPublishedProjects Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Project:GetPublishedProjectsResponse>
   <Project:Response xsi:type="Project:ArrayOfProject">
    <Project:Project xsi:type="Project:Project">
     <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
     <Project:Name xsi:type="xsd:string"></Project:Name>
     <Project:Description xsi:type="xsd:string"></Project:Description>
     <Project:URL xsi:type="xsd:string"></Project:URL>
     <Project:Type xsi:type="xsd:string"></Project:Type>
     <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
     <Project:AssociateFullName xsi:type="xsd:string"></Project:AssociateFullName>
     <Project:TypeId xsi:type="xsd:int">0</Project:TypeId>
     <Project:Updated xsi:type="xsd:dateTime">2022-08-26T08:51:33Z</Project:Updated>
     <Project:StatusId xsi:type="xsd:int">0</Project:StatusId>
     <Project:Status xsi:type="xsd:string"></Project:Status>
     <Project:TextId xsi:type="xsd:int">0</Project:TextId>
     <Project:PublishTo xsi:type="xsd:dateTime">2022-08-26T08:51:33Z</Project:PublishTo>
     <Project:PublishFrom xsi:type="xsd:dateTime">2022-08-26T08:51:33Z</Project:PublishFrom>
     <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
     <Project:URLName xsi:type="xsd:string"></Project:URLName>
     <Project:ProjectNumber xsi:type="xsd:string"></Project:ProjectNumber>
     <Project:ActiveErpLinks xsi:type="xsd:int">0</Project:ActiveErpLinks>
    </Project:Project>
   </Project:Response>
  </Project:GetPublishedProjectsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

