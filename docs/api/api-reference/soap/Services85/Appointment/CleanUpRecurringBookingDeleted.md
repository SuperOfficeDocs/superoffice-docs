---
uid: services85-appointment-cleanuprecurringbookingdeleted
title: Services85.AppointmentAgent.CleanUpRecurringBookingDeleted SOAP
Generated: true
---

# Services85 Appointment CleanUpRecurringBookingDeleted SOAP

SOAP request and response examples **Remote/Services85/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAppointmentAgent.CleanUpRecurringBookingDeleted">SuperOffice.Services85.IAppointmentAgent.CleanUpRecurringBookingDeleted</see> method.

## CleanUpRecurringBookingDeleted

Deletes all appointments with status BookingDeleted and for in logged user.




[WSDL file for Services85/Appointment](../Services85-Appointment.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CleanUpRecurringBookingDeleted Request

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
   <Appointment:CleanUpRecurringBookingDeleted>
   </Appointment:CleanUpRecurringBookingDeleted>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CleanUpRecurringBookingDeleted Response

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
  <Appointment:CleanUpRecurringBookingDeletedResponse>
   <Appointment:Response xsi:type="xsd:int">0</Appointment:Response>
  </Appointment:CleanUpRecurringBookingDeletedResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

