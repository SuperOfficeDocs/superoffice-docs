---
uid: services75-appointment-setactivitystatus
title: Services75.AppointmentAgent.SetActivityStatus SOAP
Generated: true
---

# Services75 Appointment SetActivityStatus SOAP

SOAP request and response examples **Remote/Services75/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IAppointmentAgent.SetActivityStatus">SuperOffice.Services75.IAppointmentAgent.SetActivityStatus</see> method.

## SetActivityStatus

Sets the completed status for an array of activities. The string activityIdentifier param may contain of a mix of appointment\_id, sale\_id, document\_id and todo\_id. The changes are saved immediately. If an invalid id is passed in (nonexistent record), no changes will be made. If there is no write access to the record being changed, a Sentry exception will be thrown in the usual manner.

* **activityIdentifier:** Array of activity ids. ex. appointment\_id=666
* **activityStatus:** The status to set the activities



[WSDL file for Services75/Appointment](../Services75-Appointment.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActivityStatus Request

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
   <Appointment:SetActivityStatus>
    <Appointment:ActivityIdentifier xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Appointment:ActivityIdentifier>
    <Appointment:ActivityStatus xsi:type="Appointment:ActivityStatus">Unknown</Appointment:ActivityStatus>
   </Appointment:SetActivityStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetActivityStatus Response

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
  <Appointment:SetActivityStatusResponse>
  </Appointment:SetActivityStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

