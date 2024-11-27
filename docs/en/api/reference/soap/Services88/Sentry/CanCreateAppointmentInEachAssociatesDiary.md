---
title: Services88.SentryAgent.CanCreateAppointmentInEachAssociatesDiary SOAP
generated: true
uid: Services88-Sentry-CanCreateAppointmentInEachAssociatesDiary
---

# Services88 Sentry CanCreateAppointmentInEachAssociatesDiary

SOAP request and response examples **Remote/Services88/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISentryAgent.CanCreateAppointmentInEachAssociatesDiary">SuperOffice.Services88.ISentryAgent.CanCreateAppointmentInEachAssociatesDiary</see> method.

## CanCreateAppointmentInEachAssociatesDiary





[WSDL file for Services88/Sentry](../Services88-Sentry.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CanCreateAppointmentInEachAssociatesDiary Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:CanCreateAppointmentInEachAssociatesDiary>
    <Sentry:AssociateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Sentry:AssociateIds>
   </Sentry:CanCreateAppointmentInEachAssociatesDiary>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CanCreateAppointmentInEachAssociatesDiary Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Sentry:CanCreateAppointmentInEachAssociatesDiaryResponse>
   <Sentry:Response xsi:type="NetServerServices882:ArrayOfboolean">
    <NetServerServices882:boolean xsi:type="xsd:boolean">false</NetServerServices882:boolean>
   </Sentry:Response>
  </Sentry:CanCreateAppointmentInEachAssociatesDiaryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

