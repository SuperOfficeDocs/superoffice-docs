---
title: Services87.AppointmentAgent.GetPersonAppointmentsByTaskHeading SOAP
generated: 1
uid: Services87-Appointment-GetPersonAppointmentsByTaskHeading
---

# Services87 Appointment GetPersonAppointmentsByTaskHeading

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.GetPersonAppointmentsByTaskHeading">SuperOffice.Services87.IAppointmentAgent.GetPersonAppointmentsByTaskHeading</see> method.

## GetPersonAppointmentsByTaskHeading

Method that returns a specified number of appointments of a specific appointment task heading within a time range. The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.

* **personId:** The person id of the SuperOffice user (associate).
* **includeProjectAppointments:** If true, all appointments that belong to projects where the user is a project member are included as well as the appointments belonging to the person.
* **startTime:** The start of the time interval we want appointments from. This will usually be the current time.
* **endTime:** The end of the time interval.
* **count:** The maximum number of appointments that should be returned. -1 means no count restrictions.
* **taskHeadingId:** The task heading id. The heading represents a grouping or filtering of tasks. Task represents the different types of activities, like “Phone call”, “Meeting” and so on.

**Returns:** Array of Appointments.


[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonAppointmentsByTaskHeading Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetPersonAppointmentsByTaskHeading>
    <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
    <Appointment:IncludeProjectAppointments xsi:type="xsd:boolean">false</Appointment:IncludeProjectAppointments>
    <Appointment:StartTime xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:StartTime>
    <Appointment:EndTime xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:EndTime>
    <Appointment:Count xsi:type="xsd:int">0</Appointment:Count>
    <Appointment:TaskHeadingId xsi:type="xsd:int">0</Appointment:TaskHeadingId>
   </Appointment:GetPersonAppointmentsByTaskHeading>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersonAppointmentsByTaskHeading Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Appointment:GetPersonAppointmentsByTaskHeadingResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfAppointment">
    <Appointment:Appointment xsi:type="Appointment:Appointment">
     <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
     <Appointment:StartDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:StartDate>
     <Appointment:EndDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:EndDate>
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
     <Appointment:ActiveDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:ActiveDate>
     <Appointment:AssignmentStatus xsi:type="Appointment:AssignmentStatus">Unknown</Appointment:AssignmentStatus>
     <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
     <Appointment:BookingType xsi:type="Appointment:BookingType">Unknown</Appointment:BookingType>
     <Appointment:Completed xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Completed>
     <Appointment:RecurringPattern xsi:type="Appointment:RecurrencePattern">Unknown</Appointment:RecurringPattern>
     <Appointment:RecurringStartDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:RecurringStartDate>
     <Appointment:RecurringEndDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:RecurringEndDate>
     <Appointment:MotherId xsi:type="xsd:int">0</Appointment:MotherId>
     <Appointment:AssignedBy xsi:type="xsd:int">0</Appointment:AssignedBy>
     <Appointment:AssignedByFullName xsi:type="xsd:string"></Appointment:AssignedByFullName>
     <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
     <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
     <Appointment:AlarmLeadTime xsi:type="NetServerServices871:duration"></Appointment:AlarmLeadTime>
     <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
     <Appointment:SaleName xsi:type="xsd:string"></Appointment:SaleName>
     <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
     <Appointment:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:08Z</Appointment:CreatedDate>
     <Appointment:CreatedBy xsi:type="xsd:string"></Appointment:CreatedBy>
     <Appointment:CreatedByFullName xsi:type="xsd:string"></Appointment:CreatedByFullName>
     <Appointment:CreatedByAssociateId xsi:type="xsd:int">0</Appointment:CreatedByAssociateId>
     <Appointment:CautionWarning xsi:type="Appointment:AppointmentCautionWarning">OK</Appointment:CautionWarning>
    </Appointment:Appointment>
   </Appointment:Response>
  </Appointment:GetPersonAppointmentsByTaskHeadingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

