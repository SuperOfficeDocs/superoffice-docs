---
uid: services84-archive-getarchivelistbycolumnswithheader2
title: Services84.ArchiveAgent.GetArchiveListByColumnsWithHeader2 SOAP
Generated: true
---

# Services84 Archive GetArchiveListByColumnsWithHeader2 SOAP

SOAP request and response examples **Remote/Services84/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IArchiveAgent.GetArchiveListByColumnsWithHeader2">SuperOffice.Services84.IArchiveAgent.GetArchiveListByColumnsWithHeader2</see> method.

## GetArchiveListByColumnsWithHeader2

Get a page of results for an archive list, explicitly specifying the restrictions as strings, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.

* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **columns:** Comma separated string of the names of the columns wanted.
* **sortOrder:** Comma separated string of sort order for the archive. e.g. "name asc, dept desc" Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions. e.g. "category = 2 or business oneOf (2,3,4)" Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Comma separated list of entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
* **options:** name=value&amp;... formatted set of options. "rowcount=true" will cause the rowcount to be calculated and populated.

**Returns:** Header with optional row count, plus array of archive list items, where each item represents one row of data (row level data + the requested columns)


[WSDL file for Services84/Archive](../Services84-Archive.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListByColumnsWithHeader2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveListByColumnsWithHeader2>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Columns xsi:type="xsd:string"></Archive:Columns>
    <Archive:SortOrder xsi:type="xsd:string"></Archive:SortOrder>
    <Archive:Restriction xsi:type="xsd:string"></Archive:Restriction>
    <Archive:Entities xsi:type="xsd:string"></Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Options xsi:type="xsd:string"></Archive:Options>
   </Archive:GetArchiveListByColumnsWithHeader2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListByColumnsWithHeader2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Archive:GetArchiveListByColumnsWithHeader2Response>
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
  </Archive:GetArchiveListByColumnsWithHeader2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

