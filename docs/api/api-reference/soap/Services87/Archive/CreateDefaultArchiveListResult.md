---
uid: services87-archive-createdefaultarchivelistresult
title: Services87.ArchiveAgent.CreateDefaultArchiveListResult SOAP
Generated: true
---

# Services87 Archive CreateDefaultArchiveListResult SOAP

SOAP request and response examples **Remote/Services87/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IArchiveAgent.CreateDefaultArchiveListResult">SuperOffice.Services87.IArchiveAgent.CreateDefaultArchiveListResult</see> method.

## CreateDefaultArchiveListResult

Loading default values into a new ArchiveListResult.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New ArchiveListResult with default values


[WSDL file for Services87/Archive](../Services87-Archive.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultArchiveListResult Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:CreateDefaultArchiveListResult>
   </Archive:CreateDefaultArchiveListResult>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultArchiveListResult Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Archive:CreateDefaultArchiveListResultResponse>
   <Archive:Response xsi:type="Archive:ArchiveListResult">
    <Archive:RowCount xsi:type="xsd:int">0</Archive:RowCount>
    <Archive:Rows xsi:type="Archive:ArrayOfArchiveListItem">
     <Archive:ArchiveListItem xsi:type="Archive:ArchiveListItem">
      <Archive:EntityName xsi:type="xsd:string"></Archive:EntityName>
      <Archive:PrimaryKey xsi:type="xsd:int">0</Archive:PrimaryKey>
      <Archive:ColumnData xsi:type="Archive:ColumnDataDictionary">
       <Archive:ColumnDataKeyValuePair>
        <Archive:Key xsi:type="xsd:string"></Archive:Key>
        <Archive:Value xsi:type="Archive:ArchiveColumnData">
         <Archive:DisplayValue xsi:type="xsd:string"></Archive:DisplayValue>
         <Archive:TooltipHint xsi:type="xsd:string"></Archive:TooltipHint>
         <Archive:LinkHint xsi:type="xsd:string"></Archive:LinkHint>
        </Archive:Value>
       </Archive:ColumnDataKeyValuePair>
      </Archive:ColumnData>
      <Archive:LinkHint xsi:type="xsd:string"></Archive:LinkHint>
      <Archive:StyleHint xsi:type="xsd:string"></Archive:StyleHint>
     </Archive:ArchiveListItem>
    </Archive:Rows>
   </Archive:Response>
  </Archive:CreateDefaultArchiveListResultResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

