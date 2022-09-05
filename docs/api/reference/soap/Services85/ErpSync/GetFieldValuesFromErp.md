---
title: Services85.ErpSyncAgent.GetFieldValuesFromErp SOAP
generated: 1
uid: Services85-ErpSync-GetFieldValuesFromErp
---

# Services85 ErpSync GetFieldValuesFromErp

SOAP request and response examples **Remote/Services85/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IErpSyncAgent.GetFieldValuesFromErp">SuperOffice.Services85.IErpSyncAgent.GetFieldValuesFromErp</see> method.

## GetFieldValuesFromErp

Get Erp Field values

* **erpConnectionId:** Erp connection id
* **actorTypeErp:** ERP Actor type
* **erpKey:** Primary key for the erp actor

**Returns:** The Erp Fields


[WSDL file for Services85/ErpSync](../Services85-ErpSync.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFieldValuesFromErp Request

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
   <ErpSync:GetFieldValuesFromErp>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ActorTypeErp xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ActorTypeErp>
    <ErpSync:ErpKey xsi:type="xsd:string"></ErpSync:ErpKey>
   </ErpSync:GetFieldValuesFromErp>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFieldValuesFromErp Response

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
  <ErpSync:GetFieldValuesFromErpResponse>
   <ErpSync:Response xsi:type="ErpSync:ArrayOfErpSyncFieldValue">
    <ErpSync:ErpSyncFieldValue xsi:type="ErpSync:ErpSyncFieldValue">
     <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
     <ErpSync:CrmFieldKey xsi:type="xsd:string"></ErpSync:CrmFieldKey>
     <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
     <ErpSync:DisplayValue xsi:type="xsd:string"></ErpSync:DisplayValue>
     <ErpSync:SyncToCrm xsi:type="xsd:boolean">false</ErpSync:SyncToCrm>
     <ErpSync:SyncToErp xsi:type="xsd:boolean">false</ErpSync:SyncToErp>
    </ErpSync:ErpSyncFieldValue>
   </ErpSync:Response>
  </ErpSync:GetFieldValuesFromErpResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

