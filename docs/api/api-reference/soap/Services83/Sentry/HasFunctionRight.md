---
uid: services83-sentry-hasfunctionright
title: Services83.SentryAgent.HasFunctionRight SOAP
Generated: true
---

# Services83 Sentry HasFunctionRight SOAP

SOAP request and response examples **Remote/Services83/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services83.ISentryAgent.HasFunctionRight">SuperOffice.Services83.ISentryAgent.HasFunctionRight</see> method.

## HasFunctionRight

Get a boolean value indicating if the current user has the functional right.

* **functionRight:** Function right to check.



[WSDL file for Services83/Sentry](../Services83-Sentry.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasFunctionRight Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:HasFunctionRight>
    <Sentry:FunctionRight xsi:type="xsd:string"></Sentry:FunctionRight>
   </Sentry:HasFunctionRight>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasFunctionRight Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Sentry:HasFunctionRightResponse>
   <Sentry:Response xsi:type="xsd:boolean">false</Sentry:Response>
  </Sentry:HasFunctionRightResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

