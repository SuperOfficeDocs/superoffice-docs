---
title: Services88.DiagnosticsAgent.GetCacheInvalidationGenerations SOAP
generated: true
uid: Services88-Diagnostics-GetCacheInvalidationGenerations
content_type: reference
---

# Services88 Diagnostics GetCacheInvalidationGenerations

SOAP request and response examples **Remote/Services88/Diagnostics.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDiagnosticsAgent.GetCacheInvalidationGenerations">SuperOffice.Services88.IDiagnosticsAgent.GetCacheInvalidationGenerations</see> method.

## GetCacheInvalidationGenerations





[WSDL file for Services88/Diagnostics](../Services88-Diagnostics.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCacheInvalidationGenerations Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Diagnostics:ApplicationToken>1234567-1234-9876</Diagnostics:ApplicationToken>
  <Diagnostics:Credentials>
    <Diagnostics:Ticket>7T:1234abcxyzExample==</Diagnostics:Ticket>
  </Diagnostics:Credentials>
 <SOAP-ENV:Body>
   <Diagnostics:GetCacheInvalidationGenerations>
    <Diagnostics:Names xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Diagnostics:Names>
   </Diagnostics:GetCacheInvalidationGenerations>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCacheInvalidationGenerations Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Diagnostics="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Diagnostics:GetCacheInvalidationGenerationsResponse>
   <Diagnostics:Response xsi:type="Diagnostics:ArrayOfCacheInvalidation">
    <Diagnostics:CacheInvalidation xsi:type="Diagnostics:CacheInvalidation">
     <Diagnostics:Name xsi:type="xsd:string"></Diagnostics:Name>
     <Diagnostics:Generation xsi:type="xsd:int">0</Diagnostics:Generation>
    </Diagnostics:CacheInvalidation>
   </Diagnostics:Response>
  </Diagnostics:GetCacheInvalidationGenerationsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

