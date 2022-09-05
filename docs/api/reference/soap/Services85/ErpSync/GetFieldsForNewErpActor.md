---
title: Services85.ErpSyncAgent.GetFieldsForNewErpActor SOAP
generated: 1
uid: Services85-ErpSync-GetFieldsForNewErpActor
---

# Services85 ErpSync GetFieldsForNewErpActor

SOAP request and response examples **Remote/Services85/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IErpSyncAgent.GetFieldsForNewErpActor">SuperOffice.Services85.IErpSyncAgent.GetFieldsForNewErpActor</see> method.

## GetFieldsForNewErpActor

Get the fields that must be filled out when creating a new ERP actor

* **erpConnectionId:** The id of the connection
* **erpActorType:** The type of the ERP actor to create

**Returns:** The fields that are required for the new ERP actor


[WSDL file for Services85/ErpSync](../Services85-ErpSync.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFieldsForNewErpActor Request

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
   <ErpSync:GetFieldsForNewErpActor>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
   </ErpSync:GetFieldsForNewErpActor>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFieldsForNewErpActor Response

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
  <ErpSync:GetFieldsForNewErpActorResponse>
   <ErpSync:Response xsi:type="ErpSync:ArrayOfFieldMetadata">
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
   </ErpSync:Response>
  </ErpSync:GetFieldsForNewErpActorResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

