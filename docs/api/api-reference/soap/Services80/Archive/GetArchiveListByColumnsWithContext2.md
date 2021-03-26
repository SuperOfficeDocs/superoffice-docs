---
uid: services80-archive-getarchivelistbycolumnswithcontext2
title: Services80.ArchiveAgent.GetArchiveListByColumnsWithContext2 SOAP
Generated: true
---

# Services80 Archive GetArchiveListByColumnsWithContext2 SOAP

SOAP request and response examples **Remote/Services80/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IArchiveAgent.GetArchiveListByColumnsWithContext2">SuperOffice.Services80.IArchiveAgent.GetArchiveListByColumnsWithContext2</see> method.

## GetArchiveListByColumnsWithContext2





[WSDL file for Services80/Archive](../Services80-Archive.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListByColumnsWithContext2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveListByColumnsWithContext2>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Columns xsi:type="xsd:string"></Archive:Columns>
    <Archive:SortOrder xsi:type="xsd:string"></Archive:SortOrder>
    <Archive:Restriction xsi:type="xsd:string"></Archive:Restriction>
    <Archive:Entities xsi:type="xsd:string"></Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetArchiveListByColumnsWithContext2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListByColumnsWithContext2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Archive:GetArchiveListByColumnsWithContext2Response>
   <Archive:Response xsi:type="Archive:ArrayOfArchiveListItem">
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
   </Archive:Response>
  </Archive:GetArchiveListByColumnsWithContext2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

