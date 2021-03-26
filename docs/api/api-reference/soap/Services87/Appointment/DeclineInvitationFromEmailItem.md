---
uid: services87-appointment-declineinvitationfromemailitem
title: Services87.AppointmentAgent.DeclineInvitationFromEmailItem SOAP
Generated: true
---

# Services87 Appointment DeclineInvitationFromEmailItem SOAP

SOAP request and response examples **Remote/Services87/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IAppointmentAgent.DeclineInvitationFromEmailItem">SuperOffice.Services87.IAppointmentAgent.DeclineInvitationFromEmailItem</see> method.

## DeclineInvitationFromEmailItem

Declining an appointment invitation where no tentative appointments have been created.

* **emailItemId:** The emailItemId.
* **rejectReason:** The reason the invitation was rejected.



[WSDL file for Services87/Appointment](../Services87-Appointment.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeclineInvitationFromEmailItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:DeclineInvitationFromEmailItem>
    <Appointment:EmailItemId xsi:type="xsd:int">0</Appointment:EmailItemId>
    <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
   </Appointment:DeclineInvitationFromEmailItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeclineInvitationFromEmailItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Appointment:DeclineInvitationFromEmailItemResponse>
  </Appointment:DeclineInvitationFromEmailItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

