---
uid: services81-project-getprojecteventsonperson
title: Services81.ProjectAgent.GetProjectEventsOnPerson SOAP
Generated: true
---

# Services81 Project GetProjectEventsOnPerson SOAP

SOAP request and response examples **Remote/Services81/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IProjectAgent.GetProjectEventsOnPerson">SuperOffice.Services81.IProjectAgent.GetProjectEventsOnPerson</see> method.

## GetProjectEventsOnPerson

Gets all project events that belongs to the person specified. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.

* **personId:** Id of the person the project events belong to.

**Returns:** Array of project events


[WSDL file for Services81/Project](../Services81-Project.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectEventsOnPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetProjectEventsOnPerson>
    <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
   </Project:GetProjectEventsOnPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectEventsOnPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Project:GetProjectEventsOnPersonResponse>
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
     <Project:EventDate xsi:type="xsd:dateTime">2021-03-25T21:34:34Z</Project:EventDate>
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
  </Project:GetProjectEventsOnPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

