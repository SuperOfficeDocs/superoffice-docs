---
uid: services85-appointment-delete
title: Services85.AppointmentAgent.Delete SOAP
Generated: true
---

# Services85 Appointment Delete SOAP

SOAP request and response examples **Remote/Services85/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IAppointmentAgent.Delete">SuperOffice.Services85.IAppointmentAgent.Delete</see> method.

## Delete

Deleting a booking

* **appointmentId:** The appointmentId. Both master and child record ids are accepted.
* **updateMode:** Update mode for a recurring appointment.
* **sendEmailToParticipants:** If true, emails will be sent to all participants that is marked with send email flag. If false no mails will be sent even if the send email flag is true.
* **smtpEMailConnectionInfo:** Login information for outgoing smtp email server. Will be null if no login information is relevant.
* **imapEMailConnectionInfo:** Login information for imap server. Will be null if no login information is relevant.



[WSDL file for Services85/Appointment](../Services85-Appointment.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Delete Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:Delete>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:UpdateMode xsi:type="Appointment:RecurrenceUpdateMode">Unknown</Appointment:UpdateMode>
    <Appointment:SendEmailToParticipants xsi:type="xsd:boolean">false</Appointment:SendEmailToParticipants>
    <Appointment:SmtpEMailConnectionInfo xsi:type="Appointment:EMailConnectionInfo">
     <Appointment:ServerName xsi:type="xsd:string"></Appointment:ServerName>
     <Appointment:UserName xsi:type="xsd:string"></Appointment:UserName>
     <Appointment:Password xsi:type="xsd:string"></Appointment:Password>
     <Appointment:Folder xsi:type="xsd:string"></Appointment:Folder>
     <Appointment:UseSSL xsi:type="xsd:boolean">false</Appointment:UseSSL>
    </Appointment:SmtpEMailConnectionInfo>
    <Appointment:ImapEMailConnectionInfo xsi:type="Appointment:EMailConnectionInfo">
     <Appointment:ServerName xsi:type="xsd:string"></Appointment:ServerName>
     <Appointment:UserName xsi:type="xsd:string"></Appointment:UserName>
     <Appointment:Password xsi:type="xsd:string"></Appointment:Password>
     <Appointment:Folder xsi:type="xsd:string"></Appointment:Folder>
     <Appointment:UseSSL xsi:type="xsd:boolean">false</Appointment:UseSSL>
    </Appointment:ImapEMailConnectionInfo>
   </Appointment:Delete>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Delete Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Appointment:DeleteResponse>
  </Appointment:DeleteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

