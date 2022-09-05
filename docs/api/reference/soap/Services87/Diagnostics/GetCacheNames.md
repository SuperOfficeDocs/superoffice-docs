---
title: Services87.DiagnosticsAgent.GetCacheNames SOAP
generated: 1
uid: Services87-Diagnostics-GetCacheNames
---

# Services87 Diagnostics GetCacheNames

SOAP request and response examples **Remote/Services87/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDiagnosticsAgent.GetCacheNames">SuperOffice.Services87.IDiagnosticsAgent.GetCacheNames</see> method.

## GetCacheNames

Get the name of the caches that can be flushed


**Returns:** Name of the caches that can be flusehd


[WSDL file for Services87/Diagnostics](../Services87-Diagnostics.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCacheNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Diagnostics:GetCacheNamesResponse>
   <Diagnostics:Response xsi:type="NetServerServices872:ArrayOfstring">
    <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
   </Diagnostics:Response>
  </Diagnostics:GetCacheNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

