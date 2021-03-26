---
uid: services81-diagnostics-flushcachesbyname
title: Services81.DiagnosticsAgent.FlushCachesByName SOAP
Generated: true
---

# Services81 Diagnostics FlushCachesByName SOAP

SOAP request and response examples **Remote/Services81/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IDiagnosticsAgent.FlushCachesByName">SuperOffice.Services81.IDiagnosticsAgent.FlushCachesByName</see> method.

## FlushCachesByName

Flushes all NetServer caches named

* **cacheNames:** Name of the cahcnes to flush

**Returns:** This method has no return value


[WSDL file for Services81/Diagnostics](../Services81-Diagnostics.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FlushCachesByName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:FlushCachesByName>
    <Diagnostics:CacheNames xsi:type="NetServerServices812:ArrayOfstring">
     <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
    </Diagnostics:CacheNames>
   </Diagnostics:FlushCachesByName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FlushCachesByName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Diagnostics:FlushCachesByNameResponse>
  </Diagnostics:FlushCachesByNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

