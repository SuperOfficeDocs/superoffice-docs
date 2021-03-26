---
uid: services81-appointment-toggleandsetactivities
title: Services81.AppointmentAgent.ToggleAndSetActivities SOAP
Generated: true
---

# Services81 Appointment ToggleAndSetActivities SOAP

SOAP request and response examples **Remote/Services81/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IAppointmentAgent.ToggleAndSetActivities">SuperOffice.Services81.IAppointmentAgent.ToggleAndSetActivities</see> method.

## ToggleAndSetActivities

Toggles the first activity and sets the rest of the activities to the result of the first toggle. However, there are some special rules for appointments that trigger a suggested appointment when they are completed. If more than one appointment in the set of identifiers triggers a suggestion, we will not toggle those appointments. This rule is only active when changing the status of an appointment to complete. There must be more than one appointment that triggers such an event for this rule to take effect.

* **activityIdentifiers:** Array of activity ids. ex. appointment\_id=666

**Returns:** The identifiers that were not toggled.


[WSDL file for Services81/Appointment](../Services81-Appointment.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleAndSetActivities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:ToggleAndSetActivities>
    <Appointment:ActivityIdentifiers xsi:type="NetServerServices812:ArrayOfstring">
     <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
    </Appointment:ActivityIdentifiers>
   </Appointment:ToggleAndSetActivities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleAndSetActivities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Appointment:ToggleAndSetActivitiesResponse>
   <Appointment:Response xsi:type="NetServerServices812:ArrayOfstring">
    <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
   </Appointment:Response>
  </Appointment:ToggleAndSetActivitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

