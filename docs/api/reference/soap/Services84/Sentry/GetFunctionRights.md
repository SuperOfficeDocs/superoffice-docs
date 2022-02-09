---
title: Services84.SentryAgent.GetFunctionRights SOAP
generated: 1
uid: Services84-Sentry-GetFunctionRights
---

# Services84 Sentry GetFunctionRights

SOAP request and response examples **Remote/Services84/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISentryAgent.GetFunctionRights">SuperOffice.Services84.ISentryAgent.GetFunctionRights</see> method.

## GetFunctionRights

Get a string array of all functions rights for the role of the current associate.


**Returns:** String array.


[WSDL file for Services84/Sentry](../Services84-Sentry.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFunctionRights Request

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
   <Sentry:GetFunctionRights>
   </Sentry:GetFunctionRights>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFunctionRights Response

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
  <Sentry:GetFunctionRightsResponse>
   <Sentry:Response xsi:type="NetServerServices842:ArrayOfstring">
    <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
   </Sentry:Response>
  </Sentry:GetFunctionRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

