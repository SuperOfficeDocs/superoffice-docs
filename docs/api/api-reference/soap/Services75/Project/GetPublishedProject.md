---
uid: services75-project-getpublishedproject
title: Services75.ProjectAgent.GetPublishedProject SOAP
Generated: true
---

# Services75 Project GetPublishedProject SOAP

SOAP request and response examples **Remote/Services75/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IProjectAgent.GetPublishedProject">SuperOffice.Services75.IProjectAgent.GetPublishedProject</see> method.

## GetPublishedProject

Get published project by project id.

* **projectId:** The project id.

**Returns:** Project


[WSDL file for Services75/Project](../Services75-Project.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPublishedProject Request

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
   <Project:GetPublishedProject>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:GetPublishedProject>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPublishedProject Response

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
  <Project:GetPublishedProjectResponse>
   <Project:Response xsi:type="Project:Project">
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:Name xsi:type="xsd:string"></Project:Name>
    <Project:Description xsi:type="xsd:string"></Project:Description>
    <Project:URL xsi:type="xsd:string"></Project:URL>
    <Project:Type xsi:type="xsd:string"></Project:Type>
    <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
    <Project:AssociateFullName xsi:type="xsd:string"></Project:AssociateFullName>
    <Project:TypeId xsi:type="xsd:int">0</Project:TypeId>
    <Project:Updated xsi:type="xsd:dateTime">2021-03-25T21:32:29Z</Project:Updated>
    <Project:StatusId xsi:type="xsd:int">0</Project:StatusId>
    <Project:Status xsi:type="xsd:string"></Project:Status>
    <Project:TextId xsi:type="xsd:int">0</Project:TextId>
    <Project:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:32:29Z</Project:PublishTo>
    <Project:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:32:29Z</Project:PublishFrom>
    <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
    <Project:URLName xsi:type="xsd:string"></Project:URLName>
    <Project:ProjectNumber xsi:type="xsd:string"></Project:ProjectNumber>
    <Project:ActiveErpLinks xsi:type="xsd:int">0</Project:ActiveErpLinks>
   </Project:Response>
  </Project:GetPublishedProjectResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

