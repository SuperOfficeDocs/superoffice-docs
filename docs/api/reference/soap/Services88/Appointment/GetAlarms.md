---
title: Services88.AppointmentAgent.GetAlarms SOAP
generated: 1
uid: Services88-Appointment-GetAlarms
---

# Services88 Appointment GetAlarms

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.GetAlarms">SuperOffice.Services88.IAppointmentAgent.GetAlarms</see> method.

## GetAlarms



* **includeInvitations:** 
* **includeAllAppointments:** 
* **defaultAlarmLeadTimeInMinutes:** 



[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAlarms Request

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
   <Appointment:GetAlarms>
    <Appointment:IncludeInvitations xsi:type="xsd:boolean">false</Appointment:IncludeInvitations>
    <Appointment:IncludeAllAppointments xsi:type="xsd:boolean">false</Appointment:IncludeAllAppointments>
    <Appointment:DefaultAlarmLeadTimeInMinutes xsi:type="xsd:int">0</Appointment:DefaultAlarmLeadTimeInMinutes>
   </Appointment:GetAlarms>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAlarms Response

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
  <Appointment:GetAlarmsResponse>
   <Appointment:Response xsi:type="Appointment:MultiAlarmData">
    <Appointment:Alarms xsi:type="Appointment:ArrayOfAlarmData">
     <Appointment:AlarmData xsi:type="Appointment:AlarmData">
      <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
      <Appointment:StartTime xsi:type="xsd:dateTime">2022-08-26T08:58:20Z</Appointment:StartTime>
      <Appointment:EndDate xsi:type="xsd:dateTime">2022-08-26T08:58:20Z</Appointment:EndDate>
      <Appointment:AlarmTime xsi:type="xsd:dateTime">2022-08-26T08:58:20Z</Appointment:AlarmTime>
      <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
      <Appointment:PersonFullName xsi:type="xsd:string"></Appointment:PersonFullName>
      <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
      <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
      <Appointment:ProjectName xsi:type="xsd:string"></Appointment:ProjectName>
      <Appointment:AppointmentText xsi:type="xsd:string"></Appointment:AppointmentText>
      <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
      <Appointment:SaleName xsi:type="xsd:string"></Appointment:SaleName>
      <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
      <Appointment:AppointmentType xsi:type="Appointment:AppointmentType">Unknown</Appointment:AppointmentType>
      <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
      <Appointment:AssignmentStatus xsi:type="Appointment:AssignmentStatus">Unknown</Appointment:AssignmentStatus>
      <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
      <Appointment:BookingType xsi:type="Appointment:BookingType">Unknown</Appointment:BookingType>
      <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
      <Appointment:TaskName xsi:type="xsd:string"></Appointment:TaskName>
      <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
      <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
      <Appointment:JoinVideomeetUrl xsi:type="xsd:string"></Appointment:JoinVideomeetUrl>
     </Appointment:AlarmData>
    </Appointment:Alarms>
    <Appointment:PollingInterval xsi:type="xsd:int">0</Appointment:PollingInterval>
    <Appointment:SilentAfter xsi:type="xsd:int">0</Appointment:SilentAfter>
   </Appointment:Response>
  </Appointment:GetAlarmsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

