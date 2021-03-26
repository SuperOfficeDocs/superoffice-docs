---
uid: services88-bulkupdate-getstoredfields
title: Services88.BulkUpdateAgent.GetStoredFields SOAP
Generated: true
---

# Services88 BulkUpdate GetStoredFields SOAP

SOAP request and response examples **Remote/Services88/BulkUpdate.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBulkUpdateAgent.GetStoredFields">SuperOffice.Services88.IBulkUpdateAgent.GetStoredFields</see> method.

## GetStoredFields

Get all stored fields for a given tablename/entity and context

* **tablename:** The name of the wanted tablename
* **context:** Where is the function called for

**Returns:** Returns array of the stored or default fields for the given entity


[WSDL file for Services88/BulkUpdate](../Services88-BulkUpdate.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetStoredFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <BulkUpdate:ApplicationToken>1234567-1234-9876</BulkUpdate:ApplicationToken>
  <BulkUpdate:Credentials>
    <BulkUpdate:Ticket>7T:1234abcxyzExample==</BulkUpdate:Ticket>
  </BulkUpdate:Credentials>
 <SOAP-ENV:Body>
   <BulkUpdate:GetStoredFields>
    <BulkUpdate:Tablename xsi:type="xsd:string"></BulkUpdate:Tablename>
    <BulkUpdate:Context xsi:type="xsd:string"></BulkUpdate:Context>
   </BulkUpdate:GetStoredFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetStoredFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <BulkUpdate:GetStoredFieldsResponse>
   <BulkUpdate:Response xsi:type="BulkUpdate:ArrayOfFieldValueInfo">
    <BulkUpdate:FieldValueInfo xsi:type="BulkUpdate:FieldValueInfo">
     <BulkUpdate:CanSupportMultiUse xsi:type="xsd:boolean">false</BulkUpdate:CanSupportMultiUse>
     <BulkUpdate:DefaultShowInGui xsi:type="xsd:boolean">false</BulkUpdate:DefaultShowInGui>
     <BulkUpdate:DefaultShowInSelector xsi:type="xsd:boolean">false</BulkUpdate:DefaultShowInSelector>
     <BulkUpdate:IsActive xsi:type="xsd:boolean">false</BulkUpdate:IsActive>
     <BulkUpdate:Key xsi:type="xsd:string"></BulkUpdate:Key>
     <BulkUpdate:ValueType xsi:type="xsd:string"></BulkUpdate:ValueType>
     <BulkUpdate:Mandatory xsi:type="xsd:boolean">false</BulkUpdate:Mandatory>
     <BulkUpdate:EncodedDisplayName xsi:type="xsd:string"></BulkUpdate:EncodedDisplayName>
     <BulkUpdate:EncodedDisplayDescription xsi:type="xsd:string"></BulkUpdate:EncodedDisplayDescription>
     <BulkUpdate:IconHint xsi:type="xsd:string"></BulkUpdate:IconHint>
     <BulkUpdate:ControlInfos xsi:type="BulkUpdate:ArrayOfControlInfo">
      <BulkUpdate:ControlInfo xsi:type="BulkUpdate:ControlInfo">
       <BulkUpdate:Type xsi:type="xsd:string"></BulkUpdate:Type>
       <BulkUpdate:Label xsi:type="xsd:string"></BulkUpdate:Label>
       <BulkUpdate:Dimension xsi:type="xsd:int">0</BulkUpdate:Dimension>
       <BulkUpdate:ListProviderName xsi:type="xsd:string"></BulkUpdate:ListProviderName>
       <BulkUpdate:ListProviderExtraInfo xsi:type="xsd:string"></BulkUpdate:ListProviderExtraInfo>
       <BulkUpdate:ListProviderPrimaryKeyName xsi:type="xsd:string"></BulkUpdate:ListProviderPrimaryKeyName>
       <BulkUpdate:ListLeadText xsi:type="xsd:string"></BulkUpdate:ListLeadText>
      </BulkUpdate:ControlInfo>
     </BulkUpdate:ControlInfos>
     <BulkUpdate:EncodedDataCaption xsi:type="xsd:string"></BulkUpdate:EncodedDataCaption>
     <BulkUpdate:EncodedDataCaptionDescription xsi:type="xsd:string"></BulkUpdate:EncodedDataCaptionDescription>
     <BulkUpdate:CurrentOperationType xsi:type="xsd:string"></BulkUpdate:CurrentOperationType>
     <BulkUpdate:Values xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </BulkUpdate:Values>
     <BulkUpdate:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </BulkUpdate:DisplayValues>
     <BulkUpdate:OperationInfos xsi:type="BulkUpdate:ArrayOfOperationInfo">
      <BulkUpdate:OperationInfo xsi:type="BulkUpdate:OperationInfo">
       <BulkUpdate:Key xsi:type="xsd:string"></BulkUpdate:Key>
       <BulkUpdate:EncodedDisplayName xsi:type="xsd:string"></BulkUpdate:EncodedDisplayName>
       <BulkUpdate:EncodedLeadTexts xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </BulkUpdate:EncodedLeadTexts>
      </BulkUpdate:OperationInfo>
     </BulkUpdate:OperationInfos>
    </BulkUpdate:FieldValueInfo>
   </BulkUpdate:Response>
  </BulkUpdate:GetStoredFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

