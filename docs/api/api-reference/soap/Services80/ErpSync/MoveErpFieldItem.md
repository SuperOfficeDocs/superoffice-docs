---
uid: services80-erpsync-moveerpfielditem
title: Services80.ErpSyncAgent.MoveErpFieldItem SOAP
Generated: true
---

# Services80 ErpSync MoveErpFieldItem SOAP

SOAP request and response examples **Remote/Services80/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IErpSyncAgent.MoveErpFieldItem">SuperOffice.Services80.IErpSyncAgent.MoveErpFieldItem</see> method.

## MoveErpFieldItem

Moves the rank of the erp field up or down

* **erpFieldId:** The id of the erp field to move
* **direction:** Positive value to increase rank, negative to decrease.
* **erpConnectionId:** The id of the connection
* **erpActorType:** The actor type for which we want to rank fields



[WSDL file for Services80/ErpSync](../Services80-ErpSync.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MoveErpFieldItem Request

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
   <ErpSync:MoveErpFieldItem>
    <ErpSync:ErpFieldId xsi:type="xsd:int">0</ErpSync:ErpFieldId>
    <ErpSync:Direction xsi:type="xsd:int">0</ErpSync:Direction>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
   </ErpSync:MoveErpFieldItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MoveErpFieldItem Response

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
  <ErpSync:MoveErpFieldItemResponse>
  </ErpSync:MoveErpFieldItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

