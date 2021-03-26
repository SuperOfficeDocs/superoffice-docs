---
uid: services85-sentry-getnewtableright
title: Services85.SentryAgent.GetNewTableRight SOAP
Generated: true
---

# Services85 Sentry GetNewTableRight SOAP

SOAP request and response examples **Remote/Services85/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISentryAgent.GetNewTableRight">SuperOffice.Services85.ISentryAgent.GetNewTableRight</see> method.

## GetNewTableRight

Returns a TableRight for a new row based on tableName parameter.

* **tableName:** Name of the table to get the TableRights from

**Returns:** The TableRight


[WSDL file for Services85/Sentry](../Services85-Sentry.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNewTableRight Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:GetNewTableRight>
    <Sentry:TableName xsi:type="xsd:string"></Sentry:TableName>
   </Sentry:GetNewTableRight>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNewTableRight Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Sentry:GetNewTableRightResponse>
   <Sentry:Response xsi:type="Sentry:TableRight">
    <Sentry:Mask xsi:type="Sentry:ETableRight">Select</Sentry:Mask>
    <Sentry:Reason xsi:type="xsd:string"></Sentry:Reason>
   </Sentry:Response>
  </Sentry:GetNewTableRightResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

