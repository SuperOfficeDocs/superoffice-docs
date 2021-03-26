---
uid: services86-archive-getarchivelistwithcontext
title: Services86.ArchiveAgent.GetArchiveListWithContext SOAP
Generated: true
---

# Services86 Archive GetArchiveListWithContext SOAP

SOAP request and response examples **Remote/Services86/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IArchiveAgent.GetArchiveListWithContext">SuperOffice.Services86.IArchiveAgent.GetArchiveListWithContext</see> method.

## GetArchiveListWithContext

Get a page of data for an archive, with context parameter. The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected.

* **guiName:** The GUI name of the archive list, used to retrieve the currently configured set of columns (otherwise manipulated using the ArchiveConfiguration service)
* **providerName:** The name of the archive provider to use; it will be created via the ArchiveProviderFactory from a plugin
* **sortOrder:** Sort order for the archive. Can be null, which indicates 'no particular order'
* **restriction:** Archive restrictions. Archives will generally throw an exception if no restrictions are set. Pass in an empty array if you really do not want restrictions, but remember that you may end up fetching the first page of millions of rows.
* **entities:** Which entities to include. Can be null, which indicates 'include all entities'
* **page:** Page number, page 0 is the first page. Negative page numbers are interpreted as number of rows to skip.
* **pageSize:** Page size, which should be kept reasonable (say, no more than 1000 rows at a time)
* **context:** Context parameter, url-encoded string context parameter for ArchiveProvider constructor

**Returns:** Array of archive list items, where each item represents one row of data (row level data + the requested columns)


[WSDL file for Services86/Archive](../Services86-Archive.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListWithContext Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:GetArchiveListWithContext>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
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
      <Archive:Values xsi:type="NetServerServices862:ArrayOfstring">
       <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
      </Archive:Values>
      <Archive:DisplayValues xsi:type="NetServerServices862:ArrayOfstring">
       <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
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
        <Archive:Values xsi:type="NetServerServices862:ArrayOfstring">
         <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
        </Archive:Values>
        <Archive:DisplayValues xsi:type="NetServerServices862:ArrayOfstring">
         <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
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
    <Archive:Entities xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetArchiveListWithContext>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListWithContext Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Archive:GetArchiveListWithContextResponse>
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
  </Archive:GetArchiveListWithContextResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

