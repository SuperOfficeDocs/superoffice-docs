---
uid: services82-appointment-reject
title: Services82.AppointmentAgent.Reject SOAP
Generated: true
---

# Services82 Appointment Reject SOAP

SOAP request and response examples **Remote/Services82/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IAppointmentAgent.Reject">SuperOffice.Services82.IAppointmentAgent.Reject</see> method.

## Reject

Rejecting an appointment invitation

* **appointmentId:** The appointmentId. Both master and child record ids are accepted.
* **rejectReason:** The reason the invitation was rejected.
* **updateMode:** Update mode for a recurring appointment.

**Returns:** Updated AppointmentEntity


[WSDL file for Services82/Appointment](../Services82-Appointment.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Reject Request

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
   <Appointment:Reject>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
    <Appointment:UpdateMode xsi:type="Appointment:RecurrenceUpdateMode">Unknown</Appointment:UpdateMode>
   </Appointment:Reject>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Reject Response

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
  <Appointment:RejectResponse>
  </Appointment:RejectResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

