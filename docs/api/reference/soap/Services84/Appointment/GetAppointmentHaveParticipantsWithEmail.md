---
title: Services84.AppointmentAgent.GetAppointmentHaveParticipantsWithEmail SOAP
generated: 1
uid: Services84-Appointment-GetAppointmentHaveParticipantsWithEmail
---

# Services84 Appointment GetAppointmentHaveParticipantsWithEmail

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.GetAppointmentHaveParticipantsWithEmail">SuperOffice.Services84.IAppointmentAgent.GetAppointmentHaveParticipantsWithEmail</see> method.

## GetAppointmentHaveParticipantsWithEmail

GetAppointmentHaveParticipantsWithEmail will check if any of the participants is marked to receive emails on this appointment. If no participants are defined, false will be returned.

* **appointmentId:** The appointmentId.

**Returns:** Return true or false.


[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAppointmentHaveParticipantsWithEmail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:GetAppointmentHaveParticipantsWithEmailResponse>
   <Appointment:Response xsi:type="xsd:boolean">false</Appointment:Response>
  </Appointment:GetAppointmentHaveParticipantsWithEmailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

