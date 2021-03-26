---
uid: services81-erpsync-savedefaultvalueinfo
title: Services81.ErpSyncAgent.SaveDefaultValueInfo SOAP
Generated: true
---

# Services81 ErpSync SaveDefaultValueInfo SOAP

SOAP request and response examples **Remote/Services81/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IErpSyncAgent.SaveDefaultValueInfo">SuperOffice.Services81.IErpSyncAgent.SaveDefaultValueInfo</see> method.

## SaveDefaultValueInfo

Save information about a default value for an ERP field

* **erpSyncDefaultValue:** The id of the ERPfield to save

**Returns:** The newly saved ErpSyncDefaultValue


[WSDL file for Services81/ErpSync](../Services81-ErpSync.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDefaultValueInfo Request

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
   <ErpSync:SaveDefaultValueInfo>
    <ErpSync:ErpSyncDefaultValue xsi:type="ErpSync:ErpSyncDefaultValue">
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
    </ErpSync:ErpSyncDefaultValue>
   </ErpSync:SaveDefaultValueInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDefaultValueInfo Response

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
  <ErpSync:SaveDefaultValueInfoResponse>
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
  </ErpSync:SaveDefaultValueInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

