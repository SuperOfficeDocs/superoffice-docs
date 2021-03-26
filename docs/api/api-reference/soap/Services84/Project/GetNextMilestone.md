---
uid: services84-project-getnextmilestone
title: Services84.ProjectAgent.GetNextMilestone SOAP
Generated: true
---

# Services84 Project GetNextMilestone SOAP

SOAP request and response examples **Remote/Services84/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IProjectAgent.GetNextMilestone">SuperOffice.Services84.IProjectAgent.GetNextMilestone</see> method.

## GetNextMilestone

Next upcoming milestone appointment

* **projectId:** Project id - primary key

**Returns:** Upcoming milestone appointment


[WSDL file for Services84/Project](../Services84-Project.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextMilestone Request

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
   <Project:GetNextMilestone>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
   </Project:GetNextMilestone>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextMilestone Response

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
  <Project:GetNextMilestoneResponse>
   <Project:Response xsi:type="Project:Appointment">
    <Project:AppointmentId xsi:type="xsd:int">0</Project:AppointmentId>
    <Project:StartDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:StartDate>
    <Project:EndDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:EndDate>
    <Project:Type xsi:type="Project:AppointmentType">Unknown</Project:Type>
    <Project:Task xsi:type="xsd:string"></Project:Task>
    <Project:AssociateFullName xsi:type="xsd:string"></Project:AssociateFullName>
    <Project:ContactName xsi:type="xsd:string"></Project:ContactName>
    <Project:Description xsi:type="xsd:string"></Project:Description>
    <Project:PersonFullName xsi:type="xsd:string"></Project:PersonFullName>
    <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
    <Project:ContactId xsi:type="xsd:int">0</Project:ContactId>
    <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
    <Project:ProjectName xsi:type="xsd:string"></Project:ProjectName>
    <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
    <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
    <Project:ColorIndex xsi:type="xsd:short">0</Project:ColorIndex>
    <Project:IsFree xsi:type="xsd:boolean">false</Project:IsFree>
    <Project:HasAlarm xsi:type="xsd:boolean">false</Project:HasAlarm>
    <Project:IsAlldayEvent xsi:type="xsd:boolean">false</Project:IsAlldayEvent>
    <Project:Private xsi:type="Project:AppointmentPrivate">Public</Project:Private>
    <Project:PriorityId xsi:type="xsd:int">0</Project:PriorityId>
    <Project:PriorityName xsi:type="xsd:string"></Project:PriorityName>
    <Project:TaskType xsi:type="Project:TaskType">Unknown</Project:TaskType>
    <Project:IsBookingMain xsi:type="xsd:boolean">false</Project:IsBookingMain>
    <Project:IsRecurrence xsi:type="xsd:boolean">false</Project:IsRecurrence>
    <Project:IsBooking xsi:type="xsd:boolean">false</Project:IsBooking>
    <Project:ActiveDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:ActiveDate>
    <Project:AssignmentStatus xsi:type="Project:AssignmentStatus">Unknown</Project:AssignmentStatus>
    <Project:InvitationStatus xsi:type="Project:InvitationStatus">Unknown</Project:InvitationStatus>
    <Project:BookingType xsi:type="Project:BookingType">Unknown</Project:BookingType>
    <Project:Completed xsi:type="Project:ActivityStatus">Unknown</Project:Completed>
    <Project:RecurringPattern xsi:type="Project:RecurrencePattern">Unknown</Project:RecurringPattern>
    <Project:RecurringStartDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:RecurringStartDate>
    <Project:RecurringEndDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:RecurringEndDate>
    <Project:MotherId xsi:type="xsd:int">0</Project:MotherId>
    <Project:AssignedBy xsi:type="xsd:int">0</Project:AssignedBy>
    <Project:AssignedByFullName xsi:type="xsd:string"></Project:AssignedByFullName>
    <Project:RejectReason xsi:type="xsd:string"></Project:RejectReason>
    <Project:Location xsi:type="xsd:string"></Project:Location>
    <Project:AlarmLeadTime xsi:type="NetServerServices841:duration"></Project:AlarmLeadTime>
    <Project:SaleId xsi:type="xsd:int">0</Project:SaleId>
    <Project:SaleName xsi:type="xsd:string"></Project:SaleName>
    <Project:AssociateName xsi:type="xsd:string"></Project:AssociateName>
    <Project:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:33Z</Project:CreatedDate>
    <Project:CreatedBy xsi:type="xsd:string"></Project:CreatedBy>
    <Project:CreatedByFullName xsi:type="xsd:string"></Project:CreatedByFullName>
    <Project:CreatedByAssociateId xsi:type="xsd:int">0</Project:CreatedByAssociateId>
   </Project:Response>
  </Project:GetNextMilestoneResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

