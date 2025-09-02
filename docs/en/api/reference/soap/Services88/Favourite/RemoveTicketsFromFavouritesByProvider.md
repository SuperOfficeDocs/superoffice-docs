---
title: Services88.FavouriteAgent.RemoveTicketsFromFavouritesByProvider SOAP
generated: true
uid: Services88-Favourite-RemoveTicketsFromFavouritesByProvider
content_type: reference
---

# Services88 Favourite RemoveTicketsFromFavouritesByProvider

SOAP request and response examples **Remote/Services88/Favourite.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IFavouriteAgent.RemoveTicketsFromFavouritesByProvider">SuperOffice.Services88.IFavouriteAgent.RemoveTicketsFromFavouritesByProvider</see> method.

## RemoveTicketsFromFavouritesByProvider





[WSDL file for Services88/Favourite](../Services88-Favourite.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveTicketsFromFavouritesByProvider Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Favourite:ApplicationToken>1234567-1234-9876</Favourite:ApplicationToken>
  <Favourite:Credentials>
    <Favourite:Ticket>7T:1234abcxyzExample==</Favourite:Ticket>
  </Favourite:Credentials>
 <SOAP-ENV:Body>
   <Favourite:RemoveTicketsFromFavouritesByProvider>
    <Favourite:ProviderName xsi:type="xsd:string"></Favourite:ProviderName>
    <Favourite:Restrictions xsi:type="Favourite:ArrayOfArchiveRestrictionInfo">
     <Favourite:ArchiveRestrictionInfo xsi:type="Favourite:ArchiveRestrictionInfo">
      <Favourite:Name xsi:type="xsd:string"></Favourite:Name>
      <Favourite:Operator xsi:type="xsd:string"></Favourite:Operator>
      <Favourite:Values xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Favourite:Values>
      <Favourite:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </Favourite:DisplayValues>
      <Favourite:ColumnInfo xsi:type="Favourite:ArchiveColumnInfo">
       <Favourite:DisplayName xsi:type="xsd:string"></Favourite:DisplayName>
       <Favourite:DisplayTooltip xsi:type="xsd:string"></Favourite:DisplayTooltip>
       <Favourite:DisplayType xsi:type="xsd:string"></Favourite:DisplayType>
       <Favourite:CanOrderBy xsi:type="xsd:boolean">false</Favourite:CanOrderBy>
       <Favourite:Name xsi:type="xsd:string"></Favourite:Name>
       <Favourite:CanRestrictBy xsi:type="xsd:boolean">false</Favourite:CanRestrictBy>
       <Favourite:RestrictionType xsi:type="xsd:string"></Favourite:RestrictionType>
       <Favourite:RestrictionListName xsi:type="xsd:string"></Favourite:RestrictionListName>
       <Favourite:IsVisible xsi:type="xsd:boolean">false</Favourite:IsVisible>
       <Favourite:Width xsi:type="xsd:string"></Favourite:Width>
       <Favourite:IconHint xsi:type="xsd:string"></Favourite:IconHint>
       <Favourite:HeadingIconHint xsi:type="xsd:string"></Favourite:HeadingIconHint>
       <Favourite:ExtraInfo xsi:type="xsd:string"></Favourite:ExtraInfo>
      </Favourite:ColumnInfo>
      <Favourite:IsActive xsi:type="xsd:boolean">false</Favourite:IsActive>
      <Favourite:SubRestrictions xsi:type="Favourite:ArrayOfArchiveRestrictionInfo">
       <Favourite:ArchiveRestrictionInfo xsi:type="Favourite:ArchiveRestrictionInfo">
        <Favourite:Name xsi:type="xsd:string"></Favourite:Name>
        <Favourite:Operator xsi:type="xsd:string"></Favourite:Operator>
        <Favourite:Values xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Favourite:Values>
        <Favourite:DisplayValues xsi:type="NetServerServices882:ArrayOfstring">
         <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
        </Favourite:DisplayValues>
        <Favourite:ColumnInfo xsi:type="Favourite:ArchiveColumnInfo">
         <Favourite:DisplayName xsi:type="xsd:string"></Favourite:DisplayName>
         <Favourite:DisplayTooltip xsi:type="xsd:string"></Favourite:DisplayTooltip>
         <Favourite:DisplayType xsi:type="xsd:string"></Favourite:DisplayType>
         <Favourite:CanOrderBy xsi:type="xsd:boolean">false</Favourite:CanOrderBy>
         <Favourite:Name xsi:type="xsd:string"></Favourite:Name>
         <Favourite:CanRestrictBy xsi:type="xsd:boolean">false</Favourite:CanRestrictBy>
         <Favourite:RestrictionType xsi:type="xsd:string"></Favourite:RestrictionType>
         <Favourite:RestrictionListName xsi:type="xsd:string"></Favourite:RestrictionListName>
         <Favourite:IsVisible xsi:type="xsd:boolean">false</Favourite:IsVisible>
         <Favourite:Width xsi:type="xsd:string"></Favourite:Width>
         <Favourite:IconHint xsi:type="xsd:string"></Favourite:IconHint>
         <Favourite:HeadingIconHint xsi:type="xsd:string"></Favourite:HeadingIconHint>
         <Favourite:ExtraInfo xsi:type="xsd:string"></Favourite:ExtraInfo>
        </Favourite:ColumnInfo>
        <Favourite:IsActive xsi:type="xsd:boolean">false</Favourite:IsActive>
        <Favourite:SubRestrictions xsi:type="Favourite:ArrayOfArchiveRestrictionInfo">
         <Favourite:ArchiveRestrictionInfo xsi:type="Favourite:ArchiveRestrictionInfo">
          <Favourite:Name xsi:type="xsd:string"></Favourite:Name>
          <Favourite:Operator xsi:type="xsd:string"></Favourite:Operator>
          <Favourite:Values xsi:nil="true"></Favourite:Values>
          <Favourite:DisplayValues xsi:nil="true"></Favourite:DisplayValues>
          <Favourite:ColumnInfo xsi:nil="true"></Favourite:ColumnInfo>
          <Favourite:IsActive xsi:nil="true"></Favourite:IsActive>
          <Favourite:SubRestrictions xsi:nil="true"></Favourite:SubRestrictions>
          <Favourite:InterParenthesis xsi:nil="true"></Favourite:InterParenthesis>
          <Favourite:InterOperator xsi:nil="true"></Favourite:InterOperator>
          <Favourite:UniqueHash xsi:nil="true"></Favourite:UniqueHash>
         </Favourite:ArchiveRestrictionInfo>
        </Favourite:SubRestrictions>
        <Favourite:InterParenthesis xsi:type="xsd:int">0</Favourite:InterParenthesis>
        <Favourite:InterOperator xsi:type="Favourite:InterRestrictionOperator">None</Favourite:InterOperator>
        <Favourite:UniqueHash xsi:type="xsd:int">0</Favourite:UniqueHash>
       </Favourite:ArchiveRestrictionInfo>
      </Favourite:SubRestrictions>
      <Favourite:InterParenthesis xsi:type="xsd:int">0</Favourite:InterParenthesis>
      <Favourite:InterOperator xsi:type="Favourite:InterRestrictionOperator">None</Favourite:InterOperator>
      <Favourite:UniqueHash xsi:type="xsd:int">0</Favourite:UniqueHash>
     </Favourite:ArchiveRestrictionInfo>
    </Favourite:Restrictions>
    <Favourite:AssociateId xsi:type="xsd:int">0</Favourite:AssociateId>
   </Favourite:RemoveTicketsFromFavouritesByProvider>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveTicketsFromFavouritesByProvider Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Favourite="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Favourite:RemoveTicketsFromFavouritesByProviderResponse>
  </Favourite:RemoveTicketsFromFavouritesByProviderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

