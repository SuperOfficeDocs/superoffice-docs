---
uid: services83-erpsync-supportsadvancedsearch
title: Services83.ErpSyncAgent.SupportsAdvancedSearch SOAP
Generated: true
---

# Services83 ErpSync SupportsAdvancedSearch SOAP

SOAP request and response examples **Remote/Services83/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IErpSyncAgent.SupportsAdvancedSearch">SuperOffice.Services83.IErpSyncAgent.SupportsAdvancedSearch</see> method.

## SupportsAdvancedSearch

Indicates if the connection supports advanced search for the given erp actor

* **erpConnectionId:** Ths id of the connection
* **erpActorType:** The erp actor type to check for

**Returns:** True if advanced search is supported


[WSDL file for Services83/ErpSync](../Services83-ErpSync.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SupportsAdvancedSearch Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:SupportsAdvancedSearch>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
   </ErpSync:SupportsAdvancedSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SupportsAdvancedSearch Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <ErpSync:SupportsAdvancedSearchResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:SupportsAdvancedSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

