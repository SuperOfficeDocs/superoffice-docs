---
uid: services75-archive-getarchivelistbycolumnswithheader
title: Services75.ArchiveAgent.GetArchiveListByColumnsWithHeader SOAP
Generated: true
---

# Services75 Archive GetArchiveListByColumnsWithHeader SOAP

SOAP request and response examples **Remote/Services75/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IArchiveAgent.GetArchiveListByColumnsWithHeader">SuperOffice.Services75.IArchiveAgent.GetArchiveListByColumnsWithHeader</see> method.

## GetArchiveListByColumnsWithHeader

Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns; as well as a name/value string formatted set of options. The return value includes a header that has various extra information, in addition to the actual rows.

* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **columns:** An array of the names of the columns wanted.
* **sortOrder:** Sort order for the archive. Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions. Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Which entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
* **options:** name=value&amp;... formatted set of options. rowcount=true will cause the rowcount to be calculated and populated.

**Returns:** Header with optional row count, plus array of archive list items, where each item represents one row of data (row level data + the requested columns)


[WSDL file for Services75/Archive](../Services75-Archive.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListByColumnsWithHeader Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveListByColumnsWithHeader>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Columns xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Archive:Columns>
    <Archive:SortOrder xsi:type="Archive:ArrayOfArchiveOrderByInfo">
     <Archive:ArchiveOrderByInfo xsi:type="Archive:ArchiveOrderByInfo">
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:Direction xsi:type="Archive:OrderBySortType">ASC</Archive:Direction>
     </Archive:ArchiveOrderByInfo>
    </Archive:SortOrder>
    <Archive:Restriction xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
     <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
      <Archive:Name xsi:type="xsd:string"></Archive:Name>
      <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
      <Archive:Values xsi:type="NetServerServices752:ArrayOfstring">
       <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
      </Archive:Values>
      <Archive:DisplayValues xsi:type="NetServerServices752:ArrayOfstring">
       <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
      </Archive:DisplayValues>
      <Archive:ColumnInfo xsi:type="Archive:ArchiveColumnInfo">
       <Archive:DisplayName xsi:type="xsd:string"></Archive:DisplayName>
       <Archive:DisplayTooltip xsi:type="xsd:string"></Archive:DisplayTooltip>
       <Archive:DisplayType xsi:type="xsd:string"></Archive:DisplayType>
       <Archive:CanOrderBy xsi:type="xsd:boolean">false</Archive:CanOrderBy>
       <Archive:Name xsi:type="xsd:string"></Archive:Name>
       <Archive:CanRestrictBy xsi:type="xsd:boolean">false</Archive:CanRestrictBy>
       <Archive:RestrictionType xsi:type="xsd:string"></Archive:RestrictionType>
       <Archive:RestrictionListName xsi:type="xsd:string"></Archive:RestrictionListName>
       <Archive:IsVisible xsi:type="xsd:boolean">false</Archive:IsVisible>
       <Archive:Width xsi:type="xsd:string"></Archive:Width>
       <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
       <Archive:HeadingIconHint xsi:type="xsd:string"></Archive:HeadingIconHint>
      </Archive:ColumnInfo>
      <Archive:IsActive xsi:type="xsd:boolean">false</Archive:IsActive>
      <Archive:SubRestrictions xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
       <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
        <Archive:Name xsi:type="xsd:string"></Archive:Name>
        <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
        <Archive:Values xsi:type="NetServerServices752:ArrayOfstring">
         <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
        </Archive:Values>
        <Archive:DisplayValues xsi:type="NetServerServices752:ArrayOfstring">
         <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
        </Archive:DisplayValues>
        <Archive:ColumnInfo xsi:type="Archive:ArchiveColumnInfo">
         <Archive:DisplayName xsi:type="xsd:string"></Archive:DisplayName>
         <Archive:DisplayTooltip xsi:type="xsd:string"></Archive:DisplayTooltip>
         <Archive:DisplayType xsi:type="xsd:string"></Archive:DisplayType>
         <Archive:CanOrderBy xsi:type="xsd:boolean">false</Archive:CanOrderBy>
         <Archive:Name xsi:type="xsd:string"></Archive:Name>
         <Archive:CanRestrictBy xsi:type="xsd:boolean">false</Archive:CanRestrictBy>
         <Archive:RestrictionType xsi:type="xsd:string"></Archive:RestrictionType>
         <Archive:RestrictionListName xsi:type="xsd:string"></Archive:RestrictionListName>
         <Archive:IsVisible xsi:type="xsd:boolean">false</Archive:IsVisible>
         <Archive:Width xsi:type="xsd:string"></Archive:Width>
         <Archive:IconHint xsi:type="xsd:string"></Archive:IconHint>
         <Archive:HeadingIconHint xsi:type="xsd:string"></Archive:HeadingIconHint>
        </Archive:ColumnInfo>
        <Archive:IsActive xsi:type="xsd:boolean">false</Archive:IsActive>
        <Archive:SubRestrictions xsi:type="Archive:ArrayOfArchiveRestrictionInfo">
         <Archive:ArchiveRestrictionInfo xsi:type="Archive:ArchiveRestrictionInfo">
          <Archive:Name xsi:type="xsd:string"></Archive:Name>
          <Archive:Operator xsi:type="xsd:string"></Archive:Operator>
          <Archive:Values xsi:nil="true"></Archive:Values>
          <Archive:DisplayValues xsi:nil="true"></Archive:DisplayValues>
          <Archive:ColumnInfo xsi:nil="true"></Archive:ColumnInfo>
          <Archive:IsActive xsi:nil="true"></Archive:IsActive>
          <Archive:SubRestrictions xsi:nil="true"></Archive:SubRestrictions>
          <Archive:InterParenthesis xsi:nil="true"></Archive:InterParenthesis>
          <Archive:InterOperator xsi:nil="true"></Archive:InterOperator>
          <Archive:UniqueHash xsi:nil="true"></Archive:UniqueHash>
         </Archive:ArchiveRestrictionInfo>
        </Archive:SubRestrictions>
        <Archive:InterParenthesis xsi:type="xsd:int">0</Archive:InterParenthesis>
        <Archive:InterOperator xsi:type="Archive:InterRestrictionOperator">None</Archive:InterOperator>
        <Archive:UniqueHash xsi:type="xsd:int">0</Archive:UniqueHash>
       </Archive:ArchiveRestrictionInfo>
      </Archive:SubRestrictions>
      <Archive:InterParenthesis xsi:type="xsd:int">0</Archive:InterParenthesis>
      <Archive:InterOperator xsi:type="Archive:InterRestrictionOperator">None</Archive:InterOperator>
      <Archive:UniqueHash xsi:type="xsd:int">0</Archive:UniqueHash>
     </Archive:ArchiveRestrictionInfo>
    </Archive:Restriction>
    <Archive:Entities xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Options xsi:type="xsd:string"></Archive:Options>
   </Archive:GetArchiveListByColumnsWithHeader>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListByColumnsWithHeader Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Archive:GetArchiveListByColumnsWithHeaderResponse>
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
  </Archive:GetArchiveListByColumnsWithHeaderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

