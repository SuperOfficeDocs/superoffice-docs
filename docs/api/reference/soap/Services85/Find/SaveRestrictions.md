---
title: Services85.FindAgent.SaveRestrictions SOAP
generated: 1
uid: Services85-Find-SaveRestrictions
---

# Services85 Find SaveRestrictions

SOAP request and response examples **Remote/Services85/Find.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IFindAgent.SaveRestrictions">SuperOffice.Services85.IFindAgent.SaveRestrictions</see> method.

## SaveRestrictions

Save an array of restrictions for later use as search criteria (including as dynamic selection and Find).

* **storageType:** Restriction storage type specification, either 'Criteria' or 'Reporter' (or possible extensions)
* **providerName:** Name of archive provider that is the intended consumer of the restrictions
* **storageKey:** Storage key to be interpreted by the restriction storage provider, when it saves the restrictions as criteria
* **restrictions:** Array of restrictions. The ColumnInfo member and the DisplayValues members need NOT be populated; it is enough to provide a name, operator and any values the operator may need. The IsActive is also saved. Values should be encoded using the CultureDataFormatter to ensure compatibility across cultures.

**Returns:** This service call just saves the restrictions. See SaveRestrictionsAndGetCriteriaInformation if you would like the restrictions returned as criteria immediately, in one roundtrip


[WSDL file for Services85/Find](../Services85-Find.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveRestrictions Request

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
   <Find:SaveRestrictions>
    <Find:StorageType xsi:type="xsd:string"></Find:StorageType>
    <Find:ProviderName xsi:type="xsd:string"></Find:ProviderName>
    <Find:StorageKey xsi:type="xsd:string"></Find:StorageKey>
    <Find:Restrictions xsi:type="Find:ArrayOfArchiveRestrictionInfo">
     <Find:ArchiveRestrictionInfo xsi:type="Find:ArchiveRestrictionInfo">
      <Find:Name xsi:type="xsd:string"></Find:Name>
      <Find:Operator xsi:type="xsd:string"></Find:Operator>
      <Find:Values xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
      </Find:Values>
      <Find:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
        <Find:Values xsi:type="NetServerServices852:ArrayOfstring">
         <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
        </Find:Values>
        <Find:DisplayValues xsi:type="NetServerServices852:ArrayOfstring">
         <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
   </Find:SaveRestrictions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveRestrictions Response

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
  <Find:SaveRestrictionsResponse>
  </Find:SaveRestrictionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

