---
title: Services84.AppointmentAgent.Delete SOAP
generated: 1
uid: Services84-Appointment-Delete
---

# Services84 Appointment Delete

SOAP request and response examples **Remote/Services84/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAppointmentAgent.Delete">SuperOffice.Services84.IAppointmentAgent.Delete</see> method.

## Delete





[WSDL file for Services84/Appointment](../Services84-Appointment.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Delete Request

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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Appointment:DeleteResponse>
  </Appointment:DeleteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

