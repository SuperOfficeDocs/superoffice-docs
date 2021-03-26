---
uid: services75-erpsync-getdefaultvalueinfo
title: Services75.ErpSyncAgent.GetDefaultValueInfo SOAP
Generated: true
---

# Services75 ErpSync GetDefaultValueInfo SOAP

SOAP request and response examples **Remote/Services75/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IErpSyncAgent.GetDefaultValueInfo">SuperOffice.Services75.IErpSyncAgent.GetDefaultValueInfo</see> method.

## GetDefaultValueInfo

Get information about default value for an ERP field

* **erpFieldId:** The id of the ERP field

**Returns:** Object with information about default values


[WSDL file for Services75/ErpSync](../Services75-ErpSync.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultValueInfo Request

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
   <ErpSync:GetDefaultValueInfo>
    <ErpSync:ErpFieldId xsi:type="xsd:int">0</ErpSync:ErpFieldId>
   </ErpSync:GetDefaultValueInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultValueInfo Response

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
  <ErpSync:GetDefaultValueInfoResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncDefaultValue">
    <ErpSync:ErpFieldId xsi:type="xsd:int">0</ErpSync:ErpFieldId>
    <ErpSync:DefaultValue xsi:type="xsd:string"></ErpSync:DefaultValue>
    <ErpSync:HasFirstSyncDefaultValue xsi:type="xsd:boolean">false</ErpSync:HasFirstSyncDefaultValue>
    <ErpSync:FirstSyncDefaultValue xsi:type="xsd:string"></ErpSync:FirstSyncDefaultValue>
    <ErpSync:PromptUser xsi:type="xsd:boolean">false</ErpSync:PromptUser>
    <ErpSync:Mandatory xsi:type="xsd:boolean">false</ErpSync:Mandatory>
    <ErpSync:ErpFieldKey xsi:type="xsd:string"></ErpSync:ErpFieldKey>
    <ErpSync:FieldType xsi:type="ErpSync:FieldMetadataType">Checkbox</ErpSync:FieldType>
    <ErpSync:ListName xsi:type="xsd:string"></ErpSync:ListName>
    <ErpSync:Access xsi:type="ErpSync:FieldAccess">Normal</ErpSync:Access>
   </ErpSync:Response>
  </ErpSync:GetDefaultValueInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

