---
title: Services88.AppointmentAgent.AcceptWithSmtpEmailConfirmation SOAP
generated: 1
uid: Services88-Appointment-AcceptWithSmtpEmailConfirmation
---

# Services88 Appointment AcceptWithSmtpEmailConfirmation

SOAP request and response examples **Remote/Services88/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAppointmentAgent.AcceptWithSmtpEmailConfirmation">SuperOffice.Services88.IAppointmentAgent.AcceptWithSmtpEmailConfirmation</see> method.

## AcceptWithSmtpEmailConfirmation

Accepting an appointment invitation and send an email confirmation to the meeting organizer.

* **appointmentId:** The appointmentId. Both master and child record ids are accepted.
* **updateMode:** Update mode for a recurring appointment.
* **smtpEMailConnectionInfo:** Login information for outgoing smtp email server. Will be null if no login information is relevant.

**Returns:** Updated AppointmentEntity


[WSDL file for Services88/Appointment](../Services88-Appointment.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AcceptWithSmtpEmailConfirmation Request

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
   <Appointment:AcceptWithSmtpEmailConfirmation>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:UpdateMode xsi:type="Appointment:RecurrenceUpdateMode">Unknown</Appointment:UpdateMode>
    <Appointment:SmtpEMailConnectionInfo xsi:type="Appointment:EMailConnectionInfo">
     <Appointment:ServerName xsi:type="xsd:string"></Appointment:ServerName>
     <Appointment:UserName xsi:type="xsd:string"></Appointment:UserName>
     <Appointment:Password xsi:type="xsd:string"></Appointment:Password>
     <Appointment:Folder xsi:type="xsd:string"></Appointment:Folder>
     <Appointment:UseSSL xsi:type="xsd:boolean">false</Appointment:UseSSL>
    </Appointment:SmtpEMailConnectionInfo>
   </Appointment:AcceptWithSmtpEmailConfirmation>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AcceptWithSmtpEmailConfirmation Response

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
  <Appointment:AcceptWithSmtpEmailConfirmationResponse>
  </Appointment:AcceptWithSmtpEmailConfirmationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

