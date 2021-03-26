---
uid: services75-erpsync-createerpactorfromcrm
title: Services75.ErpSyncAgent.CreateErpActorFromCrm SOAP
Generated: true
---

# Services75 ErpSync CreateErpActorFromCrm SOAP

SOAP request and response examples **Remote/Services75/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IErpSyncAgent.CreateErpActorFromCrm">SuperOffice.Services75.IErpSyncAgent.CreateErpActorFromCrm</see> method.

## CreateErpActorFromCrm

Create ErpActor from crm entity

* **connectionId:** The connection ID
* **crmEntityId:** The ID of the CRM entity to create an ERP actor from
* **erpActorType:** The ERP actor type
* **crmActorType:** The CRM actor type
* **erpFieldKeyValues:** A map of matching erp field keys and values to set for the new erp entity

**Returns:** Created ERP actor with success


[WSDL file for Services75/ErpSync](../Services75-ErpSync.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateErpActorFromCrm Request

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
   <ErpSync:CreateErpActorFromCrm>
    <ErpSync:ConnectionId xsi:type="xsd:int">0</ErpSync:ConnectionId>
    <ErpSync:CrmEntityId xsi:type="xsd:int">0</ErpSync:CrmEntityId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
    <ErpSync:CrmActorType xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:CrmActorType>
    <ErpSync:ErpFieldKeyValues xsi:type="ErpSync:StringDictionary">
     <ErpSync:StringKeyValuePair>
      <ErpSync:Key xsi:type="xsd:string"></ErpSync:Key>
      <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
     </ErpSync:StringKeyValuePair>
    </ErpSync:ErpFieldKeyValues>
   </ErpSync:CreateErpActorFromCrm>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateErpActorFromCrm Response

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
  <ErpSync:CreateErpActorFromCrmResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:CreateErpActorFromCrmResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

