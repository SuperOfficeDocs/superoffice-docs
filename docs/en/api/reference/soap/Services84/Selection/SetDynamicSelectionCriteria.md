---
title: Services84.SelectionAgent.SetDynamicSelectionCriteria SOAP
generated: 1
uid: Services84-Selection-SetDynamicSelectionCriteria
---

# Services84 Selection SetDynamicSelectionCriteria

SOAP request and response examples **Remote/Services84/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ISelectionAgent.SetDynamicSelectionCriteria">SuperOffice.Services84.ISelectionAgent.SetDynamicSelectionCriteria</see> method.

## SetDynamicSelectionCriteria

[WSDL file for Services84/Selection](../Services84-Selection.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDynamicSelectionCriteria Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:SetDynamicSelectionCriteria>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Criteria xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
     <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
      <Selection:Values xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Selection:Values>
      <Selection:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Selection:DisplayValues>
      <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
       <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
       <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
       <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
       <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
       <Selection:Name xsi:type="xsd:string"></Selection:Name>
       <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
       <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
       <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
       <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
       <Selection:Width xsi:type="xsd:string"></Selection:Width>
       <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
       <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
      </Selection:ColumnInfo>
      <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
      <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
       <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
        <Selection:Name xsi:type="xsd:string"></Selection:Name>
        <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
        <Selection:Values xsi:type="NetServerServices842:ArrayOfstring">
         <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
        </Selection:Values>
        <Selection:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
         <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
        </Selection:DisplayValues>
        <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
         <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
         <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
         <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
         <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
         <Selection:Name xsi:type="xsd:string"></Selection:Name>
         <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
         <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
         <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
         <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
         <Selection:Width xsi:type="xsd:string"></Selection:Width>
         <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
         <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
        </Selection:ColumnInfo>
        <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
        <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
         <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
          <Selection:Name xsi:type="xsd:string"></Selection:Name>
          <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
          <Selection:Values xsi:nil="true"></Selection:Values>
          <Selection:DisplayValues xsi:nil="true"></Selection:DisplayValues>
          <Selection:ColumnInfo xsi:nil="true"></Selection:ColumnInfo>
          <Selection:IsActive xsi:nil="true"></Selection:IsActive>
          <Selection:SubRestrictions xsi:nil="true"></Selection:SubRestrictions>
          <Selection:InterParenthesis xsi:nil="true"></Selection:InterParenthesis>
          <Selection:InterOperator xsi:nil="true"></Selection:InterOperator>
          <Selection:UniqueHash xsi:nil="true"></Selection:UniqueHash>
         </Selection:ArchiveRestrictionInfo>
        </Selection:SubRestrictions>
        <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
        <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
        <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
       </Selection:ArchiveRestrictionInfo>
      </Selection:SubRestrictions>
      <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
      <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
      <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
     </Selection:ArchiveRestrictionInfo>
    </Selection:Criteria>
   </Selection:SetDynamicSelectionCriteria>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SetDynamicSelectionCriteria Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Selection:SetDynamicSelectionCriteriaResponse>
   <Selection:Response xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
    <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
     <Selection:Values xsi:type="NetServerServices842:ArrayOfstring">
      <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
     </Selection:Values>
     <Selection:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
      <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
     </Selection:DisplayValues>
     <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
      <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
      <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
      <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
      <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
      <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
      <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
      <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
      <Selection:Width xsi:type="xsd:string"></Selection:Width>
      <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
      <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
     </Selection:ColumnInfo>
     <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
     <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
      <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
       <Selection:Name xsi:type="xsd:string"></Selection:Name>
       <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
       <Selection:Values xsi:type="NetServerServices842:ArrayOfstring">
        <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
       </Selection:Values>
       <Selection:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
        <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
       </Selection:DisplayValues>
       <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
        <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
        <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
        <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
        <Selection:CanOrderBy xsi:type="xsd:boolean">false</Selection:CanOrderBy>
        <Selection:Name xsi:type="xsd:string"></Selection:Name>
        <Selection:CanRestrictBy xsi:type="xsd:boolean">false</Selection:CanRestrictBy>
        <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
        <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
        <Selection:IsVisible xsi:type="xsd:boolean">false</Selection:IsVisible>
        <Selection:Width xsi:type="xsd:string"></Selection:Width>
        <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
        <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
       </Selection:ColumnInfo>
       <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
       <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
        <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
         <Selection:Name xsi:type="xsd:string"></Selection:Name>
         <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
         <Selection:Values xsi:type="NetServerServices842:ArrayOfstring">
          <NetServerServices842:string xsi:nil="true"></NetServerServices842:string>
         </Selection:Values>
         <Selection:DisplayValues xsi:type="NetServerServices842:ArrayOfstring">
          <NetServerServices842:string xsi:nil="true"></NetServerServices842:string>
         </Selection:DisplayValues>
         <Selection:ColumnInfo xsi:type="Selection:ArchiveColumnInfo">
          <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
          <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
          <Selection:DisplayType xsi:type="xsd:string"></Selection:DisplayType>
          <Selection:CanOrderBy xsi:nil="true"></Selection:CanOrderBy>
          <Selection:Name xsi:type="xsd:string"></Selection:Name>
          <Selection:CanRestrictBy xsi:nil="true"></Selection:CanRestrictBy>
          <Selection:RestrictionType xsi:type="xsd:string"></Selection:RestrictionType>
          <Selection:RestrictionListName xsi:type="xsd:string"></Selection:RestrictionListName>
          <Selection:IsVisible xsi:nil="true"></Selection:IsVisible>
          <Selection:Width xsi:type="xsd:string"></Selection:Width>
          <Selection:IconHint xsi:type="xsd:string"></Selection:IconHint>
          <Selection:HeadingIconHint xsi:type="xsd:string"></Selection:HeadingIconHint>
         </Selection:ColumnInfo>
         <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
         <Selection:SubRestrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
          <Selection:ArchiveRestrictionInfo xsi:nil="true"></Selection:ArchiveRestrictionInfo>
         </Selection:SubRestrictions>
         <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
         <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
         <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
        </Selection:ArchiveRestrictionInfo>
       </Selection:SubRestrictions>
       <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
       <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
       <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
      </Selection:ArchiveRestrictionInfo>
     </Selection:SubRestrictions>
     <Selection:InterParenthesis xsi:type="xsd:int">0</Selection:InterParenthesis>
     <Selection:InterOperator xsi:type="Selection:InterRestrictionOperator">None</Selection:InterOperator>
     <Selection:UniqueHash xsi:type="xsd:int">0</Selection:UniqueHash>
    </Selection:ArchiveRestrictionInfo>
   </Selection:Response>
  </Selection:SetDynamicSelectionCriteriaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
