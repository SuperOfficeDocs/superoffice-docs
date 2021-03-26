---
uid: services75-erpsync-changeenginestatus
title: Services75.ErpSyncAgent.ChangeEngineStatus SOAP
Generated: true
---

# Services75 ErpSync ChangeEngineStatus SOAP

SOAP request and response examples **Remote/Services75/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IErpSyncAgent.ChangeEngineStatus">SuperOffice.Services75.IErpSyncAgent.ChangeEngineStatus</see> method.

## ChangeEngineStatus

Change the current running/stopped status of the Sync engine

* **run:** If true, then start the engine; otherwise stop it (requests to the Batch system, may not be immediately reflected)

**Returns:** The current status of the engine


[WSDL file for Services75/ErpSync](../Services75-ErpSync.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChangeEngineStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services75">
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <ErpSync:ChangeEngineStatusResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncEngineStatus">
    <ErpSync:IsRunning xsi:type="xsd:boolean">false</ErpSync:IsRunning>
    <ErpSync:StatusMessage xsi:type="xsd:string"></ErpSync:StatusMessage>
    <ErpSync:Interval xsi:type="NetServerServices751:duration"></ErpSync:Interval>
   </ErpSync:Response>
  </ErpSync:ChangeEngineStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

