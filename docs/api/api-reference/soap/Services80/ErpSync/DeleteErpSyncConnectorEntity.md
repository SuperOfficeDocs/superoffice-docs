---
uid: services80-erpsync-deleteerpsyncconnectorentity
title: Services80.ErpSyncAgent.DeleteErpSyncConnectorEntity SOAP
Generated: true
---

# Services80 ErpSync DeleteErpSyncConnectorEntity SOAP

SOAP request and response examples **Remote/Services80/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IErpSyncAgent.DeleteErpSyncConnectorEntity">SuperOffice.Services80.IErpSyncAgent.DeleteErpSyncConnectorEntity</see> method.

## DeleteErpSyncConnectorEntity

Deletes the ErpSyncConnectorEntity

* **erpSyncConnectorEntityId:** The identity of the ErpSyncConnectorEntity



[WSDL file for Services80/ErpSync](../Services80-ErpSync.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteErpSyncConnectorEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:DeleteErpSyncConnectorEntity>
    <ErpSync:ErpSyncConnectorEntityId xsi:type="xsd:int">0</ErpSync:ErpSyncConnectorEntityId>
   </ErpSync:DeleteErpSyncConnectorEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteErpSyncConnectorEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <ErpSync:DeleteErpSyncConnectorEntityResponse>
  </ErpSync:DeleteErpSyncConnectorEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

