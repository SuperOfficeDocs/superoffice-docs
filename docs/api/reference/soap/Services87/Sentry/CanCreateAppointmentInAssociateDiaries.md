---
title: Services87.SentryAgent.CanCreateAppointmentInAssociateDiaries SOAP
generated: 1
uid: Services87-Sentry-CanCreateAppointmentInAssociateDiaries
---

# Services87 Sentry CanCreateAppointmentInAssociateDiaries

SOAP request and response examples **Remote/Services87/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISentryAgent.CanCreateAppointmentInAssociateDiaries">SuperOffice.Services87.ISentryAgent.CanCreateAppointmentInAssociateDiaries</see> method.

## CanCreateAppointmentInAssociateDiaries

CanCreateAppointmentInAssociateDiaries will check if the current associate can create appointments in diaries belonging to the associates listed in associateIds. CanCreateAppointmentInAssociateDiaries will only check against associates that are diary owners. If none of the associates listed in the associateIds parameter is a diary owner, the method will return true.

* **associateIds:** Array of associate ids to check.

**Returns:** Returns true if the current associate can create appointments in the diary of all the other associates, otherwise false.


[WSDL file for Services87/Sentry](../Services87-Sentry.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CanCreateAppointmentInAssociateDiaries Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:CanCreateAppointmentInAssociateDiaries>
    <Sentry:AssociateIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Sentry:AssociateIds>
   </Sentry:CanCreateAppointmentInAssociateDiaries>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CanCreateAppointmentInAssociateDiaries Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Sentry:CanCreateAppointmentInAssociateDiariesResponse>
   <Sentry:Response xsi:type="xsd:boolean">false</Sentry:Response>
  </Sentry:CanCreateAppointmentInAssociateDiariesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

