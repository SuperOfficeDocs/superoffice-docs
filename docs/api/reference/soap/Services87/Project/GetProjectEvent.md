---
title: Services87.ProjectAgent.GetProjectEvent SOAP
generated: 1
uid: Services87-Project-GetProjectEvent
---

# Services87 Project GetProjectEvent

SOAP request and response examples **Remote/Services87/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IProjectAgent.GetProjectEvent">SuperOffice.Services87.IProjectAgent.GetProjectEvent</see> method.

## GetProjectEvent

Gets a ProjectEvent object.

* **projectEventId:** The identifier of the ProjectEvent object

**Returns:** ProjectEvent


[WSDL file for Services87/Project](../Services87-Project.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectEvent Request

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
   <Project:GetProjectEvent>
    <Project:ProjectEventId xsi:type="xsd:int">0</Project:ProjectEventId>
   </Project:GetProjectEvent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectEvent Response

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
  <Project:GetProjectEventResponse>
   <Project:Response xsi:type="Project:ProjectEvent">
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
    <Project:EventDate xsi:type="xsd:dateTime">2021-11-30T13:23:23Z</Project:EventDate>
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
   </Project:Response>
  </Project:GetProjectEventResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

