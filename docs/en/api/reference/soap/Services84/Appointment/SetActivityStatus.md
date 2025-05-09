---
title: Services84.AppointmentAgent.SetActivityStatus SOAP
generated: 1
uid: Services84-Appointment-SetActivityStatus
---

# Services84 Appointment SetActivityStatus

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.SetActivityStatus">SuperOffice.Services84.IAppointmentAgent.SetActivityStatus</see> method.

## SetActivityStatus

[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetActivityStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:SetActivityStatus>
    <Appointment:ActivityIdentifier xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:SetActivityStatusResponse>
  </Appointment:SetActivityStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
