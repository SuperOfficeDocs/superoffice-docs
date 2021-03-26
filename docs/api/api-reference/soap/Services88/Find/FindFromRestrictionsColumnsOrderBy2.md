---
uid: services88-find-findfromrestrictionscolumnsorderby2
title: Services88.FindAgent.FindFromRestrictionsColumnsOrderBy2 SOAP
Generated: true
---

# Services88 Find FindFromRestrictionsColumnsOrderBy2 SOAP

SOAP request and response examples **Remote/Services88/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFindAgent.FindFromRestrictionsColumnsOrderBy2">SuperOffice.Services88.IFindAgent.FindFromRestrictionsColumnsOrderBy2</see> method.

## FindFromRestrictionsColumnsOrderBy2

Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is also passed in directly.&lt;para/&gt;Use the GetCriteriaInformation, GetDefaultDesiredColumns and GetDefaultOrderBy service methods to let the system calculate these values, if you want to use or modify them.

* **restrictions:** String of restrictions specifying the search. Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **desiredColumns:** Comma separated list of column names desired for the result. Each name must match a column offered by the given archive provider.
* **orderBy:** String of order by specifications. If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** Results from search, containing column information and result rows.


[WSDL file for Services88/Find](../Services88-Find.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindFromRestrictionsColumnsOrderBy2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:FindFromRestrictionsColumnsOrderBy2>
    <Find:Restrictions xsi:type="xsd:string"></Find:Restrictions>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:DesiredColumns xsi:type="xsd:string"></Find:DesiredColumns>
    <Find:OrderBy xsi:type="xsd:string"></Find:OrderBy>
    <Find:PageSize xsi:type="xsd:int">0</Find:PageSize>
    <Find:PageNumber xsi:type="xsd:int">0</Find:PageNumber>
   </Find:FindFromRestrictionsColumnsOrderBy2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindFromRestrictionsColumnsOrderBy2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Find:FindFromRestrictionsColumnsOrderBy2Response>
   <Find:Response xsi:type="Find:FindResults">
    <Find:ArchiveColumns xsi:type="Find:ArrayOfArchiveColumnInfo">
     <Find:ArchiveColumnInfo xsi:type="Find:ArchiveColumnInfo">
      <Find:DisplayName xsi:type="xsd:string"></Find:DisplayName>
      <Find:DisplayTooltip xsi:type="xsd:string"></Find:DisplayTooltip>
      <Find:DisplayType xsi:type="xsd:string"></Find:DisplayType>
      <Find:CanOrderBy xsi:type="xsd:boolean">false</Find:CanOrderBy>
      <Find:Name xsi:type="xsd:string"></Find:Name>
      <Find:CanRestrictBy xsi:type="xsd:boolean">false</Find:CanRestrictBy>
      <Find:RestrictionType xsi:type="xsd:string"></Find:RestrictionType>
      <Find:RestrictionListName xsi:type="xsd:string"></Find:RestrictionListName>
      <Find:IsVisible xsi:type="xsd:boolean">false</Find:IsVisible>
      <Find:Width xsi:type="xsd:string"></Find:Width>
      <Find:IconHint xsi:type="xsd:string"></Find:IconHint>
      <Find:HeadingIconHint xsi:type="xsd:string"></Find:HeadingIconHint>
     </Find:ArchiveColumnInfo>
    </Find:ArchiveColumns>
    <Find:ArchiveRows xsi:type="Find:ArrayOfArchiveListItem">
     <Find:ArchiveListItem xsi:type="Find:ArchiveListItem">
      <Find:EntityName xsi:type="xsd:string"></Find:EntityName>
      <Find:PrimaryKey xsi:type="xsd:int">0</Find:PrimaryKey>
      <Find:ColumnData xsi:type="Find:ColumnDataDictionary">
       <Find:ColumnDataKeyValuePair>
        <Find:Key xsi:type="xsd:string"></Find:Key>
        <Find:Value xsi:type="Find:ArchiveColumnData">
         <Find:DisplayValue xsi:type="xsd:string"></Find:DisplayValue>
         <Find:TooltipHint xsi:type="xsd:string"></Find:TooltipHint>
         <Find:LinkHint xsi:type="xsd:string"></Find:LinkHint>
        </Find:Value>
       </Find:ColumnDataKeyValuePair>
      </Find:ColumnData>
      <Find:LinkHint xsi:type="xsd:string"></Find:LinkHint>
      <Find:StyleHint xsi:type="xsd:string"></Find:StyleHint>
     </Find:ArchiveListItem>
    </Find:ArchiveRows>
    <Find:RowCount xsi:type="xsd:int">0</Find:RowCount>
   </Find:Response>
  </Find:FindFromRestrictionsColumnsOrderBy2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

