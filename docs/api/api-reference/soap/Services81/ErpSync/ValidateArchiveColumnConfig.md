---
uid: services81-erpsync-validatearchivecolumnconfig
title: Services81.ErpSyncAgent.ValidateArchiveColumnConfig SOAP
Generated: true
---

# Services81 ErpSync ValidateArchiveColumnConfig SOAP

SOAP request and response examples **Remote/Services81/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IErpSyncAgent.ValidateArchiveColumnConfig">SuperOffice.Services81.IErpSyncAgent.ValidateArchiveColumnConfig</see> method.

## ValidateArchiveColumnConfig

Clear field info from table SUPERLISTCOLUMNSIZE if field mapping changed on given connection

* **listOwner:** GUI name used in archive control config
* **erpConnectionId:** The ERP connection ID

**Returns:** Validated ArchiveColumnConfig


[WSDL file for Services81/ErpSync](../Services81-ErpSync.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateArchiveColumnConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services81">
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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <ErpSync:ValidateArchiveColumnConfigResponse>
  </ErpSync:ValidateArchiveColumnConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

