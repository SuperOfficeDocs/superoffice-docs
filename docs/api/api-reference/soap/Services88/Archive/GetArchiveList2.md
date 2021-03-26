---
uid: services88-archive-getarchivelist2
title: Services88.ArchiveAgent.GetArchiveList2 SOAP
Generated: true
---

# Services88 Archive GetArchiveList2 SOAP

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.GetArchiveList2">SuperOffice.Services88.IArchiveAgent.GetArchiveList2</see> method.

## GetArchiveList2

Get a page of data for an archive using a restriction string. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.

* **guiName:** The GUI name of the archive list, used to retrieve the currently configured set of columns (otherwise manipulated using the ArchiveConfiguration service)
* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **sortOrder:** Sort order for the archive. Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions as string. e.g. "name = 'baz' or category oneOf (1,2,3)". Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Comma separated list of entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)

**Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)


[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveList2 Request

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
   <Archive:GetArchiveList2>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:SortOrder xsi:type="xsd:string"></Archive:SortOrder>
    <Archive:Restriction xsi:type="xsd:string"></Archive:Restriction>
    <Archive:Entities xsi:type="xsd:string"></Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
   </Archive:GetArchiveList2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveList2 Response

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
  <Archive:GetArchiveList2Response>
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
  </Archive:GetArchiveList2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

