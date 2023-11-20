---
title: Services88.AppointmentAgent.GetNextAvailableTime SOAP
generated: true
uid: Services88-Appointment-GetNextAvailableTime
---

# Services88 Appointment GetNextAvailableTime

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.GetNextAvailableTime">SuperOffice.Services88.IAppointmentAgent.GetNextAvailableTime</see> method.

## GetNextAvailableTime





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextAvailableTime Request

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
   <Appointment:GetNextAvailableTime>
    <Appointment:Associates xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Appointment:Associates>
    <Appointment:StartTime xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:StartTime>
    <Appointment:EndTime xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:EndTime>
    <Appointment:Count xsi:type="xsd:int">0</Appointment:Count>
    <Appointment:IsAllDay xsi:type="xsd:boolean">false</Appointment:IsAllDay>
   </Appointment:GetNextAvailableTime>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextAvailableTime Response

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
  <Appointment:GetNextAvailableTimeResponse>
   <Appointment:Response xsi:type="Appointment:ArrayOfNextAvailableTime">
    <Appointment:NextAvailableTime xsi:type="Appointment:NextAvailableTime">
     <Appointment:AvailableTimeStart xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:AvailableTimeStart>
     <Appointment:AvailableTimeEnd xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:AvailableTimeEnd>
     <Appointment:RecommendedTimeStart xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:RecommendedTimeStart>
     <Appointment:RecommendedTimeEnd xsi:type="xsd:dateTime">2023-11-10T12:35:40Z</Appointment:RecommendedTimeEnd>
    </Appointment:NextAvailableTime>
   </Appointment:Response>
  </Appointment:GetNextAvailableTimeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

