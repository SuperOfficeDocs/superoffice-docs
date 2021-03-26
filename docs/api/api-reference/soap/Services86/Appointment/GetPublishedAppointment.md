---
uid: services86-appointment-getpublishedappointment
title: Services86.AppointmentAgent.GetPublishedAppointment SOAP
Generated: true
---

# Services86 Appointment GetPublishedAppointment SOAP

SOAP request and response examples **Remote/Services86/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IAppointmentAgent.GetPublishedAppointment">SuperOffice.Services86.IAppointmentAgent.GetPublishedAppointment</see> method.

## GetPublishedAppointment

Get published appointment by appointment id.

* **appointmentId:** The appointment id

**Returns:** Appointment


[WSDL file for Services86/Appointment](../Services86-Appointment.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPublishedAppointment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetPublishedAppointment>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
   </Appointment:GetPublishedAppointment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPublishedAppointment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Appointment:GetPublishedAppointmentResponse>
   <Appointment:Response xsi:type="Appointment:Appointment">
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:EndDate>
    <Appointment:Type xsi:type="Appointment:AppointmentType">Unknown</Appointment:Type>
    <Appointment:Task xsi:type="xsd:string"></Appointment:Task>
    <Appointment:AssociateFullName xsi:type="xsd:string"></Appointment:AssociateFullName>
    <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
    <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
    <Appointment:PersonFullName xsi:type="xsd:string"></Appointment:PersonFullName>
    <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
    <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
    <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
    <Appointment:ProjectName xsi:type="xsd:string"></Appointment:ProjectName>
    <Appointment:IsPublished xsi:type="xsd:boolean">false</Appointment:IsPublished>
    <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
    <Appointment:ColorIndex xsi:type="xsd:short">0</Appointment:ColorIndex>
    <Appointment:IsFree xsi:type="xsd:boolean">false</Appointment:IsFree>
    <Appointment:HasAlarm xsi:type="xsd:boolean">false</Appointment:HasAlarm>
    <Appointment:IsAlldayEvent xsi:type="xsd:boolean">false</Appointment:IsAlldayEvent>
    <Appointment:Private xsi:type="Appointment:AppointmentPrivate">Public</Appointment:Private>
    <Appointment:PriorityId xsi:type="xsd:int">0</Appointment:PriorityId>
    <Appointment:PriorityName xsi:type="xsd:string"></Appointment:PriorityName>
    <Appointment:TaskType xsi:type="Appointment:TaskType">Unknown</Appointment:TaskType>
    <Appointment:IsBookingMain xsi:type="xsd:boolean">false</Appointment:IsBookingMain>
    <Appointment:IsRecurrence xsi:type="xsd:boolean">false</Appointment:IsRecurrence>
    <Appointment:IsBooking xsi:type="xsd:boolean">false</Appointment:IsBooking>
    <Appointment:ActiveDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:ActiveDate>
    <Appointment:AssignmentStatus xsi:type="Appointment:AssignmentStatus">Unknown</Appointment:AssignmentStatus>
    <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
    <Appointment:BookingType xsi:type="Appointment:BookingType">Unknown</Appointment:BookingType>
    <Appointment:Completed xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Completed>
    <Appointment:RecurringPattern xsi:type="Appointment:RecurrencePattern">Unknown</Appointment:RecurringPattern>
    <Appointment:RecurringStartDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:RecurringStartDate>
    <Appointment:RecurringEndDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:RecurringEndDate>
    <Appointment:MotherId xsi:type="xsd:int">0</Appointment:MotherId>
    <Appointment:AssignedBy xsi:type="xsd:int">0</Appointment:AssignedBy>
    <Appointment:AssignedByFullName xsi:type="xsd:string"></Appointment:AssignedByFullName>
    <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
    <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
    <Appointment:AlarmLeadTime xsi:type="NetServerServices861:duration"></Appointment:AlarmLeadTime>
    <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
    <Appointment:SaleName xsi:type="xsd:string"></Appointment:SaleName>
    <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
    <Appointment:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Appointment:CreatedDate>
    <Appointment:CreatedBy xsi:type="xsd:string"></Appointment:CreatedBy>
    <Appointment:CreatedByFullName xsi:type="xsd:string"></Appointment:CreatedByFullName>
    <Appointment:CreatedByAssociateId xsi:type="xsd:int">0</Appointment:CreatedByAssociateId>
   </Appointment:Response>
  </Appointment:GetPublishedAppointmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

