---
title: Services88.AppointmentAgent.GetAssociatesDiaryInfo SOAP
generated: true
uid: Services88-Appointment-GetAssociatesDiaryInfo
---

# Services88 Appointment GetAssociatesDiaryInfo

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.GetAssociatesDiaryInfo">SuperOffice.Services88.IAppointmentAgent.GetAssociatesDiaryInfo</see> method.

## GetAssociatesDiaryInfo





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAssociatesDiaryInfo Request

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
   <Appointment:GetAssociatesDiaryInfo>
    <Appointment:AssociateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Appointment:AssociateIds>
    <Appointment:StartTime xsi:type="xsd:dateTime">2024-10-09T01:42:13Z</Appointment:StartTime>
    <Appointment:EndTime xsi:type="xsd:dateTime">2024-10-09T01:42:13Z</Appointment:EndTime>
   </Appointment:GetAssociatesDiaryInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAssociatesDiaryInfo Response

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
  <Appointment:GetAssociatesDiaryInfoResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfAppointmentInfo">
    <Appointment:AppointmentInfo xsi:type="Appointment:AppointmentInfo">
     <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:MotherId xsi:type="xsd:int">0</Appointment:MotherId>
     <Appointment:StartDate xsi:type="xsd:dateTime">2024-10-09T01:42:13Z</Appointment:StartDate>
     <Appointment:EndDate xsi:type="xsd:dateTime">2024-10-09T01:42:13Z</Appointment:EndDate>
     <Appointment:ColorIndex xsi:type="Appointment:ColorIndex">LightBlue</Appointment:ColorIndex>
     <Appointment:TaskName xsi:type="xsd:string"></Appointment:TaskName>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Agenda xsi:type="xsd:string"></Appointment:Agenda>
     <Appointment:IsAllDay xsi:type="xsd:boolean">false</Appointment:IsAllDay>
     <Appointment:IsBusy xsi:type="xsd:boolean">false</Appointment:IsBusy>
     <Appointment:IsRecurring xsi:type="xsd:boolean">false</Appointment:IsRecurring>
     <Appointment:IsVideoMeeting xsi:type="xsd:boolean">false</Appointment:IsVideoMeeting>
    </Appointment:AppointmentInfo>
   </Appointment:Response>
  </Appointment:GetAssociatesDiaryInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

