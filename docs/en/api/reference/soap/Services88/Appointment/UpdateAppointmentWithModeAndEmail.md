---
title: Services88.AppointmentAgent.UpdateAppointmentWithModeAndEmail SOAP
generated: true
uid: Services88-Appointment-UpdateAppointmentWithModeAndEmail
---

# Services88 Appointment UpdateAppointmentWithModeAndEmail

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.UpdateAppointmentWithModeAndEmail">SuperOffice.Services88.IAppointmentAgent.UpdateAppointmentWithModeAndEmail</see> method.

## UpdateAppointmentWithModeAndEmail





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateAppointmentWithModeAndEmail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:UpdateAppointmentWithModeAndEmail>
    <Appointment:Id xsi:type="xsd:int">0</Appointment:Id>
    <Appointment:StartTime xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:StartTime>
    <Appointment:EndTime xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:EndTime>
    <Appointment:Status xsi:type="Appointment:AppointmentStatus">UnknownOrPostIt</Appointment:Status>
    <Appointment:Type xsi:type="Appointment:AppointmentType">Unknown</Appointment:Type>
    <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
    <Appointment:UpdateMode xsi:type="Appointment:RecurrenceUpdateMode">Unknown</Appointment:UpdateMode>
    <Appointment:SendEmailToParticipants xsi:type="xsd:boolean">false</Appointment:SendEmailToParticipants>
    <Appointment:SmtpEMailConnectionInfo xsi:type="Appointment:EMailConnectionInfo">
     <Appointment:ServerName xsi:type="xsd:string"></Appointment:ServerName>
     <Appointment:UserName xsi:type="xsd:string"></Appointment:UserName>
     <Appointment:Password xsi:type="xsd:string"></Appointment:Password>
     <Appointment:Folder xsi:type="xsd:string"></Appointment:Folder>
     <Appointment:UseSSL xsi:type="xsd:boolean">false</Appointment:UseSSL>
    </Appointment:SmtpEMailConnectionInfo>
    <Appointment:ImapEMailConnectionInfo xsi:type="Appointment:EMailConnectionInfo">
     <Appointment:ServerName xsi:type="xsd:string"></Appointment:ServerName>
     <Appointment:UserName xsi:type="xsd:string"></Appointment:UserName>
     <Appointment:Password xsi:type="xsd:string"></Appointment:Password>
     <Appointment:Folder xsi:type="xsd:string"></Appointment:Folder>
     <Appointment:UseSSL xsi:type="xsd:boolean">false</Appointment:UseSSL>
    </Appointment:ImapEMailConnectionInfo>
   </Appointment:UpdateAppointmentWithModeAndEmail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateAppointmentWithModeAndEmail Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Appointment:UpdateAppointmentWithModeAndEmailResponse>
   <Appointment:Response xsi:type="Appointment:Appointment">
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:StartDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:EndDate>
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
    <Appointment:ActiveDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:ActiveDate>
    <Appointment:AssignmentStatus xsi:type="Appointment:AssignmentStatus">Unknown</Appointment:AssignmentStatus>
    <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
    <Appointment:BookingType xsi:type="Appointment:BookingType">Unknown</Appointment:BookingType>
    <Appointment:Completed xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Completed>
    <Appointment:RecurringPattern xsi:type="Appointment:RecurrencePattern">Unknown</Appointment:RecurringPattern>
    <Appointment:RecurringStartDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:RecurringStartDate>
    <Appointment:RecurringEndDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:RecurringEndDate>
    <Appointment:MotherId xsi:type="xsd:int">0</Appointment:MotherId>
    <Appointment:AssignedBy xsi:type="xsd:int">0</Appointment:AssignedBy>
    <Appointment:AssignedByFullName xsi:type="xsd:string"></Appointment:AssignedByFullName>
    <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
    <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
    <Appointment:AlarmLeadTime xsi:type="NetServerServices881:duration"></Appointment:AlarmLeadTime>
    <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
    <Appointment:SaleName xsi:type="xsd:string"></Appointment:SaleName>
    <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
    <Appointment:CreatedDate xsi:type="xsd:dateTime">2025-06-26T01:42:48Z</Appointment:CreatedDate>
    <Appointment:CreatedBy xsi:type="xsd:string"></Appointment:CreatedBy>
    <Appointment:CreatedByFullName xsi:type="xsd:string"></Appointment:CreatedByFullName>
    <Appointment:CreatedByAssociateId xsi:type="xsd:int">0</Appointment:CreatedByAssociateId>
    <Appointment:CautionWarning xsi:type="Appointment:AppointmentCautionWarning">OK</Appointment:CautionWarning>
    <Appointment:OwnedExternally xsi:type="Appointment:AppointmentExternalOwner">None</Appointment:OwnedExternally>
    <Appointment:JoinVideomeetUrl xsi:type="xsd:string"></Appointment:JoinVideomeetUrl>
    <Appointment:PreferredTZLocation xsi:type="xsd:int">0</Appointment:PreferredTZLocation>
    <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
    <Appointment:Agenda xsi:type="xsd:string"></Appointment:Agenda>
    <Appointment:InternalNotes xsi:type="xsd:string"></Appointment:InternalNotes>
   </Appointment:Response>
  </Appointment:UpdateAppointmentWithModeAndEmailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

