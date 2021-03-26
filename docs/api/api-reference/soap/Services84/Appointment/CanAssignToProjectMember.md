---
uid: services84-appointment-canassigntoprojectmember
title: Services84.AppointmentAgent.CanAssignToProjectMember SOAP
Generated: true
---

# Services84 Appointment CanAssignToProjectMember SOAP

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.CanAssignToProjectMember">SuperOffice.Services84.IAppointmentAgent.CanAssignToProjectMember</see> method.

## CanAssignToProjectMember



* **projectId:** 
* **suggestedAppointmentId:** 



[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CanAssignToProjectMember Request

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
   <Appointment:CanAssignToProjectMember>
    <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
   </Appointment:CanAssignToProjectMember>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CanAssignToProjectMember Response

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
  <Appointment:CanAssignToProjectMemberResponse>
   <Appointment:Response xsi:type="xsd:boolean">false</Appointment:Response>
  </Appointment:CanAssignToProjectMemberResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

