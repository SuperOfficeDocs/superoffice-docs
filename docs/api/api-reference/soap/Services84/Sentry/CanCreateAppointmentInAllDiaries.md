---
uid: services84-sentry-cancreateappointmentinalldiaries
title: Services84.SentryAgent.CanCreateAppointmentInAllDiaries SOAP
Generated: true
---

# Services84 Sentry CanCreateAppointmentInAllDiaries SOAP

SOAP request and response examples **Remote/Services84/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISentryAgent.CanCreateAppointmentInAllDiaries">SuperOffice.Services84.ISentryAgent.CanCreateAppointmentInAllDiaries</see> method.

## CanCreateAppointmentInAllDiaries

CanCreateAppointmentInAllDiaries will check if the current associate can create appointments in diaries belonging all other associates. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners.


**Returns:** Returns true if the current associate can create appointments in the diary of all the other associates, otherwise false.


[WSDL file for Services84/Sentry](../Services84-Sentry.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CanCreateAppointmentInAllDiaries Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:CanCreateAppointmentInAllDiaries>
   </Sentry:CanCreateAppointmentInAllDiaries>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CanCreateAppointmentInAllDiaries Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Sentry:CanCreateAppointmentInAllDiariesResponse>
   <Sentry:Response xsi:type="xsd:boolean">false</Sentry:Response>
  </Sentry:CanCreateAppointmentInAllDiariesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

