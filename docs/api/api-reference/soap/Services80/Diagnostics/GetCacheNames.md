---
uid: services80-diagnostics-getcachenames
title: Services80.DiagnosticsAgent.GetCacheNames SOAP
Generated: true
---

# Services80 Diagnostics GetCacheNames SOAP

SOAP request and response examples **Remote/Services80/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IDiagnosticsAgent.GetCacheNames">SuperOffice.Services80.IDiagnosticsAgent.GetCacheNames</see> method.

## GetCacheNames

Get the name of the caches that can be flushed


**Returns:** Name of the caches that can be flusehd


[WSDL file for Services80/Diagnostics](../Services80-Diagnostics.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCacheNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:GetCacheNames>
   </Diagnostics:GetCacheNames>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCacheNames Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Diagnostics:GetCacheNamesResponse>
   <Diagnostics:Response xsi:type="NetServerServices802:ArrayOfstring">
    <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
   </Diagnostics:Response>
  </Diagnostics:GetCacheNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

