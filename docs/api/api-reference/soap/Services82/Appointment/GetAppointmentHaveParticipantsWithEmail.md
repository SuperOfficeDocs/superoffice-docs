---
uid: services82-appointment-getappointmenthaveparticipantswithemail
title: Services82.AppointmentAgent.GetAppointmentHaveParticipantsWithEmail SOAP
Generated: true
---

# Services82 Appointment GetAppointmentHaveParticipantsWithEmail SOAP

SOAP request and response examples **Remote/Services82/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAppointmentAgent.GetAppointmentHaveParticipantsWithEmail">SuperOffice.Services82.IAppointmentAgent.GetAppointmentHaveParticipantsWithEmail</see> method.

## GetAppointmentHaveParticipantsWithEmail

GetAppointmentHaveParticipantsWithEmail will check if any of the participants is marked to receive emails on this appointment. If no participants are defined, false will be returned.

* **appointmentId:** The appointmentId.

**Returns:** Return true or false.


[WSDL file for Services82/Appointment](../Services82-Appointment.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAppointmentHaveParticipantsWithEmail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:GetAppointmentHaveParticipantsWithEmail>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
   </Appointment:GetAppointmentHaveParticipantsWithEmail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAppointmentHaveParticipantsWithEmail Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Appointment:GetAppointmentHaveParticipantsWithEmailResponse>
   <Appointment:Response xsi:type="xsd:boolean">false</Appointment:Response>
  </Appointment:GetAppointmentHaveParticipantsWithEmailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

