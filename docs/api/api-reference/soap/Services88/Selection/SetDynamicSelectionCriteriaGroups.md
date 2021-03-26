---
uid: services88-selection-setdynamicselectioncriteriagroups
title: Services88.SelectionAgent.SetDynamicSelectionCriteriaGroups SOAP
Generated: true
---

# Services88 Selection SetDynamicSelectionCriteriaGroups SOAP

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.SetDynamicSelectionCriteriaGroups">SuperOffice.Services88.ISelectionAgent.SetDynamicSelectionCriteriaGroups</see> method.

## SetDynamicSelectionCriteriaGroups

Update the criteria for this dynamic selection. Replaces existing criteria with the new values. This call supports multiple criteria groups.

* **selectionId:** The id of the selection to add members
* **criteria:** Criteria groups defining the selection result. Empty array is legal, simply means no criteria have been set

**Returns:** Criteria groups defining the selection result. NULL if this is not a dynamic selection.


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDynamicSelectionCriteriaGroups Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:SetDynamicSelectionCriteriaGroups>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Criteria xsi:type="Selection:ArrayOfArchiveRestrictionGroup">
     <Selection:ArchiveRestrictionGroup xsi:type="Selection:ArchiveRestrictionGroup">
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:Description xsi:type="xsd:string"></Selection:Description>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Restrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
       <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
        <Selection:Name xsi:type="xsd:string"></Selection:Name>
        <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
        <Selection:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Selection:Values>
        <Selection:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
      </Selection:Restrictions>
     </Selection:ArchiveRestrictionGroup>
    </Selection:Criteria>
   </Selection:SetDynamicSelectionCriteriaGroups>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetDynamicSelectionCriteriaGroups Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:SetDynamicSelectionCriteriaGroupsResponse>
   <Selection:Response xsi:type="Selection:ArrayOfArchiveRestrictionGroup">
    <Selection:ArchiveRestrictionGroup xsi:type="Selection:ArchiveRestrictionGroup">
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:Description xsi:type="xsd:string"></Selection:Description>
     <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
     <Selection:Restrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
      <Selection:ArchiveRestrictionInfo xsi:type="Selection:ArchiveRestrictionInfo">
       <Selection:Name xsi:type="xsd:string"></Selection:Name>
       <Selection:Operator xsi:type="xsd:string"></Selection:Operator>
       <Selection:Values xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </Selection:Values>
       <Selection:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
         <Selection:Values xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </Selection:Values>
         <Selection:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
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
     </Selection:Restrictions>
    </Selection:ArchiveRestrictionGroup>
   </Selection:Response>
  </Selection:SetDynamicSelectionCriteriaGroupsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

