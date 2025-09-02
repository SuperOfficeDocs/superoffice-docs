---
title: Services88.TicketAgent.UpdateTicketsReadStatusByProvider SOAP
generated: true
uid: Services88-Ticket-UpdateTicketsReadStatusByProvider
content_type: reference
---

# Services88 Ticket UpdateTicketsReadStatusByProvider

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.UpdateTicketsReadStatusByProvider">SuperOffice.Services88.ITicketAgent.UpdateTicketsReadStatusByProvider</see> method.

## UpdateTicketsReadStatusByProvider





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateTicketsReadStatusByProvider Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:UpdateTicketsReadStatusByProvider>
    <Ticket:Provider xsi:type="xsd:string"></Ticket:Provider>
    <Ticket:Restrictions xsi:type="Ticket:ArrayOfArchiveRestrictionInfo">
     <Ticket:ArchiveRestrictionInfo xsi:type="Ticket:ArchiveRestrictionInfo">
      <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
      <Ticket:Operator xsi:type="xsd:string"></Ticket:Operator>
      <Ticket:Values xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Ticket:Values>
      <Ticket:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Ticket:DisplayValues>
      <Ticket:ColumnInfo xsi:type="Ticket:ArchiveColumnInfo">
       <Ticket:DisplayName xsi:type="xsd:string"></Ticket:DisplayName>
       <Ticket:DisplayTooltip xsi:type="xsd:string"></Ticket:DisplayTooltip>
       <Ticket:DisplayType xsi:type="xsd:string"></Ticket:DisplayType>
       <Ticket:CanOrderBy xsi:type="xsd:boolean">false</Ticket:CanOrderBy>
       <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
       <Ticket:CanRestrictBy xsi:type="xsd:boolean">false</Ticket:CanRestrictBy>
       <Ticket:RestrictionType xsi:type="xsd:string"></Ticket:RestrictionType>
       <Ticket:RestrictionListName xsi:type="xsd:string"></Ticket:RestrictionListName>
       <Ticket:IsVisible xsi:type="xsd:boolean">false</Ticket:IsVisible>
       <Ticket:Width xsi:type="xsd:string"></Ticket:Width>
       <Ticket:IconHint xsi:type="xsd:string"></Ticket:IconHint>
       <Ticket:HeadingIconHint xsi:type="xsd:string"></Ticket:HeadingIconHint>
       <Ticket:ExtraInfo xsi:type="xsd:string"></Ticket:ExtraInfo>
      </Ticket:ColumnInfo>
      <Ticket:IsActive xsi:type="xsd:boolean">false</Ticket:IsActive>
      <Ticket:SubRestrictions xsi:type="Ticket:ArrayOfArchiveRestrictionInfo">
       <Ticket:ArchiveRestrictionInfo xsi:type="Ticket:ArchiveRestrictionInfo">
        <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
        <Ticket:Operator xsi:type="xsd:string"></Ticket:Operator>
        <Ticket:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Ticket:Values>
        <Ticket:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Ticket:DisplayValues>
        <Ticket:ColumnInfo xsi:type="Ticket:ArchiveColumnInfo">
         <Ticket:DisplayName xsi:type="xsd:string"></Ticket:DisplayName>
         <Ticket:DisplayTooltip xsi:type="xsd:string"></Ticket:DisplayTooltip>
         <Ticket:DisplayType xsi:type="xsd:string"></Ticket:DisplayType>
         <Ticket:CanOrderBy xsi:type="xsd:boolean">false</Ticket:CanOrderBy>
         <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
         <Ticket:CanRestrictBy xsi:type="xsd:boolean">false</Ticket:CanRestrictBy>
         <Ticket:RestrictionType xsi:type="xsd:string"></Ticket:RestrictionType>
         <Ticket:RestrictionListName xsi:type="xsd:string"></Ticket:RestrictionListName>
         <Ticket:IsVisible xsi:type="xsd:boolean">false</Ticket:IsVisible>
         <Ticket:Width xsi:type="xsd:string"></Ticket:Width>
         <Ticket:IconHint xsi:type="xsd:string"></Ticket:IconHint>
         <Ticket:HeadingIconHint xsi:type="xsd:string"></Ticket:HeadingIconHint>
         <Ticket:ExtraInfo xsi:type="xsd:string"></Ticket:ExtraInfo>
        </Ticket:ColumnInfo>
        <Ticket:IsActive xsi:type="xsd:boolean">false</Ticket:IsActive>
        <Ticket:SubRestrictions xsi:type="Ticket:ArrayOfArchiveRestrictionInfo">
         <Ticket:ArchiveRestrictionInfo xsi:type="Ticket:ArchiveRestrictionInfo">
          <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
          <Ticket:Operator xsi:type="xsd:string"></Ticket:Operator>
          <Ticket:Values xsi:nil="true"></Ticket:Values>
          <Ticket:DisplayValues xsi:nil="true"></Ticket:DisplayValues>
          <Ticket:ColumnInfo xsi:nil="true"></Ticket:ColumnInfo>
          <Ticket:IsActive xsi:nil="true"></Ticket:IsActive>
          <Ticket:SubRestrictions xsi:nil="true"></Ticket:SubRestrictions>
          <Ticket:InterParenthesis xsi:nil="true"></Ticket:InterParenthesis>
          <Ticket:InterOperator xsi:nil="true"></Ticket:InterOperator>
          <Ticket:UniqueHash xsi:nil="true"></Ticket:UniqueHash>
         </Ticket:ArchiveRestrictionInfo>
        </Ticket:SubRestrictions>
        <Ticket:InterParenthesis xsi:type="xsd:int">0</Ticket:InterParenthesis>
        <Ticket:InterOperator xsi:type="Ticket:InterRestrictionOperator">None</Ticket:InterOperator>
        <Ticket:UniqueHash xsi:type="xsd:int">0</Ticket:UniqueHash>
       </Ticket:ArchiveRestrictionInfo>
      </Ticket:SubRestrictions>
      <Ticket:InterParenthesis xsi:type="xsd:int">0</Ticket:InterParenthesis>
      <Ticket:InterOperator xsi:type="Ticket:InterRestrictionOperator">None</Ticket:InterOperator>
      <Ticket:UniqueHash xsi:type="xsd:int">0</Ticket:UniqueHash>
     </Ticket:ArchiveRestrictionInfo>
    </Ticket:Restrictions>
    <Ticket:NewStatus xsi:type="Ticket:TicketReadStatus">Unknown</Ticket:NewStatus>
   </Ticket:UpdateTicketsReadStatusByProvider>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateTicketsReadStatusByProvider Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Ticket:UpdateTicketsReadStatusByProviderResponse>
   <Ticket:Response xsi:type="NetServerServices882:ArrayOfint">
    <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
   </Ticket:Response>
  </Ticket:UpdateTicketsReadStatusByProviderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

