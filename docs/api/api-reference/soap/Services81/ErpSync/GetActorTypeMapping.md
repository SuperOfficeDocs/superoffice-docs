---
uid: services81-erpsync-getactortypemapping
title: Services81.ErpSyncAgent.GetActorTypeMapping SOAP
Generated: true
---

# Services81 ErpSync GetActorTypeMapping SOAP

SOAP request and response examples **Remote/Services81/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IErpSyncAgent.GetActorTypeMapping">SuperOffice.Services81.IErpSyncAgent.GetActorTypeMapping</see> method.

## GetActorTypeMapping

Get the current mappings for one connection/actor; connection+actor type = unique key

* **erpConnectionId:** The ERP connection ID
* **actorType:** The actor type

**Returns:** The current mapping from the database


[WSDL file for Services81/ErpSync](../Services81-ErpSync.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetActorTypeMapping Request

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
   <ErpSync:GetActorTypeMapping>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ActorType>
   </ErpSync:GetActorTypeMapping>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetActorTypeMapping Response

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
  <ErpSync:GetActorTypeMappingResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncActorTypeMapping">
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:IsActive xsi:type="xsd:boolean">false</ErpSync:IsActive>
    <ErpSync:FieldMappings xsi:type="ErpSync:ArrayOfErpSyncFieldMapping">
     <ErpSync:ErpSyncFieldMapping xsi:type="ErpSync:ErpSyncFieldMapping">
      <ErpSync:ErpFieldId xsi:type="xsd:int">0</ErpSync:ErpFieldId>
      <ErpSync:CrmFieldKey xsi:type="xsd:string"></ErpSync:CrmFieldKey>
      <ErpSync:CrmDisplayName xsi:type="xsd:string"></ErpSync:CrmDisplayName>
      <ErpSync:CrmDisplayTooltip xsi:type="xsd:string"></ErpSync:CrmDisplayTooltip>
      <ErpSync:ErpFieldKey xsi:type="xsd:string"></ErpSync:ErpFieldKey>
      <ErpSync:FieldType xsi:type="ErpSync:FieldMetadataType">Checkbox</ErpSync:FieldType>
      <ErpSync:ErpDisplayName xsi:type="xsd:string"></ErpSync:ErpDisplayName>
      <ErpSync:ErpDisplayTooltip xsi:type="xsd:string"></ErpSync:ErpDisplayTooltip>
      <ErpSync:SyncToCrm xsi:type="xsd:boolean">false</ErpSync:SyncToCrm>
      <ErpSync:SyncToErp xsi:type="xsd:boolean">false</ErpSync:SyncToErp>
      <ErpSync:ShowInGui xsi:type="xsd:boolean">false</ErpSync:ShowInGui>
      <ErpSync:ShowInSearch xsi:type="xsd:boolean">false</ErpSync:ShowInSearch>
      <ErpSync:AlreadyMapped xsi:type="xsd:boolean">false</ErpSync:AlreadyMapped>
      <ErpSync:MissingInERP xsi:type="xsd:boolean">false</ErpSync:MissingInERP>
      <ErpSync:MissingInCRM xsi:type="xsd:boolean">false</ErpSync:MissingInCRM>
      <ErpSync:Access xsi:type="ErpSync:FieldAccess">Normal</ErpSync:Access>
     </ErpSync:ErpSyncFieldMapping>
    </ErpSync:FieldMappings>
    <ErpSync:ActorTypeErp xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ActorTypeErp>
    <ErpSync:ActorTypeCrm xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:ActorTypeCrm>
   </ErpSync:Response>
  </ErpSync:GetActorTypeMappingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

