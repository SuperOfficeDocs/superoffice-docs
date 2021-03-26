---
uid: services75-diagnostics-flushcaches
title: Services75.DiagnosticsAgent.FlushCaches SOAP
Generated: true
---

# Services75 Diagnostics FlushCaches SOAP

SOAP request and response examples **Remote/Services75/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IDiagnosticsAgent.FlushCaches">SuperOffice.Services75.IDiagnosticsAgent.FlushCaches</see> method.

## FlushCaches

Flushes all NetServer caches




[WSDL file for Services75/Diagnostics](../Services75-Diagnostics.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FlushCaches Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:FlushCaches>
   </Diagnostics:FlushCaches>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FlushCaches Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Diagnostics:FlushCachesResponse>
  </Diagnostics:FlushCachesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

