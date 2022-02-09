---
title: Services86.FindAgent.FindFromRestrictions2 SOAP
generated: 1
uid: Services86-Find-FindFromRestrictions2
---

# Services86 Find FindFromRestrictions2

SOAP request and response examples **Remote/Services86/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IFindAgent.FindFromRestrictions2">SuperOffice.Services86.IFindAgent.FindFromRestrictions2</see> method.

## FindFromRestrictions2

Execute a Find operation and return a page of results. The criteria for the Find are passed in directly, not fetched by a restriction storage provider. The columns of the result are calculated based on the restriction.

* **restrictions:** String of restrictions specifying the search. e.g. "name='SuperOffice'" Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** Results from search, containing column information and result rows.


[WSDL file for Services86/Find](../Services86-Find.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindFromRestrictions2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:FindFromRestrictions2>
    <Find:Restrictions xsi:type="xsd:string"></Find:Restrictions>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:PageSize xsi:type="xsd:int">0</Find:PageSize>
    <Find:PageNumber xsi:type="xsd:int">0</Find:PageNumber>
   </Find:FindFromRestrictions2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindFromRestrictions2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Find:FindFromRestrictions2Response>
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
  </Find:FindFromRestrictions2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

