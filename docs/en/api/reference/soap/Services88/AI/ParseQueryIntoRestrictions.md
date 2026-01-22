---
title: Services88.AIAgent.ParseQueryIntoRestrictions SOAP
generated: true
uid: Services88-AI-ParseQueryIntoRestrictions
content_type: reference
---

# Services88 AI ParseQueryIntoRestrictions

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.ParseQueryIntoRestrictions">SuperOffice.Services88.IAIAgent.ParseQueryIntoRestrictions</see> method.

## ParseQueryIntoRestrictions





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ParseQueryIntoRestrictions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:ParseQueryIntoRestrictions>
    <AI:Query xsi:type="xsd:string"></AI:Query>
    <AI:Currents xsi:type="xsd:string"></AI:Currents>
    <AI:PreviousQuery xsi:type="AI:NaturalLanguageSearch">
     <AI:Query xsi:type="xsd:string"></AI:Query>
     <AI:ResponseMarkdown xsi:type="xsd:string"></AI:ResponseMarkdown>
     <AI:Entity xsi:type="xsd:string"></AI:Entity>
     <AI:ODataQuery xsi:type="xsd:string"></AI:ODataQuery>
     <AI:Restrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
      <AI:ArchiveRestrictionInfo xsi:type="AI:ArchiveRestrictionInfo">
       <AI:Name xsi:type="xsd:string"></AI:Name>
       <AI:Operator xsi:type="xsd:string"></AI:Operator>
       <AI:Values xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </AI:Values>
       <AI:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
        <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
       </AI:DisplayValues>
       <AI:ColumnInfo xsi:type="AI:ArchiveColumnInfo">
        <AI:DisplayName xsi:type="xsd:string"></AI:DisplayName>
        <AI:DisplayTooltip xsi:type="xsd:string"></AI:DisplayTooltip>
        <AI:DisplayType xsi:type="xsd:string"></AI:DisplayType>
        <AI:CanOrderBy xsi:type="xsd:boolean">false</AI:CanOrderBy>
        <AI:Name xsi:type="xsd:string"></AI:Name>
        <AI:CanRestrictBy xsi:type="xsd:boolean">false</AI:CanRestrictBy>
        <AI:RestrictionType xsi:type="xsd:string"></AI:RestrictionType>
        <AI:RestrictionListName xsi:type="xsd:string"></AI:RestrictionListName>
        <AI:IsVisible xsi:type="xsd:boolean">false</AI:IsVisible>
        <AI:Width xsi:type="xsd:string"></AI:Width>
        <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
        <AI:HeadingIconHint xsi:type="xsd:string"></AI:HeadingIconHint>
        <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
       </AI:ColumnInfo>
       <AI:IsActive xsi:type="xsd:boolean">false</AI:IsActive>
       <AI:SubRestrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
        <AI:ArchiveRestrictionInfo xsi:type="AI:ArchiveRestrictionInfo">
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:Operator xsi:type="xsd:string"></AI:Operator>
         <AI:Values xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </AI:Values>
         <AI:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
          <NetServerServices882:string xsi:nil="true"></NetServerServices882:string>
         </AI:DisplayValues>
         <AI:ColumnInfo xsi:type="AI:ArchiveColumnInfo">
          <AI:DisplayName xsi:type="xsd:string"></AI:DisplayName>
          <AI:DisplayTooltip xsi:type="xsd:string"></AI:DisplayTooltip>
          <AI:DisplayType xsi:type="xsd:string"></AI:DisplayType>
          <AI:CanOrderBy xsi:nil="true"></AI:CanOrderBy>
          <AI:Name xsi:type="xsd:string"></AI:Name>
          <AI:CanRestrictBy xsi:nil="true"></AI:CanRestrictBy>
          <AI:RestrictionType xsi:type="xsd:string"></AI:RestrictionType>
          <AI:RestrictionListName xsi:type="xsd:string"></AI:RestrictionListName>
          <AI:IsVisible xsi:nil="true"></AI:IsVisible>
          <AI:Width xsi:type="xsd:string"></AI:Width>
          <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
          <AI:HeadingIconHint xsi:type="xsd:string"></AI:HeadingIconHint>
          <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
         </AI:ColumnInfo>
         <AI:IsActive xsi:type="xsd:boolean">false</AI:IsActive>
         <AI:SubRestrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
          <AI:ArchiveRestrictionInfo xsi:nil="true"></AI:ArchiveRestrictionInfo>
         </AI:SubRestrictions>
         <AI:InterParenthesis xsi:type="xsd:int">0</AI:InterParenthesis>
         <AI:InterOperator xsi:type="AI:InterRestrictionOperator">None</AI:InterOperator>
         <AI:UniqueHash xsi:type="xsd:int">0</AI:UniqueHash>
        </AI:ArchiveRestrictionInfo>
       </AI:SubRestrictions>
       <AI:InterParenthesis xsi:type="xsd:int">0</AI:InterParenthesis>
       <AI:InterOperator xsi:type="AI:InterRestrictionOperator">None</AI:InterOperator>
       <AI:UniqueHash xsi:type="xsd:int">0</AI:UniqueHash>
      </AI:ArchiveRestrictionInfo>
     </AI:Restrictions>
     <AI:InternalContext xsi:type="xsd:string"></AI:InternalContext>
    </AI:PreviousQuery>
   </AI:ParseQueryIntoRestrictions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ParseQueryIntoRestrictions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:ParseQueryIntoRestrictionsResponse>
   <AI:Response xsi:type="AI:NaturalLanguageSearch">
    <AI:Query xsi:type="xsd:string"></AI:Query>
    <AI:ResponseMarkdown xsi:type="xsd:string"></AI:ResponseMarkdown>
    <AI:Entity xsi:type="xsd:string"></AI:Entity>
    <AI:ODataQuery xsi:type="xsd:string"></AI:ODataQuery>
    <AI:Restrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
     <AI:ArchiveRestrictionInfo xsi:type="AI:ArchiveRestrictionInfo">
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:Operator xsi:type="xsd:string"></AI:Operator>
      <AI:Values xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </AI:Values>
      <AI:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </AI:DisplayValues>
      <AI:ColumnInfo xsi:type="AI:ArchiveColumnInfo">
       <AI:DisplayName xsi:type="xsd:string"></AI:DisplayName>
       <AI:DisplayTooltip xsi:type="xsd:string"></AI:DisplayTooltip>
       <AI:DisplayType xsi:type="xsd:string"></AI:DisplayType>
       <AI:CanOrderBy xsi:type="xsd:boolean">false</AI:CanOrderBy>
       <AI:Name xsi:type="xsd:string"></AI:Name>
       <AI:CanRestrictBy xsi:type="xsd:boolean">false</AI:CanRestrictBy>
       <AI:RestrictionType xsi:type="xsd:string"></AI:RestrictionType>
       <AI:RestrictionListName xsi:type="xsd:string"></AI:RestrictionListName>
       <AI:IsVisible xsi:type="xsd:boolean">false</AI:IsVisible>
       <AI:Width xsi:type="xsd:string"></AI:Width>
       <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
       <AI:HeadingIconHint xsi:type="xsd:string"></AI:HeadingIconHint>
       <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
      </AI:ColumnInfo>
      <AI:IsActive xsi:type="xsd:boolean">false</AI:IsActive>
      <AI:SubRestrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
       <AI:ArchiveRestrictionInfo xsi:type="AI:ArchiveRestrictionInfo">
        <AI:Name xsi:type="xsd:string"></AI:Name>
        <AI:Operator xsi:type="xsd:string"></AI:Operator>
        <AI:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </AI:Values>
        <AI:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </AI:DisplayValues>
        <AI:ColumnInfo xsi:type="AI:ArchiveColumnInfo">
         <AI:DisplayName xsi:type="xsd:string"></AI:DisplayName>
         <AI:DisplayTooltip xsi:type="xsd:string"></AI:DisplayTooltip>
         <AI:DisplayType xsi:type="xsd:string"></AI:DisplayType>
         <AI:CanOrderBy xsi:type="xsd:boolean">false</AI:CanOrderBy>
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:CanRestrictBy xsi:type="xsd:boolean">false</AI:CanRestrictBy>
         <AI:RestrictionType xsi:type="xsd:string"></AI:RestrictionType>
         <AI:RestrictionListName xsi:type="xsd:string"></AI:RestrictionListName>
         <AI:IsVisible xsi:type="xsd:boolean">false</AI:IsVisible>
         <AI:Width xsi:type="xsd:string"></AI:Width>
         <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
         <AI:HeadingIconHint xsi:type="xsd:string"></AI:HeadingIconHint>
         <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
        </AI:ColumnInfo>
        <AI:IsActive xsi:type="xsd:boolean">false</AI:IsActive>
        <AI:SubRestrictions xsi:type="AI:ArrayOfArchiveRestrictionInfo">
         <AI:ArchiveRestrictionInfo xsi:type="AI:ArchiveRestrictionInfo">
          <AI:Name xsi:type="xsd:string"></AI:Name>
          <AI:Operator xsi:type="xsd:string"></AI:Operator>
          <AI:Values xsi:nil="true"></AI:Values>
          <AI:DisplayValues xsi:nil="true"></AI:DisplayValues>
          <AI:ColumnInfo xsi:nil="true"></AI:ColumnInfo>
          <AI:IsActive xsi:nil="true"></AI:IsActive>
          <AI:SubRestrictions xsi:nil="true"></AI:SubRestrictions>
          <AI:InterParenthesis xsi:nil="true"></AI:InterParenthesis>
          <AI:InterOperator xsi:nil="true"></AI:InterOperator>
          <AI:UniqueHash xsi:nil="true"></AI:UniqueHash>
         </AI:ArchiveRestrictionInfo>
        </AI:SubRestrictions>
        <AI:InterParenthesis xsi:type="xsd:int">0</AI:InterParenthesis>
        <AI:InterOperator xsi:type="AI:InterRestrictionOperator">None</AI:InterOperator>
        <AI:UniqueHash xsi:type="xsd:int">0</AI:UniqueHash>
       </AI:ArchiveRestrictionInfo>
      </AI:SubRestrictions>
      <AI:InterParenthesis xsi:type="xsd:int">0</AI:InterParenthesis>
      <AI:InterOperator xsi:type="AI:InterRestrictionOperator">None</AI:InterOperator>
      <AI:UniqueHash xsi:type="xsd:int">0</AI:UniqueHash>
     </AI:ArchiveRestrictionInfo>
    </AI:Restrictions>
    <AI:InternalContext xsi:type="xsd:string"></AI:InternalContext>
   </AI:Response>
  </AI:ParseQueryIntoRestrictionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

