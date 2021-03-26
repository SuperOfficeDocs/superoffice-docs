---
uid: services80-archive-getarchivelistbycolumnswithcontext
title: Services80.ArchiveAgent.GetArchiveListByColumnsWithContext SOAP
Generated: true
---

# Services80 Archive GetArchiveListByColumnsWithContext SOAP

SOAP request and response examples **Remote/Services80/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IArchiveAgent.GetArchiveListByColumnsWithContext">SuperOffice.Services80.IArchiveAgent.GetArchiveListByColumnsWithContext</see> method.

## GetArchiveListByColumnsWithContext





[WSDL file for Services80/Archive](../Services80-Archive.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetArchiveListByColumnsWithContext Request

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
   <Archive:GetArchiveListByColumnsWithContext>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Columns xsi:type="NetServerServices802:ArrayOfstring">
     <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
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
      <Archive:Values xsi:type="NetServerServices802:ArrayOfstring">
       <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
      </Archive:Values>
      <Archive:DisplayValues xsi:type="NetServerServices802:ArrayOfstring">
       <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
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
        <Archive:Values xsi:type="NetServerServices802:ArrayOfstring">
         <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
        </Archive:Values>
        <Archive:DisplayValues xsi:type="NetServerServices802:ArrayOfstring">
         <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
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
    <Archive:Entities xsi:type="NetServerServices802:ArrayOfstring">
     <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
    </Archive:Entities>
    <Archive:Page xsi:type="xsd:int">0</Archive:Page>
    <Archive:PageSize xsi:type="xsd:int">0</Archive:PageSize>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
   </Archive:GetArchiveListByColumnsWithContext>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetArchiveListByColumnsWithContext Response

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
  <Archive:GetArchiveListByColumnsWithContextResponse>
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
  </Archive:GetArchiveListByColumnsWithContextResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

