---
uid: services88-email-createdefaultemailappointment
title: Services88.EMailAgent.CreateDefaultEMailAppointment SOAP
Generated: true
---

# Services88 EMail CreateDefaultEMailAppointment SOAP

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.CreateDefaultEMailAppointment">SuperOffice.Services88.IEMailAgent.CreateDefaultEMailAppointment</see> method.

## CreateDefaultEMailAppointment

Loading default values into a new EMailAppointment.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.


**Returns:** New EMailAppointment with default values


[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultEMailAppointment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateDefaultEMailAppointment>
   </EMail:CreateDefaultEMailAppointment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultEMailAppointment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:CreateDefaultEMailAppointmentResponse>
   <EMail:Response xsi:type="EMail:EMailAppointment">
    <EMail:Appointment xsi:type="EMail:Appointment">
     <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
     <EMail:StartDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:StartDate>
     <EMail:EndDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:EndDate>
     <EMail:Type xsi:type="EMail:AppointmentType">Unknown</EMail:Type>
     <EMail:Task xsi:type="xsd:string"></EMail:Task>
     <EMail:AssociateFullName xsi:type="xsd:string"></EMail:AssociateFullName>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:Description xsi:type="xsd:string"></EMail:Description>
     <EMail:PersonFullName xsi:type="xsd:string"></EMail:PersonFullName>
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
     <EMail:ProjectName xsi:type="xsd:string"></EMail:ProjectName>
     <EMail:IsPublished xsi:type="xsd:boolean">false</EMail:IsPublished>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     <EMail:ColorIndex xsi:type="xsd:short">0</EMail:ColorIndex>
     <EMail:IsFree xsi:type="xsd:boolean">false</EMail:IsFree>
     <EMail:HasAlarm xsi:type="xsd:boolean">false</EMail:HasAlarm>
     <EMail:IsAlldayEvent xsi:type="xsd:boolean">false</EMail:IsAlldayEvent>
     <EMail:Private xsi:type="EMail:AppointmentPrivate">Public</EMail:Private>
     <EMail:PriorityId xsi:type="xsd:int">0</EMail:PriorityId>
     <EMail:PriorityName xsi:type="xsd:string"></EMail:PriorityName>
     <EMail:TaskType xsi:type="EMail:TaskType">Unknown</EMail:TaskType>
     <EMail:IsBookingMain xsi:type="xsd:boolean">false</EMail:IsBookingMain>
     <EMail:IsRecurrence xsi:type="xsd:boolean">false</EMail:IsRecurrence>
     <EMail:IsBooking xsi:type="xsd:boolean">false</EMail:IsBooking>
     <EMail:ActiveDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:ActiveDate>
     <EMail:AssignmentStatus xsi:type="EMail:AssignmentStatus">Unknown</EMail:AssignmentStatus>
     <EMail:InvitationStatus xsi:type="EMail:InvitationStatus">Unknown</EMail:InvitationStatus>
     <EMail:BookingType xsi:type="EMail:BookingType">Unknown</EMail:BookingType>
     <EMail:Completed xsi:type="EMail:ActivityStatus">Unknown</EMail:Completed>
     <EMail:RecurringPattern xsi:type="EMail:RecurrencePattern">Unknown</EMail:RecurringPattern>
     <EMail:RecurringStartDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:RecurringStartDate>
     <EMail:RecurringEndDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:RecurringEndDate>
     <EMail:MotherId xsi:type="xsd:int">0</EMail:MotherId>
     <EMail:AssignedBy xsi:type="xsd:int">0</EMail:AssignedBy>
     <EMail:AssignedByFullName xsi:type="xsd:string"></EMail:AssignedByFullName>
     <EMail:RejectReason xsi:type="xsd:string"></EMail:RejectReason>
     <EMail:Location xsi:type="xsd:string"></EMail:Location>
     <EMail:AlarmLeadTime xsi:type="NetServerServices881:duration"></EMail:AlarmLeadTime>
     <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
     <EMail:SaleName xsi:type="xsd:string"></EMail:SaleName>
     <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
     <EMail:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:CreatedDate>
     <EMail:CreatedBy xsi:type="xsd:string"></EMail:CreatedBy>
     <EMail:CreatedByFullName xsi:type="xsd:string"></EMail:CreatedByFullName>
     <EMail:CreatedByAssociateId xsi:type="xsd:int">0</EMail:CreatedByAssociateId>
     <EMail:CautionWarning xsi:type="EMail:AppointmentCautionWarning">OK</EMail:CautionWarning>
     <EMail:JoinVideomeetUrl xsi:type="xsd:string"></EMail:JoinVideomeetUrl>
    </EMail:Appointment>
    <EMail:CalMethod xsi:type="EMail:CalMethod">Unknown</EMail:CalMethod>
    <EMail:Participants xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </EMail:Participants>
    <EMail:Comment xsi:type="xsd:string"></EMail:Comment>
    <EMail:Sequence xsi:type="xsd:int">0</EMail:Sequence>
    <EMail:DtStart xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:DtStart>
    <EMail:DtEnd xsi:type="xsd:dateTime">2021-03-25T21:36:57Z</EMail:DtEnd>
    <EMail:Superseded xsi:type="xsd:boolean">false</EMail:Superseded>
   </EMail:Response>
  </EMail:CreateDefaultEMailAppointmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

