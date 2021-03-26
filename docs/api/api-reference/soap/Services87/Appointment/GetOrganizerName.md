---
uid: services87-appointment-getorganizername
title: Services87.AppointmentAgent.GetOrganizerName SOAP
Generated: true
---

# Services87 Appointment GetOrganizerName SOAP

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.GetOrganizerName">SuperOffice.Services87.IAppointmentAgent.GetOrganizerName</see> method.

## GetOrganizerName

Lookup the name / email of an event-organizer

* **motherAppointmentId:** The id of the mother-appointment.

**Returns:** The displayed name of the organizer: name or email


[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetOrganizerName Request

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
   <Appointment:GetOrganizerName>
    <Appointment:MotherAppointmentId xsi:type="xsd:int">0</Appointment:MotherAppointmentId>
   </Appointment:GetOrganizerName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetOrganizerName Response

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
  <Appointment:GetOrganizerNameResponse>
   <Appointment:Response xsi:type="xsd:string"></Appointment:Response>
  </Appointment:GetOrganizerNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

