---
title: Services88.DashAgent.SaveDashQuickFilters SOAP
generated: true
uid: Services88-Dash-SaveDashQuickFilters
content_type: reference
---

# Services88 Dash SaveDashQuickFilters

SOAP request and response examples **Remote/Services88/Dash.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDashAgent.SaveDashQuickFilters">SuperOffice.Services88.IDashAgent.SaveDashQuickFilters</see> method.

## SaveDashQuickFilters





[WSDL file for Services88/Dash](../Services88-Dash.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDashQuickFilters Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dash="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Dash:ApplicationToken>1234567-1234-9876</Dash:ApplicationToken>
  <Dash:Credentials>
    <Dash:Ticket>7T:1234abcxyzExample==</Dash:Ticket>
  </Dash:Credentials>
 <SOAP-ENV:Body>
   <Dash:SaveDashQuickFilters>
    <Dash:DashboardId xsi:type="xsd:int">0</Dash:DashboardId>
    <Dash:QuickFilters xsi:type="Dash:ArrayOfQuickFilterInfo">
     <Dash:QuickFilterInfo xsi:type="Dash:QuickFilterInfo">
      <Dash:Restriction xsi:type="Dash:ArchiveRestrictionInfo">
       <Dash:Name xsi:type="xsd:string"></Dash:Name>
       <Dash:Operator xsi:type="xsd:string"></Dash:Operator>
       <Dash:Values xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </Dash:Values>
       <Dash:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </Dash:DisplayValues>
       <Dash:ColumnInfo xsi:type="Dash:ArchiveColumnInfo">
        <Dash:DisplayName xsi:type="xsd:string"></Dash:DisplayName>
        <Dash:DisplayTooltip xsi:type="xsd:string"></Dash:DisplayTooltip>
        <Dash:DisplayType xsi:type="xsd:string"></Dash:DisplayType>
        <Dash:CanOrderBy xsi:type="xsd:boolean">false</Dash:CanOrderBy>
        <Dash:Name xsi:type="xsd:string"></Dash:Name>
        <Dash:CanRestrictBy xsi:type="xsd:boolean">false</Dash:CanRestrictBy>
        <Dash:RestrictionType xsi:type="xsd:string"></Dash:RestrictionType>
        <Dash:RestrictionListName xsi:type="xsd:string"></Dash:RestrictionListName>
        <Dash:IsVisible xsi:type="xsd:boolean">false</Dash:IsVisible>
        <Dash:Width xsi:type="xsd:string"></Dash:Width>
        <Dash:IconHint xsi:type="xsd:string"></Dash:IconHint>
        <Dash:HeadingIconHint xsi:type="xsd:string"></Dash:HeadingIconHint>
        <Dash:ExtraInfo xsi:type="xsd:string"></Dash:ExtraInfo>
       </Dash:ColumnInfo>
       <Dash:IsActive xsi:type="xsd:boolean">false</Dash:IsActive>
       <Dash:SubRestrictions xsi:type="Dash:ArrayOfArchiveRestrictionInfo">
        <Dash:ArchiveRestrictionInfo xsi:type="Dash:ArchiveRestrictionInfo">
         <Dash:Name xsi:type="xsd:string"></Dash:Name>
         <Dash:Operator xsi:type="xsd:string"></Dash:Operator>
         <Dash:Values xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </Dash:Values>
         <Dash:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </Dash:DisplayValues>
         <Dash:ColumnInfo xsi:type="Dash:ArchiveColumnInfo">
          <Dash:DisplayName xsi:type="xsd:string"></Dash:DisplayName>
          <Dash:DisplayTooltip xsi:type="xsd:string"></Dash:DisplayTooltip>
          <Dash:DisplayType xsi:type="xsd:string"></Dash:DisplayType>
          <Dash:CanOrderBy xsi:nil="true"></Dash:CanOrderBy>
          <Dash:Name xsi:type="xsd:string"></Dash:Name>
          <Dash:CanRestrictBy xsi:nil="true"></Dash:CanRestrictBy>
          <Dash:RestrictionType xsi:type="xsd:string"></Dash:RestrictionType>
          <Dash:RestrictionListName xsi:type="xsd:string"></Dash:RestrictionListName>
          <Dash:IsVisible xsi:nil="true"></Dash:IsVisible>
          <Dash:Width xsi:type="xsd:string"></Dash:Width>
          <Dash:IconHint xsi:type="xsd:string"></Dash:IconHint>
          <Dash:HeadingIconHint xsi:type="xsd:string"></Dash:HeadingIconHint>
          <Dash:ExtraInfo xsi:type="xsd:string"></Dash:ExtraInfo>
         </Dash:ColumnInfo>
         <Dash:IsActive xsi:type="xsd:boolean">false</Dash:IsActive>
         <Dash:SubRestrictions xsi:type="Dash:ArrayOfArchiveRestrictionInfo">
          <Dash:ArchiveRestrictionInfo xsi:nil="true"></Dash:ArchiveRestrictionInfo>
         </Dash:SubRestrictions>
         <Dash:InterParenthesis xsi:type="xsd:int">0</Dash:InterParenthesis>
         <Dash:InterOperator xsi:type="Dash:InterRestrictionOperator">None</Dash:InterOperator>
         <Dash:UniqueHash xsi:type="xsd:int">0</Dash:UniqueHash>
        </Dash:ArchiveRestrictionInfo>
       </Dash:SubRestrictions>
       <Dash:InterParenthesis xsi:type="xsd:int">0</Dash:InterParenthesis>
       <Dash:InterOperator xsi:type="Dash:InterRestrictionOperator">None</Dash:InterOperator>
       <Dash:UniqueHash xsi:type="xsd:int">0</Dash:UniqueHash>
      </Dash:Restriction>
      <Dash:Provider xsi:type="xsd:string"></Dash:Provider>
      <Dash:DashboardId xsi:type="xsd:int">0</Dash:DashboardId>
     </Dash:QuickFilterInfo>
    </Dash:QuickFilters>
   </Dash:SaveDashQuickFilters>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDashQuickFilters Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Dash="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Dash:SaveDashQuickFiltersResponse>
   <Dash:Response xsi:type="Dash:ArrayOfQuickFilterInfo">
    <Dash:QuickFilterInfo xsi:type="Dash:QuickFilterInfo">
     <Dash:Restriction xsi:type="Dash:ArchiveRestrictionInfo">
      <Dash:Name xsi:type="xsd:string"></Dash:Name>
      <Dash:Operator xsi:type="xsd:string"></Dash:Operator>
      <Dash:Values xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Dash:Values>
      <Dash:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Dash:DisplayValues>
      <Dash:ColumnInfo xsi:type="Dash:ArchiveColumnInfo">
       <Dash:DisplayName xsi:type="xsd:string"></Dash:DisplayName>
       <Dash:DisplayTooltip xsi:type="xsd:string"></Dash:DisplayTooltip>
       <Dash:DisplayType xsi:type="xsd:string"></Dash:DisplayType>
       <Dash:CanOrderBy xsi:type="xsd:boolean">false</Dash:CanOrderBy>
       <Dash:Name xsi:type="xsd:string"></Dash:Name>
       <Dash:CanRestrictBy xsi:type="xsd:boolean">false</Dash:CanRestrictBy>
       <Dash:RestrictionType xsi:type="xsd:string"></Dash:RestrictionType>
       <Dash:RestrictionListName xsi:type="xsd:string"></Dash:RestrictionListName>
       <Dash:IsVisible xsi:type="xsd:boolean">false</Dash:IsVisible>
       <Dash:Width xsi:type="xsd:string"></Dash:Width>
       <Dash:IconHint xsi:type="xsd:string"></Dash:IconHint>
       <Dash:HeadingIconHint xsi:type="xsd:string"></Dash:HeadingIconHint>
       <Dash:ExtraInfo xsi:type="xsd:string"></Dash:ExtraInfo>
      </Dash:ColumnInfo>
      <Dash:IsActive xsi:type="xsd:boolean">false</Dash:IsActive>
      <Dash:SubRestrictions xsi:type="Dash:ArrayOfArchiveRestrictionInfo">
       <Dash:ArchiveRestrictionInfo xsi:type="Dash:ArchiveRestrictionInfo">
        <Dash:Name xsi:type="xsd:string"></Dash:Name>
        <Dash:Operator xsi:type="xsd:string"></Dash:Operator>
        <Dash:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Dash:Values>
        <Dash:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Dash:DisplayValues>
        <Dash:ColumnInfo xsi:type="Dash:ArchiveColumnInfo">
         <Dash:DisplayName xsi:type="xsd:string"></Dash:DisplayName>
         <Dash:DisplayTooltip xsi:type="xsd:string"></Dash:DisplayTooltip>
         <Dash:DisplayType xsi:type="xsd:string"></Dash:DisplayType>
         <Dash:CanOrderBy xsi:type="xsd:boolean">false</Dash:CanOrderBy>
         <Dash:Name xsi:type="xsd:string"></Dash:Name>
         <Dash:CanRestrictBy xsi:type="xsd:boolean">false</Dash:CanRestrictBy>
         <Dash:RestrictionType xsi:type="xsd:string"></Dash:RestrictionType>
         <Dash:RestrictionListName xsi:type="xsd:string"></Dash:RestrictionListName>
         <Dash:IsVisible xsi:type="xsd:boolean">false</Dash:IsVisible>
         <Dash:Width xsi:type="xsd:string"></Dash:Width>
         <Dash:IconHint xsi:type="xsd:string"></Dash:IconHint>
         <Dash:HeadingIconHint xsi:type="xsd:string"></Dash:HeadingIconHint>
         <Dash:ExtraInfo xsi:type="xsd:string"></Dash:ExtraInfo>
        </Dash:ColumnInfo>
        <Dash:IsActive xsi:type="xsd:boolean">false</Dash:IsActive>
        <Dash:SubRestrictions xsi:type="Dash:ArrayOfArchiveRestrictionInfo">
         <Dash:ArchiveRestrictionInfo xsi:type="Dash:ArchiveRestrictionInfo">
          <Dash:Name xsi:type="xsd:string"></Dash:Name>
          <Dash:Operator xsi:type="xsd:string"></Dash:Operator>
          <Dash:Values xsi:nil="true"></Dash:Values>
          <Dash:DisplayValues xsi:nil="true"></Dash:DisplayValues>
          <Dash:ColumnInfo xsi:nil="true"></Dash:ColumnInfo>
          <Dash:IsActive xsi:nil="true"></Dash:IsActive>
          <Dash:SubRestrictions xsi:nil="true"></Dash:SubRestrictions>
          <Dash:InterParenthesis xsi:nil="true"></Dash:InterParenthesis>
          <Dash:InterOperator xsi:nil="true"></Dash:InterOperator>
          <Dash:UniqueHash xsi:nil="true"></Dash:UniqueHash>
         </Dash:ArchiveRestrictionInfo>
        </Dash:SubRestrictions>
        <Dash:InterParenthesis xsi:type="xsd:int">0</Dash:InterParenthesis>
        <Dash:InterOperator xsi:type="Dash:InterRestrictionOperator">None</Dash:InterOperator>
        <Dash:UniqueHash xsi:type="xsd:int">0</Dash:UniqueHash>
       </Dash:ArchiveRestrictionInfo>
      </Dash:SubRestrictions>
      <Dash:InterParenthesis xsi:type="xsd:int">0</Dash:InterParenthesis>
      <Dash:InterOperator xsi:type="Dash:InterRestrictionOperator">None</Dash:InterOperator>
      <Dash:UniqueHash xsi:type="xsd:int">0</Dash:UniqueHash>
     </Dash:Restriction>
     <Dash:Provider xsi:type="xsd:string"></Dash:Provider>
     <Dash:DashboardId xsi:type="xsd:int">0</Dash:DashboardId>
    </Dash:QuickFilterInfo>
   </Dash:Response>
  </Dash:SaveDashQuickFiltersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

