---
title: Services86.ErpSyncAgent.GetDefaultValueInfo SOAP
generated: 1
uid: Services86-ErpSync-GetDefaultValueInfo
---

# Services86 ErpSync GetDefaultValueInfo

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.GetDefaultValueInfo">SuperOffice.Services86.IErpSyncAgent.GetDefaultValueInfo</see> method.

## GetDefaultValueInfo

Get information about default value for an ERP field
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpFieldId:** The id of the ERP field

**Returns:** Object with information about default values


[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultValueInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
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

