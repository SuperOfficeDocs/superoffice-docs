---
uid: services86-erpsync-geterpsyncconnectionsummary
title: Services86.ErpSyncAgent.GetErpSyncConnectionSummary SOAP
Generated: true
---

# Services86 ErpSync GetErpSyncConnectionSummary SOAP

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.GetErpSyncConnectionSummary">SuperOffice.Services86.IErpSyncAgent.GetErpSyncConnectionSummary</see> method.

## GetErpSyncConnectionSummary

Get a summary of the current ErpSync configuration/setup
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpSyncConnectionId:** The ID of the ErpSync connection for which information is sought

**Returns:** Summary of connection information, and one summary element per configured actor type


[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetErpSyncConnectionSummary Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetErpSyncConnectionSummary>
    <ErpSync:ErpSyncConnectionId xsi:type="xsd:int">0</ErpSync:ErpSyncConnectionId>
   </ErpSync:GetErpSyncConnectionSummary>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetErpSyncConnectionSummary Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ErpSync:GetErpSyncConnectionSummaryResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncConnectionSummary">
    <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
    <ErpSync:DisplayDescription xsi:type="xsd:string"></ErpSync:DisplayDescription>
    <ErpSync:Active xsi:type="xsd:boolean">false</ErpSync:Active>
    <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
    <ErpSync:LastSync xsi:type="xsd:dateTime">2021-03-25T21:36:09Z</ErpSync:LastSync>
    <ErpSync:Actors xsi:type="ErpSync:ArrayOfErpSyncActorSummary">
     <ErpSync:ErpSyncActorSummary xsi:type="ErpSync:ErpSyncActorSummary">
      <ErpSync:ActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ActorType>
      <ErpSync:HasMappings xsi:type="xsd:boolean">false</ErpSync:HasMappings>
      <ErpSync:Defaults xsi:type="xsd:string"></ErpSync:Defaults>
      <ErpSync:Mappings xsi:type="xsd:string"></ErpSync:Mappings>
     </ErpSync:ErpSyncActorSummary>
    </ErpSync:Actors>
   </ErpSync:Response>
  </ErpSync:GetErpSyncConnectionSummaryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

