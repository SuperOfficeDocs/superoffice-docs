---
uid: services80-appointment-canassigntoprojectmember
title: Services80.AppointmentAgent.CanAssignToProjectMember SOAP
Generated: true
---

# Services80 Appointment CanAssignToProjectMember SOAP

SOAP request and response examples **Remote/Services80/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IAppointmentAgent.CanAssignToProjectMember">SuperOffice.Services80.IAppointmentAgent.CanAssignToProjectMember</see> method.

## CanAssignToProjectMember



* **projectId:** 
* **suggestedAppointmentId:** 



[WSDL file for Services80/Appointment](../Services80-Appointment.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CanAssignToProjectMember Request

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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Appointment:CanAssignToProjectMemberResponse>
   <Appointment:Response xsi:type="xsd:boolean">false</Appointment:Response>
  </Appointment:CanAssignToProjectMemberResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

