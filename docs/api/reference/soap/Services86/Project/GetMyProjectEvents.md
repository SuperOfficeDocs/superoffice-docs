---
title: Services86.ProjectAgent.GetMyProjectEvents SOAP
generated: 1
uid: Services86-Project-GetMyProjectEvents
---

# Services86 Project GetMyProjectEvents

SOAP request and response examples **Remote/Services86/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IProjectAgent.GetMyProjectEvents">SuperOffice.Services86.IProjectAgent.GetMyProjectEvents</see> method.

## GetMyProjectEvents

Gets all project events that belongs to the currently logged on user. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.


**Returns:** Array of project events


[WSDL file for Services86/Project](../Services86-Project.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyProjectEvents Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetMyProjectEvents>
   </Project:GetMyProjectEvents>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMyProjectEvents Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Project:GetMyProjectEventsResponse>
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
     <Project:EventDate xsi:type="xsd:dateTime">2022-08-26T08:55:38Z</Project:EventDate>
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
  </Project:GetMyProjectEventsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

