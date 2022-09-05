---
title: Services87.FindAgent.SaveRestrictionGroup SOAP
generated: 1
uid: Services87-Find-SaveRestrictionGroup
---

# Services87 Find SaveRestrictionGroup

SOAP request and response examples **Remote/Services87/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IFindAgent.SaveRestrictionGroup">SuperOffice.Services87.IFindAgent.SaveRestrictionGroup</see> method.

## SaveRestrictionGroup

Save an array of restrictions as a restriction group for later use as search criteria (including as dynamic selection and Find).

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictionGroup:** Information about a group of restrictions
* **context:** Optional context that can be used by FindProvider

**Returns:** This service call just saves the restrictions.


[WSDL file for Services87/Find](../Services87-Find.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveRestrictionGroup Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Find:ApplicationToken>1234567-1234-9876</Find:ApplicationToken>
  <Find:Credentials>
    <Find:Ticket>7T:1234abcxyzExample==</Find:Ticket>
  </Find:Credentials>
 <SOAP-ENV:Body>
   <Find:SaveRestrictionGroup>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
    <Find:RestrictionGroup xsi:type="Find:ArchiveRestrictionGroup">
     <Find:Name xsi:type="xsd:string"></Find:Name>
     <Find:Description xsi:type="xsd:string"></Find:Description>
     <Find:Rank xsi:type="xsd:short">0</Find:Rank>
     <Find:Restrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
      <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
       <Find:Name xsi:type="xsd:string"></Find:Name>
       <Find:Operator xsi:type="xsd:string"></Find:Operator>
       <Find:Values xsi:type="NetServerServices872:ArrayOfstring">
        <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
       </Find:Values>
       <Find:DisplayValues xsi:type="NetServerServices872:ArrayOfstring">
        <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
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
         <Find:Values xsi:type="NetServerServices872:ArrayOfstring">
          <NetServerServices872:string xsi:nil="true"></NetServerServices872:string>
         </Find:Values>
         <Find:DisplayValues xsi:type="NetServerServices872:ArrayOfstring">
          <NetServerServices872:string xsi:nil="true"></NetServerServices872:string>
         </Find:DisplayValues>
         <Find:ColumnInfo xsi:type="Find:ArchiveColumnInfo">
          <Find:DisplayName xsi:type="xsd:string"></Find:DisplayName>
          <Find:DisplayTooltip xsi:type="xsd:string"></Find:DisplayTooltip>
          <Find:DisplayType xsi:type="xsd:string"></Find:DisplayType>
          <Find:CanOrderBy xsi:nil="true"></Find:CanOrderBy>
          <Find:Name xsi:type="xsd:string"></Find:Name>
          <Find:CanRestrictBy xsi:nil="true"></Find:CanRestrictBy>
          <Find:RestrictionType xsi:type="xsd:string"></Find:RestrictionType>
          <Find:RestrictionListName xsi:type="xsd:string"></Find:RestrictionListName>
          <Find:IsVisible xsi:nil="true"></Find:IsVisible>
          <Find:Width xsi:type="xsd:string"></Find:Width>
          <Find:IconHint xsi:type="xsd:string"></Find:IconHint>
          <Find:HeadingIconHint xsi:type="xsd:string"></Find:HeadingIconHint>
         </Find:ColumnInfo>
         <Find:IsActive xsi:type="xsd:boolean">false</Find:IsActive>
         <Find:SubRestrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
          <Find:ArchiveRestrictionInfo xsi:nil="true"></Find:ArchiveRestrictionInfo>
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
    </Find:RestrictionGroup>
    <Find:Context xsi:type="xsd:string"></Find:Context>
   </Find:SaveRestrictionGroup>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveRestrictionGroup Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Find="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Find:SaveRestrictionGroupResponse>
  </Find:SaveRestrictionGroupResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

