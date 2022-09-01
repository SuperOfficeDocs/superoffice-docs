---
title: Services84.ErpSyncAgent.ChangeEngineStatus SOAP
generated: 1
uid: Services84-ErpSync-ChangeEngineStatus
---

# Services84 ErpSync ChangeEngineStatus

SOAP request and response examples **Remote/Services84/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IErpSyncAgent.ChangeEngineStatus">SuperOffice.Services84.IErpSyncAgent.ChangeEngineStatus</see> method.

## ChangeEngineStatus

Change the current running/stopped status of the Sync engine

* **run:** If true, then start the engine; otherwise stop it (requests to the Batch system, may not be immediately reflected)

**Returns:** The current status of the engine


[WSDL file for Services84/ErpSync](../Services84-ErpSync.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeEngineStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:ChangeEngineStatus>
    <ErpSync:Run xsi:type="xsd:boolean">false</ErpSync:Run>
   </ErpSync:ChangeEngineStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChangeEngineStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <ErpSync:ChangeEngineStatusResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncEngineStatus">
    <ErpSync:IsRunning xsi:type="xsd:boolean">false</ErpSync:IsRunning>
    <ErpSync:StatusMessage xsi:type="xsd:string"></ErpSync:StatusMessage>
    <ErpSync:Interval xsi:type="NetServerServices841:duration"></ErpSync:Interval>
   </ErpSync:Response>
  </ErpSync:ChangeEngineStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

