---
uid: services83-erpsync-getconnectionsanddisplayfields
title: Services83.ErpSyncAgent.GetConnectionsAndDisplayFields SOAP
Generated: true
---

# Services83 ErpSync GetConnectionsAndDisplayFields SOAP

SOAP request and response examples **Remote/Services83/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IErpSyncAgent.GetConnectionsAndDisplayFields">SuperOffice.Services83.IErpSyncAgent.GetConnectionsAndDisplayFields</see> method.

## GetConnectionsAndDisplayFields

Get all connection statuses and fields for a given entity

* **crmActorType:** The type of the CRM entity
* **entityId:** The id of the entity

**Returns:** An array of ErpConnectionData carriers


[WSDL file for Services83/ErpSync](../Services83-ErpSync.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConnectionsAndDisplayFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetConnectionsAndDisplayFields>
    <ErpSync:CrmActorType xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:CrmActorType>
    <ErpSync:EntityId xsi:type="xsd:int">0</ErpSync:EntityId>
   </ErpSync:GetConnectionsAndDisplayFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConnectionsAndDisplayFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <ErpSync:GetConnectionsAndDisplayFieldsResponse>
   <ErpSync:Response xsi:type="ErpSync:ArrayOfErpConnectionData">
    <ErpSync:ErpConnectionData xsi:type="ErpSync:ErpConnectionData">
     <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
     <ErpSync:ConnectionName xsi:type="xsd:string"></ErpSync:ConnectionName>
     <ErpSync:Connected xsi:type="xsd:boolean">false</ErpSync:Connected>
     <ErpSync:ErpFields xsi:type="ErpSync:ArrayOfFieldMetadata">
      <ErpSync:FieldMetadata xsi:type="ErpSync:FieldMetadata">
       <ErpSync:FieldKey xsi:type="xsd:string"></ErpSync:FieldKey>
       <ErpSync:Rank xsi:type="xsd:int">0</ErpSync:Rank>
       <ErpSync:DisplayName xsi:type="xsd:string"></ErpSync:DisplayName>
       <ErpSync:DisplayDescription xsi:type="xsd:string"></ErpSync:DisplayDescription>
       <ErpSync:FieldType xsi:type="ErpSync:FieldMetadataType">Checkbox</ErpSync:FieldType>
       <ErpSync:ListName xsi:type="xsd:string"></ErpSync:ListName>
       <ErpSync:DefaultValue xsi:type="xsd:string"></ErpSync:DefaultValue>
       <ErpSync:MaxLength xsi:type="xsd:int">0</ErpSync:MaxLength>
       <ErpSync:Access xsi:type="ErpSync:FieldAccess">Normal</ErpSync:Access>
       <ErpSync:ShowInSearch xsi:type="xsd:boolean">false</ErpSync:ShowInSearch>
      </ErpSync:FieldMetadata>
     </ErpSync:ErpFields>
     <ErpSync:CrmActorType xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:CrmActorType>
     <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
     <ErpSync:ErpActorTypes xsi:type="ErpSync:ArrayOfErpActorType">
      <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
     </ErpSync:ErpActorTypes>
    </ErpSync:ErpConnectionData>
   </ErpSync:Response>
  </ErpSync:GetConnectionsAndDisplayFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

