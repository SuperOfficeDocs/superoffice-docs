---
title: Services88.ArchiveAgent.GetArchiveListByColumnsWithHeaderWithContext2 SOAP
generated: true
uid: Services88-Archive-GetArchiveListByColumnsWithHeaderWithContext2
---

# Services88 Archive GetArchiveListByColumnsWithHeaderWithContext2

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.GetArchiveListByColumnsWithHeaderWithContext2">SuperOffice.Services88.IArchiveAgent.GetArchiveListByColumnsWithHeaderWithContext2</see> method.

## GetArchiveListByColumnsWithHeaderWithContext2





[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListByColumnsWithHeaderWithContext2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveListByColumnsWithHeaderWithContext2>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Columns xsi:type="xsd:string"></Archive:Columns>
    <Archive:SortOrder xsi:type="xsd:string"></Archive:SortOrder>
    <Archive:Restriction xsi:type="xsd:string"></Archive:Restriction>
    <Archive:Entities xsi:type="xsd:string"></Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Options xsi:type="xsd:string"></Archive:Options>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetArchiveListByColumnsWithHeaderWithContext2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListByColumnsWithHeaderWithContext2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Archive:GetArchiveListByColumnsWithHeaderWithContext2Response>
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
  </Archive:GetArchiveListByColumnsWithHeaderWithContext2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

