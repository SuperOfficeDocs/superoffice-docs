---
uid: services88-erpsync-validatearchivecolumnconfig
title: Services88.ErpSyncAgent.ValidateArchiveColumnConfig SOAP
Generated: true
---

# Services88 ErpSync ValidateArchiveColumnConfig SOAP

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.ValidateArchiveColumnConfig">SuperOffice.Services88.IErpSyncAgent.ValidateArchiveColumnConfig</see> method.

## ValidateArchiveColumnConfig

Clear field info from table SUPERLISTCOLUMNSIZE if field mapping changed on given connection
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **listOwner:** GUI name used in archive control config
* **erpConnectionId:** The ERP connection ID

**Returns:** Validated ArchiveColumnConfig


[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateArchiveColumnConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:ValidateArchiveColumnConfig>
    <ErpSync:ListOwner xsi:type="xsd:string"></ErpSync:ListOwner>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:ValidateArchiveColumnConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateArchiveColumnConfig Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ErpSync:ValidateArchiveColumnConfigResponse>
  </ErpSync:ValidateArchiveColumnConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

