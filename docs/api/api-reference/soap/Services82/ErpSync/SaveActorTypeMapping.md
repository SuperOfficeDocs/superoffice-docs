---
uid: services82-erpsync-saveactortypemapping
title: Services82.ErpSyncAgent.SaveActorTypeMapping SOAP
Generated: true
---

# Services82 ErpSync SaveActorTypeMapping SOAP

SOAP request and response examples **Remote/Services82/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IErpSyncAgent.SaveActorTypeMapping">SuperOffice.Services82.IErpSyncAgent.SaveActorTypeMapping</see> method.

## SaveActorTypeMapping

Save mappings for a connection/actor

* **mapping:** The mapping to be saved; new mapping rows will be created in the database if needed

**Returns:** The current mapping from the database


[WSDL file for Services82/ErpSync](../Services82-ErpSync.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveActorTypeMapping Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:SaveActorTypeMapping>
    <ErpSync:Mapping xsi:type="ErpSync:ErpSyncActorTypeMapping">
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
    </ErpSync:Mapping>
   </ErpSync:SaveActorTypeMapping>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveActorTypeMapping Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <ErpSync:SaveActorTypeMappingResponse>
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
  </ErpSync:SaveActorTypeMappingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

