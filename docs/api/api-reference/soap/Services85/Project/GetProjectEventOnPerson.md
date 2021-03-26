---
uid: services85-project-getprojecteventonperson
title: Services85.ProjectAgent.GetProjectEventOnPerson SOAP
Generated: true
---

# Services85 Project GetProjectEventOnPerson SOAP

SOAP request and response examples **Remote/Services85/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IProjectAgent.GetProjectEventOnPerson">SuperOffice.Services85.IProjectAgent.GetProjectEventOnPerson</see> method.

## GetProjectEventOnPerson

Gets a ProjectEvent object from a project and a person.

* **projectId:** The project Id
* **personId:** Id of the person the project events belong to.



[WSDL file for Services85/Project](../Services85-Project.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectEventOnPerson Request

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
   <Project:GetProjectEventOnPerson>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
   </Project:GetProjectEventOnPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectEventOnPerson Response

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
  <Project:GetProjectEventOnPersonResponse>
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
    <Project:EventDate xsi:type="xsd:dateTime">2021-03-25T21:35:54Z</Project:EventDate>
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
  </Project:GetProjectEventOnPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

