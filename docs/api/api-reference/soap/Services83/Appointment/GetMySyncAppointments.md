---
uid: services83-appointment-getmysyncappointments
title: Services83.AppointmentAgent.GetMySyncAppointments SOAP
Generated: true
---

# Services83 Appointment GetMySyncAppointments SOAP

SOAP request and response examples **Remote/Services83/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IAppointmentAgent.GetMySyncAppointments">SuperOffice.Services83.IAppointmentAgent.GetMySyncAppointments</see> method.

## GetMySyncAppointments

Method that returns a specified number of appointments within a time range. The appointments belong to the currently logged on user.

* **startTime:** The start of the time interval in which we want appointments. This will usually be the current time.
* **endTime:** The end of the time interval.

**Returns:** Array of Appointments.


[WSDL file for Services83/Appointment](../Services83-Appointment.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMySyncAppointments Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetMySyncAppointments>
    <Appointment:StartTime xsi:type="xsd:dateTime">2021-03-25T21:34:58Z</Appointment:StartTime>
    <Appointment:EndTime xsi:type="xsd:dateTime">2021-03-25T21:34:58Z</Appointment:EndTime>
   </Appointment:GetMySyncAppointments>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMySyncAppointments Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Appointment:GetMySyncAppointmentsResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfAppointmentSyncData">
    <Appointment:AppointmentSyncData xsi:type="Appointment:AppointmentSyncData">
     <Appointment:AlarmTime xsi:type="xsd:dateTime">2021-03-25T21:34:58Z</Appointment:AlarmTime>
     <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
     <Appointment:AppointmentText xsi:type="xsd:string"></Appointment:AppointmentText>
     <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
     <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:34:58Z</Appointment:EndDate>
     <Appointment:HasAlarm xsi:type="xsd:boolean">false</Appointment:HasAlarm>
     <Appointment:IsAllDay xsi:type="xsd:boolean">false</Appointment:IsAllDay>
     <Appointment:IsAssignment xsi:type="xsd:boolean">false</Appointment:IsAssignment>
     <Appointment:IsBusy xsi:type="xsd:boolean">false</Appointment:IsBusy>
     <Appointment:IsCompleted xsi:type="xsd:boolean">false</Appointment:IsCompleted>
     <Appointment:IsInvitation xsi:type="xsd:boolean">false</Appointment:IsInvitation>
     <Appointment:IsTentative xsi:type="xsd:boolean">false</Appointment:IsTentative>
     <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
     <Appointment:Participants xsi:type="Appointment:ArrayOfParticipantSyncData">
      <Appointment:ParticipantSyncData xsi:type="Appointment:ParticipantSyncData">
       <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
       <Appointment:PersonFirstName xsi:type="xsd:string"></Appointment:PersonFirstName>
       <Appointment:PersonMiddleName xsi:type="xsd:string"></Appointment:PersonMiddleName>
       <Appointment:PersonLastname xsi:type="xsd:string"></Appointment:PersonLastname>
       <Appointment:PersonMrmrs xsi:type="xsd:string"></Appointment:PersonMrmrs>
       <Appointment:PersonTitle xsi:type="xsd:string"></Appointment:PersonTitle>
       <Appointment:PersonPosition xsi:type="xsd:string"></Appointment:PersonPosition>
       <Appointment:PersonAcademicTitle xsi:type="xsd:string"></Appointment:PersonAcademicTitle>
       <Appointment:PersonFormalName xsi:type="xsd:string"></Appointment:PersonFormalName>
       <Appointment:PersonFullName xsi:type="xsd:string"></Appointment:PersonFullName>
       <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
       <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
       <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
       <Appointment:ContactBusiness xsi:type="xsd:string"></Appointment:ContactBusiness>
       <Appointment:ContactCountry xsi:type="xsd:string"></Appointment:ContactCountry>
       <Appointment:ContactCategory xsi:type="xsd:string"></Appointment:ContactCategory>
       <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
       <Appointment:EMail xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:EMail>
       <Appointment:PhonePrivate xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:PhonePrivate>
       <Appointment:PhoneFax xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:PhoneFax>
       <Appointment:PhoneMobile xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:PhoneMobile>
       <Appointment:PhoneDirect xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:PhoneDirect>
       <Appointment:PhoneContact xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:PhoneContact>
       <Appointment:Messenger xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:Messenger>
       <Appointment:Voip xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:Voip>
       <Appointment:ContactUrl xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:ContactUrl>
       <Appointment:Url xsi:type="NetServerServices832:ArrayOfstring">
        <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
       </Appointment:Url>
       <Appointment:StreetAddress xsi:type="Appointment:AddressSyncData">
        <Appointment:AddressId xsi:type="xsd:int">0</Appointment:AddressId>
        <Appointment:AddressType xsi:type="Appointment:AddressType">Unknown</Appointment:AddressType>
        <Appointment:Address1 xsi:type="xsd:string"></Appointment:Address1>
        <Appointment:Address2 xsi:type="xsd:string"></Appointment:Address2>
        <Appointment:Address3 xsi:type="xsd:string"></Appointment:Address3>
        <Appointment:City xsi:type="xsd:string"></Appointment:City>
        <Appointment:County xsi:type="xsd:string"></Appointment:County>
        <Appointment:ZipCode xsi:type="xsd:string"></Appointment:ZipCode>
        <Appointment:State xsi:type="xsd:string"></Appointment:State>
        <Appointment:Latitude xsi:type="xsd:double">0.0</Appointment:Latitude>
        <Appointment:Longitude xsi:type="xsd:double">0.0</Appointment:Longitude>
        <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
       </Appointment:StreetAddress>
       <Appointment:PostalAddress xsi:type="Appointment:AddressSyncData">
        <Appointment:AddressId xsi:type="xsd:int">0</Appointment:AddressId>
        <Appointment:AddressType xsi:type="Appointment:AddressType">Unknown</Appointment:AddressType>
        <Appointment:Address1 xsi:type="xsd:string"></Appointment:Address1>
        <Appointment:Address2 xsi:type="xsd:string"></Appointment:Address2>
        <Appointment:Address3 xsi:type="xsd:string"></Appointment:Address3>
        <Appointment:City xsi:type="xsd:string"></Appointment:City>
        <Appointment:County xsi:type="xsd:string"></Appointment:County>
        <Appointment:ZipCode xsi:type="xsd:string"></Appointment:ZipCode>
        <Appointment:State xsi:type="xsd:string"></Appointment:State>
        <Appointment:Latitude xsi:type="xsd:double">0.0</Appointment:Latitude>
        <Appointment:Longitude xsi:type="xsd:double">0.0</Appointment:Longitude>
        <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
       </Appointment:PostalAddress>
       <Appointment:Country xsi:type="xsd:string"></Appointment:Country>
       <Appointment:PersonAddress xsi:type="Appointment:AddressSyncData">
        <Appointment:AddressId xsi:type="xsd:int">0</Appointment:AddressId>
        <Appointment:AddressType xsi:type="Appointment:AddressType">Unknown</Appointment:AddressType>
        <Appointment:Address1 xsi:type="xsd:string"></Appointment:Address1>
        <Appointment:Address2 xsi:type="xsd:string"></Appointment:Address2>
        <Appointment:Address3 xsi:type="xsd:string"></Appointment:Address3>
        <Appointment:City xsi:type="xsd:string"></Appointment:City>
        <Appointment:County xsi:type="xsd:string"></Appointment:County>
        <Appointment:ZipCode xsi:type="xsd:string"></Appointment:ZipCode>
        <Appointment:State xsi:type="xsd:string"></Appointment:State>
        <Appointment:Latitude xsi:type="xsd:double">0.0</Appointment:Latitude>
        <Appointment:Longitude xsi:type="xsd:double">0.0</Appointment:Longitude>
        <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
       </Appointment:PersonAddress>
       <Appointment:PersonCountry xsi:type="xsd:string"></Appointment:PersonCountry>
       <Appointment:ParticipantStatus xsi:type="Appointment:AppointmentStatus">UnknownOrPostIt</Appointment:ParticipantStatus>
      </Appointment:ParticipantSyncData>
     </Appointment:Participants>
     <Appointment:PersonFormalName xsi:type="xsd:string"></Appointment:PersonFormalName>
     <Appointment:PersonFullName xsi:type="xsd:string"></Appointment:PersonFullName>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
     <Appointment:ProjectName xsi:type="xsd:string"></Appointment:ProjectName>
     <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
     <Appointment:SaleName xsi:type="xsd:string"></Appointment:SaleName>
     <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:34:58Z</Appointment:StartDate>
     <Appointment:TaskName xsi:type="xsd:string"></Appointment:TaskName>
    </Appointment:AppointmentSyncData>
   </Appointment:Response>
  </Appointment:GetMySyncAppointmentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

