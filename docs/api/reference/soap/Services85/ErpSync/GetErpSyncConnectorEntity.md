---
title: Services85.ErpSyncAgent.GetErpSyncConnectorEntity SOAP
generated: 1
uid: Services85-ErpSync-GetErpSyncConnectorEntity
---

# Services85 ErpSync GetErpSyncConnectorEntity

SOAP request and response examples **Remote/Services85/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IErpSyncAgent.GetErpSyncConnectorEntity">SuperOffice.Services85.IErpSyncAgent.GetErpSyncConnectorEntity</see> method.

## GetErpSyncConnectorEntity

Gets a ErpSyncConnectorEntity object.

* **erpSyncConnectorEntityId:** The identifier of the ErpSyncConnectorEntity object

**Returns:** ErpSyncConnectorEntity


[WSDL file for Services85/ErpSync](../Services85-ErpSync.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetErpSyncConnectorEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetErpSyncConnectorEntity>
    <ErpSync:ErpSyncConnectorEntityId xsi:type="xsd:int">0</ErpSync:ErpSyncConnectorEntityId>
   </ErpSync:GetErpSyncConnectorEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetErpSyncConnectorEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ErpSync:GetErpSyncConnectorEntityResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncConnectorEntity">
    <ErpSync:ErpConnectorId xsi:type="xsd:int">0</ErpSync:ErpConnectorId>
    <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
    <ErpSync:URL xsi:type="xsd:string"></ErpSync:URL>
    <ErpSync:Deleted xsi:type="xsd:boolean">false</ErpSync:Deleted>
   </ErpSync:Response>
  </ErpSync:GetErpSyncConnectorEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

