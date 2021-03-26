---
uid: services88-project-getproject
title: Services88.ProjectAgent.GetProject SOAP
Generated: true
---

# Services88 Project GetProject SOAP

SOAP request and response examples **Remote/Services88/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IProjectAgent.GetProject">SuperOffice.Services88.IProjectAgent.GetProject</see> method.

## GetProject

Gets a Project object.

* **projectId:** The identifier of the Project object

**Returns:** Project


[WSDL file for Services88/Project](../Services88-Project.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProject Request

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
   <Project:GetProject>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:GetProject>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProject Response

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
  <Project:GetProjectResponse>
   <Project:Response xsi:type="Project:Project">
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:Name xsi:type="xsd:string"></Project:Name>
    <Project:Description xsi:type="xsd:string"></Project:Description>
    <Project:URL xsi:type="xsd:string"></Project:URL>
    <Project:Type xsi:type="xsd:string"></Project:Type>
    <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
    <Project:AssociateFullName xsi:type="xsd:string"></Project:AssociateFullName>
    <Project:TypeId xsi:type="xsd:int">0</Project:TypeId>
    <Project:Updated xsi:type="xsd:dateTime">2021-03-25T21:37:06Z</Project:Updated>
    <Project:StatusId xsi:type="xsd:int">0</Project:StatusId>
    <Project:Status xsi:type="xsd:string"></Project:Status>
    <Project:TextId xsi:type="xsd:int">0</Project:TextId>
    <Project:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:37:06Z</Project:PublishTo>
    <Project:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:37:06Z</Project:PublishFrom>
    <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
    <Project:URLName xsi:type="xsd:string"></Project:URLName>
    <Project:ProjectNumber xsi:type="xsd:string"></Project:ProjectNumber>
    <Project:ActiveErpLinks xsi:type="xsd:int">0</Project:ActiveErpLinks>
   </Project:Response>
  </Project:GetProjectResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

