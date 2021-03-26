---
uid: services87-appointment-getuidfromappointmentid
title: Services87.AppointmentAgent.GetUIDFromAppointmentId SOAP
Generated: true
---

# Services87 Appointment GetUIDFromAppointmentId SOAP

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.GetUIDFromAppointmentId">SuperOffice.Services87.IAppointmentAgent.GetUIDFromAppointmentId</see> method.

## GetUIDFromAppointmentId

Get the UID associated with the appointment id in the Invitation table.

* **appointmentId:** 
* **useMotherId:** Uses motherId if no UID is found for appointmentId.

**Returns:** The associated UID, or null if none exist.


[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUIDFromAppointmentId Request

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
   <Appointment:GetUIDFromAppointmentId>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:UseMotherId xsi:type="xsd:boolean">false</Appointment:UseMotherId>
   </Appointment:GetUIDFromAppointmentId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUIDFromAppointmentId Response

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
  <Appointment:GetUIDFromAppointmentIdResponse>
   <Appointment:Response xsi:type="xsd:string"></Appointment:Response>
  </Appointment:GetUIDFromAppointmentIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

