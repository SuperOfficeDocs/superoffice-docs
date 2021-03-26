---
uid: services81-import-createerpimportdata
title: Services81.ImportAgent.CreateErpImportData SOAP
Generated: true
---

# Services81 Import CreateErpImportData SOAP

SOAP request and response examples **Remote/Services81/Import.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IImportAgent.CreateErpImportData">SuperOffice.Services81.IImportAgent.CreateErpImportData</see> method.

## CreateErpImportData

Populates the ImportLines and columnDefs basedfrom erp system

* **restriction:** Archive restrictions.
* **columns:** Columns.
* **connectionId:** Connection id for Erp system
* **erpActorType:** Erp Actor type

**Returns:** The ImportLines and ColumnDefs


[WSDL file for Services81/Import](../Services81-Import.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateErpImportData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Import:ApplicationToken>1234567-1234-9876</Import:ApplicationToken>
  <Import:Credentials>
    <Import:Ticket>7T:1234abcxyzExample==</Import:Ticket>
  </Import:Credentials>
 <SOAP-ENV:Body>
   <Import:CreateErpImportData>
    <Import:Restriction xsi:type="Import:ArrayOfArchiveRestrictionInfo">
     <Import:ArchiveRestrictionInfo xsi:type="Import:ArchiveRestrictionInfo">
      <Import:Name xsi:type="xsd:string"></Import:Name>
      <Import:Operator xsi:type="xsd:string"></Import:Operator>
      <Import:Values xsi:type="NetServerServices812:ArrayOfstring">
       <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
      </Import:Values>
      <Import:DisplayValues xsi:type="NetServerServices812:ArrayOfstring">
       <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
      </Import:DisplayValues>
      <Import:ColumnInfo xsi:type="Import:ArchiveColumnInfo">
       <Import:DisplayName xsi:type="xsd:string"></Import:DisplayName>
       <Import:DisplayTooltip xsi:type="xsd:string"></Import:DisplayTooltip>
       <Import:DisplayType xsi:type="xsd:string"></Import:DisplayType>
       <Import:CanOrderBy xsi:type="xsd:boolean">false</Import:CanOrderBy>
       <Import:Name xsi:type="xsd:string"></Import:Name>
       <Import:CanRestrictBy xsi:type="xsd:boolean">false</Import:CanRestrictBy>
       <Import:RestrictionType xsi:type="xsd:string"></Import:RestrictionType>
       <Import:RestrictionListName xsi:type="xsd:string"></Import:RestrictionListName>
       <Import:IsVisible xsi:type="xsd:boolean">false</Import:IsVisible>
       <Import:Width xsi:type="xsd:string"></Import:Width>
       <Import:IconHint xsi:type="xsd:string"></Import:IconHint>
       <Import:HeadingIconHint xsi:type="xsd:string"></Import:HeadingIconHint>
      </Import:ColumnInfo>
      <Import:IsActive xsi:type="xsd:boolean">false</Import:IsActive>
      <Import:SubRestrictions xsi:type="Import:ArrayOfArchiveRestrictionInfo">
       <Import:ArchiveRestrictionInfo xsi:type="Import:ArchiveRestrictionInfo">
        <Import:Name xsi:type="xsd:string"></Import:Name>
        <Import:Operator xsi:type="xsd:string"></Import:Operator>
        <Import:Values xsi:type="NetServerServices812:ArrayOfstring">
         <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
        </Import:Values>
        <Import:DisplayValues xsi:type="NetServerServices812:ArrayOfstring">
         <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
        </Import:DisplayValues>
        <Import:ColumnInfo xsi:type="Import:ArchiveColumnInfo">
         <Import:DisplayName xsi:type="xsd:string"></Import:DisplayName>
         <Import:DisplayTooltip xsi:type="xsd:string"></Import:DisplayTooltip>
         <Import:DisplayType xsi:type="xsd:string"></Import:DisplayType>
         <Import:CanOrderBy xsi:type="xsd:boolean">false</Import:CanOrderBy>
         <Import:Name xsi:type="xsd:string"></Import:Name>
         <Import:CanRestrictBy xsi:type="xsd:boolean">false</Import:CanRestrictBy>
         <Import:RestrictionType xsi:type="xsd:string"></Import:RestrictionType>
         <Import:RestrictionListName xsi:type="xsd:string"></Import:RestrictionListName>
         <Import:IsVisible xsi:type="xsd:boolean">false</Import:IsVisible>
         <Import:Width xsi:type="xsd:string"></Import:Width>
         <Import:IconHint xsi:type="xsd:string"></Import:IconHint>
         <Import:HeadingIconHint xsi:type="xsd:string"></Import:HeadingIconHint>
        </Import:ColumnInfo>
        <Import:IsActive xsi:type="xsd:boolean">false</Import:IsActive>
        <Import:SubRestrictions xsi:type="Import:ArrayOfArchiveRestrictionInfo">
         <Import:ArchiveRestrictionInfo xsi:type="Import:ArchiveRestrictionInfo">
          <Import:Name xsi:type="xsd:string"></Import:Name>
          <Import:Operator xsi:type="xsd:string"></Import:Operator>
          <Import:Values xsi:nil="true"></Import:Values>
          <Import:DisplayValues xsi:nil="true"></Import:DisplayValues>
          <Import:ColumnInfo xsi:nil="true"></Import:ColumnInfo>
          <Import:IsActive xsi:nil="true"></Import:IsActive>
          <Import:SubRestrictions xsi:nil="true"></Import:SubRestrictions>
          <Import:InterParenthesis xsi:nil="true"></Import:InterParenthesis>
          <Import:InterOperator xsi:nil="true"></Import:InterOperator>
          <Import:UniqueHash xsi:nil="true"></Import:UniqueHash>
         </Import:ArchiveRestrictionInfo>
        </Import:SubRestrictions>
        <Import:InterParenthesis xsi:type="xsd:int">0</Import:InterParenthesis>
        <Import:InterOperator xsi:type="Import:InterRestrictionOperator">None</Import:InterOperator>
        <Import:UniqueHash xsi:type="xsd:int">0</Import:UniqueHash>
       </Import:ArchiveRestrictionInfo>
      </Import:SubRestrictions>
      <Import:InterParenthesis xsi:type="xsd:int">0</Import:InterParenthesis>
      <Import:InterOperator xsi:type="Import:InterRestrictionOperator">None</Import:InterOperator>
      <Import:UniqueHash xsi:type="xsd:int">0</Import:UniqueHash>
     </Import:ArchiveRestrictionInfo>
    </Import:Restriction>
    <Import:Columns xsi:type="NetServerServices812:ArrayOfstring">
     <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
    </Import:Columns>
    <Import:ConnectionId xsi:type="xsd:int">0</Import:ConnectionId>
    <Import:ErpActorType xsi:type="Import:ErpActorType">Unknown</Import:ErpActorType>
   </Import:CreateErpImportData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateErpImportData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Import:CreateErpImportDataResponse>
   <Import:Response xsi:type="Import:ImportErpData">
    <Import:ImportLines xsi:type="Import:ArrayOfImportLine">
     <Import:ImportLine xsi:type="Import:ImportLine">
      <Import:Values xsi:type="NetServerServices812:ArrayOfstring">
       <NetServerServices812:string xsi:type="xsd:string"></NetServerServices812:string>
      </Import:Values>
      <Import:Selected xsi:type="xsd:boolean">false</Import:Selected>
      <Import:Operation xsi:type="Import:ImportAction">PersonAdded</Import:Operation>
      <Import:Type xsi:type="Import:ImportEntityType">Person</Import:Type>
      <Import:ExternalKey xsi:type="xsd:string"></Import:ExternalKey>
     </Import:ImportLine>
    </Import:ImportLines>
    <Import:ColumnInfos xsi:type="Import:ArrayOfImportColumnInfo">
     <Import:ImportColumnInfo xsi:type="Import:ImportColumnInfo">
      <Import:Name xsi:type="xsd:string"></Import:Name>
      <Import:DisplayName xsi:type="xsd:string"></Import:DisplayName>
      <Import:Locked xsi:type="xsd:boolean">false</Import:Locked>
     </Import:ImportColumnInfo>
    </Import:ColumnInfos>
   </Import:Response>
  </Import:CreateErpImportDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

