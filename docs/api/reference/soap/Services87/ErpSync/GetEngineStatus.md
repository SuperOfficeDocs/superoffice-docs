---
title: Services87.ErpSyncAgent.GetEngineStatus SOAP
generated: 1
uid: Services87-ErpSync-GetEngineStatus
---

# Services87 ErpSync GetEngineStatus

SOAP request and response examples **Remote/Services87/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IErpSyncAgent.GetEngineStatus">SuperOffice.Services87.IErpSyncAgent.GetEngineStatus</see> method.

## GetEngineStatus

Get the current status of the Sync engine
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.


**Returns:** The current status of the engine


[WSDL file for Services87/ErpSync](../Services87-ErpSync.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEngineStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetEngineStatus>
   </ErpSync:GetEngineStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEngineStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <ErpSync:GetEngineStatusResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncEngineStatus">
    <ErpSync:IsRunning xsi:type="xsd:boolean">false</ErpSync:IsRunning>
    <ErpSync:StatusMessage xsi:type="xsd:string"></ErpSync:StatusMessage>
    <ErpSync:Interval xsi:type="NetServerServices871:duration"></ErpSync:Interval>
   </ErpSync:Response>
  </ErpSync:GetEngineStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

