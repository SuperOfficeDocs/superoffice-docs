---
title: Services84.FindAgent.FindFromRestrictionsColumns SOAP
generated: 1
uid: Services84-Find-FindFromRestrictionsColumns
---

# Services84 Find FindFromRestrictionsColumns

SOAP request and response examples **Remote/Services84/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IFindAgent.FindFromRestrictionsColumns">SuperOffice.Services84.IFindAgent.FindFromRestrictionsColumns</see> method.

## FindFromRestrictionsColumns

Execute a Find operation and return a page of results. &lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is calculated by the system.&lt;para/&gt;Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them.

* **restrictions:** Array of restrictions specifying the search. Each restriction must match a column of the  given archive provider, and that column must have its CanRestrictBy property set to true.
* **providerName:** Name of archive provider that is to execute the search and return the result columns/rows
* **desiredColumns:** Array of column names desired for the result. Each name must match a column offered by the given archive provider.
* **pageSize:** Size of result set pages
* **pageNumber:** Result set page to return, 0 is the first page. When a call returns no rows, no further pages are available. Negative page numbers are interpreted as number of rows to skip.

**Returns:** Results from search, containing column information and result rows.


[WSDL file for Services84/Find](../Services84-Find.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## FindFromRestrictionsColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:FindFromRestrictionsColumns>
    <Find:Restrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
     <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
      <Find:Name xsi:type="xsd:string"></Find:Name>
      <Find:Operator xsi:type="xsd:string"></Find:Operator>
      <Find:Values xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Find:Values>
      <Find:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Find:DisplayValues>
      <Find:ColumnInfo xsi:type="Find:ArchiveColumnInfo">
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
      </Find:ColumnInfo>
      <Find:IsActive xsi:type="xsd:boolean">false</Find:IsActive>
      <Find:SubRestrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
       <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
        <Find:Name xsi:type="xsd:string"></Find:Name>
        <Find:Operator xsi:type="xsd:string"></Find:Operator>
        <Find:Values xsi:type="NetServerServices842:ArrayOfstring">
         <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
        </Find:Values>
        <Find:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
         <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
        </Find:DisplayValues>
        <Find:ColumnInfo xsi:type="Find:ArchiveColumnInfo">
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
        </Find:ColumnInfo>
        <Find:IsActive xsi:type="xsd:boolean">false</Find:IsActive>
        <Find:SubRestrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
         <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
          <Find:Name xsi:type="xsd:string"></Find:Name>
          <Find:Operator xsi:type="xsd:string"></Find:Operator>
          <Find:Values xsi:nil="true"></Find:Values>
          <Find:DisplayValues xsi:nil="true"></Find:DisplayValues>
          <Find:ColumnInfo xsi:nil="true"></Find:ColumnInfo>
          <Find:IsActive xsi:nil="true"></Find:IsActive>
          <Find:SubRestrictions xsi:nil="true"></Find:SubRestrictions>
          <Find:InterParenthesis xsi:nil="true"></Find:InterParenthesis>
          <Find:InterOperator xsi:nil="true"></Find:InterOperator>
          <Find:UniqueHash xsi:nil="true"></Find:UniqueHash>
         </Find:ArchiveRestrictionInfo>
        </Find:SubRestrictions>
        <Find:InterParenthesis xsi:type="xsd:int">0</Find:InterParenthesis>
        <Find:InterOperator xsi:type="Find:InterRestrictionOperator">None</Find:InterOperator>
        <Find:UniqueHash xsi:type="xsd:int">0</Find:UniqueHash>
       </Find:ArchiveRestrictionInfo>
      </Find:SubRestrictions>
      <Find:InterParenthesis xsi:type="xsd:int">0</Find:InterParenthesis>
      <Find:InterOperator xsi:type="Find:InterRestrictionOperator">None</Find:InterOperator>
      <Find:UniqueHash xsi:type="xsd:int">0</Find:UniqueHash>
     </Find:ArchiveRestrictionInfo>
    </Find:Restrictions>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:DesiredColumns xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </Find:DesiredColumns>
    <Find:PageSize xsi:type="xsd:int">0</Find:PageSize>
    <Find:PageNumber xsi:type="xsd:int">0</Find:PageNumber>
   </Find:FindFromRestrictionsColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## FindFromRestrictionsColumns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Find:FindFromRestrictionsColumnsResponse>
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
  </Find:FindFromRestrictionsColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

