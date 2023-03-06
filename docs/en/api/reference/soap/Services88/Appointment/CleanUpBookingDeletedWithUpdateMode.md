---
title: Services88.AppointmentAgent.CleanUpBookingDeletedWithUpdateMode SOAP
generated: 1
uid: Services88-Appointment-CleanUpBookingDeletedWithUpdateMode
---

# Services88 Appointment CleanUpBookingDeletedWithUpdateMode

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.CleanUpBookingDeletedWithUpdateMode">SuperOffice.Services88.IAppointmentAgent.CleanUpBookingDeletedWithUpdateMode</see> method.

## CleanUpBookingDeletedWithUpdateMode





[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CleanUpBookingDeletedWithUpdateMode Request

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
   <Appointment:CleanUpBookingDeletedWithUpdateMode>
    <Appointment:AppointmentIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Appointment:AppointmentIds>
    <Appointment:UpdateMode xsi:type="Appointment:RecurrenceUpdateMode">Unknown</Appointment:UpdateMode>
   </Appointment:CleanUpBookingDeletedWithUpdateMode>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CleanUpBookingDeletedWithUpdateMode Response

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
  <Appointment:CleanUpBookingDeletedWithUpdateModeResponse>
   <Appointment:Response xsi:type="xsd:int">0</Appointment:Response>
  </Appointment:CleanUpBookingDeletedWithUpdateModeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

