---
uid: services80-appointment-toggleactivities
title: Services80.AppointmentAgent.ToggleActivities SOAP
Generated: true
---

# Services80 Appointment ToggleActivities SOAP

SOAP request and response examples **Remote/Services80/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IAppointmentAgent.ToggleActivities">SuperOffice.Services80.IAppointmentAgent.ToggleActivities</see> method.

## ToggleActivities

Toggle the completed status for an array of activities.

* **activityIdentifier:** Contain of a mix of appointment\_id, sale\_id, document\_id and todo\_id.

**Returns:** The resulting ActivityStatus of the first in the array


[WSDL file for Services80/Appointment](../Services80-Appointment.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleActivities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:ToggleActivities>
    <Appointment:ActivityIdentifier xsi:type="NetServerServices802:ArrayOfstring">
     <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
    </Appointment:ActivityIdentifier>
   </Appointment:ToggleActivities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleActivities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Appointment:ToggleActivitiesResponse>
   <Appointment:Response xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Response>
  </Appointment:ToggleActivitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

