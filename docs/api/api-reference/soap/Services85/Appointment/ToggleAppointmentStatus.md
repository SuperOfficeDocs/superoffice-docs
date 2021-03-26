---
uid: services85-appointment-toggleappointmentstatus
title: Services85.AppointmentAgent.ToggleAppointmentStatus SOAP
Generated: true
---

# Services85 Appointment ToggleAppointmentStatus SOAP

SOAP request and response examples **Remote/Services85/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAppointmentAgent.ToggleAppointmentStatus">SuperOffice.Services85.IAppointmentAgent.ToggleAppointmentStatus</see> method.

## ToggleAppointmentStatus

Sets an appointment's status to Completed if the appointment had a different status, or sets the status to started if already set to completed.

* **appointmentId:** The appointment id.

**Returns:** The new AppointmentStatus


[WSDL file for Services85/Appointment](../Services85-Appointment.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleAppointmentStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:ToggleAppointmentStatus>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
   </Appointment:ToggleAppointmentStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleAppointmentStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Appointment:ToggleAppointmentStatusResponse>
   <Appointment:Response xsi:type="Appointment:AppointmentStatus">UnknownOrPostIt</Appointment:Response>
  </Appointment:ToggleAppointmentStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

