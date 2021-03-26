---
uid: services75-sentry-getfunctionrights
title: Services75.SentryAgent.GetFunctionRights SOAP
Generated: true
---

# Services75 Sentry GetFunctionRights SOAP

SOAP request and response examples **Remote/Services75/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services75.ISentryAgent.GetFunctionRights">SuperOffice.Services75.ISentryAgent.GetFunctionRights</see> method.

## GetFunctionRights

Get a string array of all functions rights for the role of the current associate.


**Returns:** String array.


[WSDL file for Services75/Sentry](../Services75-Sentry.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFunctionRights Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Sentry:GetFunctionRightsResponse>
   <Sentry:Response xsi:type="NetServerServices752:ArrayOfstring">
    <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
   </Sentry:Response>
  </Sentry:GetFunctionRightsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

