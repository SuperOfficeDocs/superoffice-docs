---
uid: services88-project-getprojecteventlist
title: Services88.ProjectAgent.GetProjectEventList SOAP
Generated: true
---

# Services88 Project GetProjectEventList SOAP

SOAP request and response examples **Remote/Services88/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IProjectAgent.GetProjectEventList">SuperOffice.Services88.IProjectAgent.GetProjectEventList</see> method.

## GetProjectEventList

Gets an array of ProjectEvent objects.

* **projectEventIds:** The identifiers of the ProjectEvent object

**Returns:** Array of ProjectEvent objects


[WSDL file for Services88/Project](../Services88-Project.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectEventList Request

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
   <Project:GetProjectEventList>
    <Project:ProjectEventIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Project:ProjectEventIds>
   </Project:GetProjectEventList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectEventList Response

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
  <Project:GetProjectEventListResponse>
   <Project:Response xsi:type="Project:ArrayOfProjectEvent">
    <Project:ProjectEvent xsi:type="Project:ProjectEvent">
     <Project:AssociateFullName xsi:type="xsd:string"></Project:AssociateFullName>
     <Project:Description xsi:type="xsd:string"></Project:Description>
     <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
     <Project:EventName xsi:type="xsd:string"></Project:EventName>
     <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
     <Project:IsSignedOn xsi:type="xsd:boolean">false</Project:IsSignedOn>
     <Project:SignOffConfirmationText xsi:type="xsd:string"></Project:SignOffConfirmationText>
     <Project:SignOffText xsi:type="xsd:string"></Project:SignOffText>
     <Project:SignOnConfirmationText xsi:type="xsd:string"></Project:SignOnConfirmationText>
     <Project:SignOnText xsi:type="xsd:string"></Project:SignOnText>
     <Project:EventDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:EventDate>
     <Project:Enabled xsi:type="xsd:boolean">false</Project:Enabled>
     <Project:SignOff xsi:type="xsd:boolean">false</Project:SignOff>
     <Project:SignOffTaskEnable xsi:type="xsd:boolean">false</Project:SignOffTaskEnable>
     <Project:SignOnTaskEnable xsi:type="xsd:boolean">false</Project:SignOnTaskEnable>
     <Project:SignOn xsi:type="xsd:boolean">false</Project:SignOn>
     <Project:SignOffTaskId xsi:type="xsd:int">0</Project:SignOffTaskId>
     <Project:SignOnTaskId xsi:type="xsd:int">0</Project:SignOnTaskId>
     <Project:SignOffTriggersAssign xsi:type="xsd:boolean">false</Project:SignOffTriggersAssign>
     <Project:SignOnTriggersAssign xsi:type="xsd:boolean">false</Project:SignOnTriggersAssign>
     <Project:SignOnPersonId xsi:type="xsd:int">0</Project:SignOnPersonId>
     <Project:SignOffPersonId xsi:type="xsd:int">0</Project:SignOffPersonId>
    </Project:ProjectEvent>
   </Project:Response>
  </Project:GetProjectEventListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

