---
uid: services84-erpsync-saveerpconnectionsyncpriorities
title: Services84.ErpSyncAgent.SaveErpConnectionSyncPriorities SOAP
Generated: true
---

# Services84 ErpSync SaveErpConnectionSyncPriorities SOAP

SOAP request and response examples **Remote/Services84/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IErpSyncAgent.SaveErpConnectionSyncPriorities">SuperOffice.Services84.IErpSyncAgent.SaveErpConnectionSyncPriorities</see> method.

## SaveErpConnectionSyncPriorities

Takes an array of the ErpConnection ids and saves these as ordered sync priorities

* **erpConnectionIds:** The id put in array in the same order as the priorities

**Returns:** Returns true if new sync priorities is saved


[WSDL file for Services84/ErpSync](../Services84-ErpSync.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveErpConnectionSyncPriorities Request

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
   <ErpSync:SaveErpConnectionSyncPriorities>
    <ErpSync:ErpConnectionIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </ErpSync:ErpConnectionIds>
   </ErpSync:SaveErpConnectionSyncPriorities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveErpConnectionSyncPriorities Response

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
  <ErpSync:SaveErpConnectionSyncPrioritiesResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:SaveErpConnectionSyncPrioritiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

