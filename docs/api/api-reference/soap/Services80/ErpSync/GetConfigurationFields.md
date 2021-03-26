---
uid: services80-erpsync-getconfigurationfields
title: Services80.ErpSyncAgent.GetConfigurationFields SOAP
Generated: true
---

# Services80 ErpSync GetConfigurationFields SOAP

SOAP request and response examples **Remote/Services80/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IErpSyncAgent.GetConfigurationFields">SuperOffice.Services80.IErpSyncAgent.GetConfigurationFields</see> method.

## GetConfigurationFields

Returns all fields needed to connect to the given connector

* **erpConnectorId:** The id of the erp connector

**Returns:** The fields


[WSDL file for Services80/ErpSync](../Services80-ErpSync.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConfigurationFields Request

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
   <ErpSync:GetConfigurationFields>
    <ErpSync:ErpConnectorId xsi:type="xsd:int">0</ErpSync:ErpConnectorId>
   </ErpSync:GetConfigurationFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConfigurationFields Response

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
  <ErpSync:GetConfigurationFieldsResponse>
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
  </ErpSync:GetConfigurationFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

