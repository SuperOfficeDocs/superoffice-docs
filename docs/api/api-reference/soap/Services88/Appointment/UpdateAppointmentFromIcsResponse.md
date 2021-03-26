---
uid: services88-appointment-updateappointmentfromicsresponse
title: Services88.AppointmentAgent.UpdateAppointmentFromIcsResponse SOAP
Generated: true
---

# Services88 Appointment UpdateAppointmentFromIcsResponse SOAP

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.UpdateAppointmentFromIcsResponse">SuperOffice.Services88.IAppointmentAgent.UpdateAppointmentFromIcsResponse</see> method.

## UpdateAppointmentFromIcsResponse

Update the attendance to an appointment based on incoming ICS RSVPs.

* **emailAddress:** The email-address of the person responding to our meeting-request.
* **icsData:** The iCal ICS RSVP-content in byte-form.

**Returns:** True if successfull.


[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateAppointmentFromIcsResponse Request

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
   <Appointment:UpdateAppointmentFromIcsResponse>
    <Appointment:EmailAddress xsi:type="xsd:string"></Appointment:EmailAddress>
    <Appointment:IcsData xsi:type="xsd:base64Binary"></Appointment:IcsData>
   </Appointment:UpdateAppointmentFromIcsResponse>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateAppointmentFromIcsResponse Response

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
  <Appointment:UpdateAppointmentFromIcsResponseResponse>
   <Appointment:Response xsi:type="xsd:boolean">false</Appointment:Response>
  </Appointment:UpdateAppointmentFromIcsResponseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

