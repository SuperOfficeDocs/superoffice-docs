---
uid: services83-find-getdefaultdesiredcolumnsfromrestrictions
title: Services83.FindAgent.GetDefaultDesiredColumnsFromRestrictions SOAP
Generated: true
---

# Services83 Find GetDefaultDesiredColumnsFromRestrictions SOAP

SOAP request and response examples **Remote/Services83/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IFindAgent.GetDefaultDesiredColumnsFromRestrictions">SuperOffice.Services83.IFindAgent.GetDefaultDesiredColumnsFromRestrictions</see> method.

## GetDefaultDesiredColumnsFromRestrictions

Calculate the default desired columns, i.e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.

* **providerName:** Name of the provider to calculate default desired columns for
* **restrictions:** Restriction to use in the calculation of default desired columns

**Returns:** Column information for the default desired columns, fully populated. Percentage-specified column widths sum to exactly 100.


[WSDL file for Services83/Find](../Services83-Find.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDefaultDesiredColumnsFromRestrictions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:GetDefaultDesiredColumnsFromRestrictions>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:Restrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
     <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
      <Find:Name xsi:type="xsd:string"></Find:Name>
      <Find:Operator xsi:type="xsd:string"></Find:Operator>
      <Find:Values xsi:type="NetServerServices832:ArrayOfstring">
       <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
      </Find:Values>
      <Find:DisplayValues xsi:type="NetServerServices832:ArrayOfstring">
       <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
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
        <Find:Values xsi:type="NetServerServices832:ArrayOfstring">
         <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
        </Find:Values>
        <Find:DisplayValues xsi:type="NetServerServices832:ArrayOfstring">
         <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
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
   </Find:GetDefaultDesiredColumnsFromRestrictions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDefaultDesiredColumnsFromRestrictions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Find:GetDefaultDesiredColumnsFromRestrictionsResponse>
   <Find:Response xsi:type="Find:ArrayOfArchiveColumnInfo">
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
   </Find:Response>
  </Find:GetDefaultDesiredColumnsFromRestrictionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

