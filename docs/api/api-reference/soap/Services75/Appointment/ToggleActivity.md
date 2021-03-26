---
uid: services75-appointment-toggleactivity
title: Services75.AppointmentAgent.ToggleActivity SOAP
Generated: true
---

# Services75 Appointment ToggleActivity SOAP

SOAP request and response examples **Remote/Services75/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IAppointmentAgent.ToggleActivity">SuperOffice.Services75.IAppointmentAgent.ToggleActivity</see> method.

## ToggleActivity

Toggle the completed status for an activity. Activity may be sale, document or appointment. The changes are saved immediately.

* **activityIdentifier:** May contain of a mix of appointment\_id, sale\_id, document\_id and todo\_id

**Returns:** What the result after toggling was.


[WSDL file for Services75/Appointment](../Services75-Appointment.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleActivity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:ToggleActivity>
    <Appointment:ActivityIdentifier xsi:type="xsd:string"></Appointment:ActivityIdentifier>
   </Appointment:ToggleActivity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleActivity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Appointment:ToggleActivityResponse>
   <Appointment:Response xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Response>
  </Appointment:ToggleActivityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

