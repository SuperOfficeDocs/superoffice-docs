---
title: Services85.FindAgent.FindWithExtraRestrictions2 SOAP
generated: 1
uid: Services85-Find-FindWithExtraRestrictions2
---

# Services85 Find FindWithExtraRestrictions2

SOAP request and response examples **Remote/Services85/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IFindAgent.FindWithExtraRestrictions2">SuperOffice.Services85.IFindAgent.FindWithExtraRestrictions2</see> method.

## FindWithExtraRestrictions2

Execute a Find operation and return a page of results. The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey.

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it fetches criteria for the search
* **extraRestrictions:** Extra restrictions to append to the the search. These will override saved restrictions with the same key.
* **orderBy:** Comma separated list of order by specifications. If it is null or empty, the row order is unspecified, database dependent, and might not be the same from call to call, depending on query execution plans. The unspecified order willgenerally not vary within pages of the same query.
* **desiredColumns:** Comma separated list of column names desired for the result. Each name must match a column offered by the given archive provider.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** Results from search, containing column information and result rows.


[WSDL file for Services85/Find](../Services85-Find.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindWithExtraRestrictions2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:FindWithExtraRestrictions2>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
    <Find:ExtraRestrictions xsi:type="xsd:string"></Find:ExtraRestrictions>
    <Find:OrderBy xsi:type="xsd:string"></Find:OrderBy>
    <Find:DesiredColumns xsi:type="xsd:string"></Find:DesiredColumns>
    <Find:PageSize xsi:type="xsd:int">0</Find:PageSize>
    <Find:PageNumber xsi:type="xsd:int">0</Find:PageNumber>
   </Find:FindWithExtraRestrictions2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindWithExtraRestrictions2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Find:FindWithExtraRestrictions2Response>
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
  </Find:FindWithExtraRestrictions2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

