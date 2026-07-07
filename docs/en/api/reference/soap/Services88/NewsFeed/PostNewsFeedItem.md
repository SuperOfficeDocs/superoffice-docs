---
title: Services88.NewsFeedAgent.PostNewsFeedItem SOAP
generated: true
uid: Services88-NewsFeed-PostNewsFeedItem
content_type: reference
---

# Services88 NewsFeed PostNewsFeedItem

SOAP request and response examples **Remote/Services88/NewsFeed.svc**
Implemented by the <see cref="M:SuperOffice.Services88.INewsFeedAgent.PostNewsFeedItem">SuperOffice.Services88.INewsFeedAgent.PostNewsFeedItem</see> method.

## PostNewsFeedItem





[WSDL file for Services88/NewsFeed](../Services88-NewsFeed.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## PostNewsFeedItem Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NewsFeed="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <NewsFeed:ApplicationToken>1234567-1234-9876</NewsFeed:ApplicationToken>
  <NewsFeed:Credentials>
    <NewsFeed:Ticket>7T:1234abcxyzExample==</NewsFeed:Ticket>
  </NewsFeed:Credentials>
 <SOAP-ENV:Body>
   <NewsFeed:PostNewsFeedItem>
    <NewsFeed:NewsFeedItem xsi:type="NewsFeed:NewsFeedItem">
     <NewsFeed:NewsFeedItemId xsi:type="xsd:int">0</NewsFeed:NewsFeedItemId>
     <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
     <NewsFeed:Summary xsi:type="xsd:string"></NewsFeed:Summary>
     <NewsFeed:Description xsi:type="NewsFeed:StringDictionary">
      <NewsFeed:StringKeyValuePair>
       <NewsFeed:Key xsi:type="xsd:string"></NewsFeed:Key>
       <NewsFeed:Value xsi:type="xsd:string"></NewsFeed:Value>
      </NewsFeed:StringKeyValuePair>
     </NewsFeed:Description>
     <NewsFeed:Actions xsi:type="NewsFeed:ArrayOfNewsFeedCTA">
      <NewsFeed:NewsFeedCTA xsi:type="NewsFeed:NewsFeedCTA">
       <NewsFeed:Identifier xsi:type="xsd:string"></NewsFeed:Identifier>
       <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
       <NewsFeed:CtaType xsi:type="NewsFeed:CtaType">Unknown</NewsFeed:CtaType>
       <NewsFeed:CtaFlavor xsi:type="NewsFeed:CtaFlavor">Normal</NewsFeed:CtaFlavor>
      </NewsFeed:NewsFeedCTA>
     </NewsFeed:Actions>
     <NewsFeed:ImageLink xsi:type="xsd:string"></NewsFeed:ImageLink>
     <NewsFeed:SourceLink xsi:type="xsd:string"></NewsFeed:SourceLink>
     <NewsFeed:PreviewHint xsi:type="xsd:string"></NewsFeed:PreviewHint>
     <NewsFeed:FromName xsi:type="xsd:string"></NewsFeed:FromName>
     <NewsFeed:FromCategoryName xsi:type="xsd:string"></NewsFeed:FromCategoryName>
     <NewsFeed:Priority xsi:type="NewsFeed:EMailPriority">NoPriority</NewsFeed:Priority>
     <NewsFeed:Registered xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Registered>
     <NewsFeed:Updated xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Updated>
     <NewsFeed:ExpiresAt xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:ExpiresAt>
     <NewsFeed:Status xsi:type="NewsFeed:NewsFeedItemStatus">Normal</NewsFeed:Status>
     <NewsFeed:IsRead xsi:type="xsd:boolean">false</NewsFeed:IsRead>
     <NewsFeed:ReadAt xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:ReadAt>
     <NewsFeed:Contact xsi:type="NewsFeed:Contact">
      <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
      <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
      <NewsFeed:OrgNr xsi:type="xsd:string"></NewsFeed:OrgNr>
      <NewsFeed:Department xsi:type="xsd:string"></NewsFeed:Department>
      <NewsFeed:URL xsi:type="xsd:string"></NewsFeed:URL>
      <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
      <NewsFeed:DirectPhone xsi:type="xsd:string"></NewsFeed:DirectPhone>
      <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
      <NewsFeed:CountryId xsi:type="xsd:int">0</NewsFeed:CountryId>
      <NewsFeed:EmailAddress xsi:type="xsd:string"></NewsFeed:EmailAddress>
      <NewsFeed:Kananame xsi:type="xsd:string"></NewsFeed:Kananame>
      <NewsFeed:EmailAddressName xsi:type="xsd:string"></NewsFeed:EmailAddressName>
      <NewsFeed:URLName xsi:type="xsd:string"></NewsFeed:URLName>
      <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
      <NewsFeed:BusinessName xsi:type="xsd:string"></NewsFeed:BusinessName>
      <NewsFeed:CategoryName xsi:type="xsd:string"></NewsFeed:CategoryName>
      <NewsFeed:CountryName xsi:type="xsd:string"></NewsFeed:CountryName>
      <NewsFeed:Address xsi:type="NewsFeed:Address">
       <NewsFeed:Wgs84Latitude xsi:type="xsd:double">0.0</NewsFeed:Wgs84Latitude>
       <NewsFeed:Wgs84Longitude xsi:type="xsd:double">0.0</NewsFeed:Wgs84Longitude>
       <NewsFeed:LocalizedAddress xsi:type="NewsFeed:ArrayOfArrayOfLocalizedField">
        <NewsFeed:ArrayOfLocalizedField xsi:type="NewsFeed:ArrayOfLocalizedField">
         <NewsFeed:LocalizedField xsi:type="NewsFeed:LocalizedField">
          <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
          <NewsFeed:Value xsi:type="xsd:string"></NewsFeed:Value>
          <NewsFeed:Tooltip xsi:type="xsd:string"></NewsFeed:Tooltip>
          <NewsFeed:Label xsi:type="xsd:string"></NewsFeed:Label>
          <NewsFeed:ValueLength xsi:nil="true"></NewsFeed:ValueLength>
          <NewsFeed:AddressType xsi:type="xsd:string"></NewsFeed:AddressType>
         </NewsFeed:LocalizedField>
        </NewsFeed:ArrayOfLocalizedField>
       </NewsFeed:LocalizedAddress>
       <NewsFeed:Street xsi:type="NewsFeed:StructuredAddress">
        <NewsFeed:AtypeIdx xsi:type="NewsFeed:AddressType">Unknown</NewsFeed:AtypeIdx>
        <NewsFeed:Address1 xsi:type="xsd:string"></NewsFeed:Address1>
        <NewsFeed:Address2 xsi:type="xsd:string"></NewsFeed:Address2>
        <NewsFeed:Address3 xsi:type="xsd:string"></NewsFeed:Address3>
        <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
        <NewsFeed:County xsi:type="xsd:string"></NewsFeed:County>
        <NewsFeed:State xsi:type="xsd:string"></NewsFeed:State>
        <NewsFeed:Zipcode xsi:type="xsd:string"></NewsFeed:Zipcode>
        <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
       </NewsFeed:Street>
       <NewsFeed:Postal xsi:type="NewsFeed:StructuredAddress">
        <NewsFeed:AtypeIdx xsi:type="NewsFeed:AddressType">Unknown</NewsFeed:AtypeIdx>
        <NewsFeed:Address1 xsi:type="xsd:string"></NewsFeed:Address1>
        <NewsFeed:Address2 xsi:type="xsd:string"></NewsFeed:Address2>
        <NewsFeed:Address3 xsi:type="xsd:string"></NewsFeed:Address3>
        <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
        <NewsFeed:County xsi:type="xsd:string"></NewsFeed:County>
        <NewsFeed:State xsi:type="xsd:string"></NewsFeed:State>
        <NewsFeed:Zipcode xsi:type="xsd:string"></NewsFeed:Zipcode>
        <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
       </NewsFeed:Postal>
       <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
      </NewsFeed:Address>
      <NewsFeed:FormattedAddress xsi:type="xsd:string"></NewsFeed:FormattedAddress>
      <NewsFeed:FullName xsi:type="xsd:string"></NewsFeed:FullName>
      <NewsFeed:IsOwnerContact xsi:type="xsd:boolean">false</NewsFeed:IsOwnerContact>
      <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
      <NewsFeed:Number1 xsi:type="xsd:string"></NewsFeed:Number1>
      <NewsFeed:Number2 xsi:type="xsd:string"></NewsFeed:Number2>
     </NewsFeed:Contact>
     <NewsFeed:Person xsi:type="NewsFeed:Person">
      <NewsFeed:Position xsi:type="xsd:string"></NewsFeed:Position>
      <NewsFeed:PersonId xsi:type="xsd:int">0</NewsFeed:PersonId>
      <NewsFeed:Mrmrs xsi:type="xsd:string"></NewsFeed:Mrmrs>
      <NewsFeed:Firstname xsi:type="xsd:string"></NewsFeed:Firstname>
      <NewsFeed:Lastname xsi:type="xsd:string"></NewsFeed:Lastname>
      <NewsFeed:MiddleName xsi:type="xsd:string"></NewsFeed:MiddleName>
      <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
      <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
      <NewsFeed:Email xsi:type="xsd:string"></NewsFeed:Email>
      <NewsFeed:FullName xsi:type="xsd:string"></NewsFeed:FullName>
      <NewsFeed:DirectPhone xsi:type="xsd:string"></NewsFeed:DirectPhone>
      <NewsFeed:FormalName xsi:type="xsd:string"></NewsFeed:FormalName>
      <NewsFeed:CountryId xsi:type="xsd:int">0</NewsFeed:CountryId>
      <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
      <NewsFeed:ContactName xsi:type="xsd:string"></NewsFeed:ContactName>
      <NewsFeed:Retired xsi:type="xsd:short">0</NewsFeed:Retired>
      <NewsFeed:Rank xsi:type="xsd:short">0</NewsFeed:Rank>
      <NewsFeed:ActiveInterests xsi:type="xsd:short">0</NewsFeed:ActiveInterests>
      <NewsFeed:ContactDepartment xsi:type="xsd:string"></NewsFeed:ContactDepartment>
      <NewsFeed:ContactCountryId xsi:type="xsd:int">0</NewsFeed:ContactCountryId>
      <NewsFeed:ContactOrgNr xsi:type="xsd:string"></NewsFeed:ContactOrgNr>
      <NewsFeed:FaxPhone xsi:type="xsd:string"></NewsFeed:FaxPhone>
      <NewsFeed:MobilePhone xsi:type="xsd:string"></NewsFeed:MobilePhone>
      <NewsFeed:ContactPhone xsi:type="xsd:string"></NewsFeed:ContactPhone>
      <NewsFeed:AssociateName xsi:type="xsd:string"></NewsFeed:AssociateName>
      <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
      <NewsFeed:UsePersonAddress xsi:type="xsd:boolean">false</NewsFeed:UsePersonAddress>
      <NewsFeed:ContactFax xsi:type="xsd:string"></NewsFeed:ContactFax>
      <NewsFeed:Kanafname xsi:type="xsd:string"></NewsFeed:Kanafname>
      <NewsFeed:Kanalname xsi:type="xsd:string"></NewsFeed:Kanalname>
      <NewsFeed:Post1 xsi:type="xsd:string"></NewsFeed:Post1>
      <NewsFeed:Post2 xsi:type="xsd:string"></NewsFeed:Post2>
      <NewsFeed:Post3 xsi:type="xsd:string"></NewsFeed:Post3>
      <NewsFeed:EmailName xsi:type="xsd:string"></NewsFeed:EmailName>
      <NewsFeed:ContactFullName xsi:type="xsd:string"></NewsFeed:ContactFullName>
      <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
      <NewsFeed:TicketPriorityId xsi:type="xsd:int">0</NewsFeed:TicketPriorityId>
      <NewsFeed:SupportLanguageId xsi:type="xsd:int">0</NewsFeed:SupportLanguageId>
      <NewsFeed:SupportAssociateId xsi:type="xsd:int">0</NewsFeed:SupportAssociateId>
      <NewsFeed:CategoryName xsi:type="xsd:string"></NewsFeed:CategoryName>
      <NewsFeed:PersonNumber xsi:type="xsd:string"></NewsFeed:PersonNumber>
     </NewsFeed:Person>
     <NewsFeed:Project xsi:type="NewsFeed:Project">
      <NewsFeed:ProjectId xsi:type="xsd:int">0</NewsFeed:ProjectId>
      <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
      <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
      <NewsFeed:URL xsi:type="xsd:string"></NewsFeed:URL>
      <NewsFeed:Type xsi:type="xsd:string"></NewsFeed:Type>
      <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
      <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
      <NewsFeed:TypeId xsi:type="xsd:int">0</NewsFeed:TypeId>
      <NewsFeed:Updated xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Updated>
      <NewsFeed:StatusId xsi:type="xsd:int">0</NewsFeed:StatusId>
      <NewsFeed:Status xsi:type="xsd:string"></NewsFeed:Status>
      <NewsFeed:TextId xsi:type="xsd:int">0</NewsFeed:TextId>
      <NewsFeed:PublishTo xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:PublishTo>
      <NewsFeed:PublishFrom xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:PublishFrom>
      <NewsFeed:IsPublished xsi:type="xsd:boolean">false</NewsFeed:IsPublished>
      <NewsFeed:URLName xsi:type="xsd:string"></NewsFeed:URLName>
      <NewsFeed:ProjectNumber xsi:type="xsd:string"></NewsFeed:ProjectNumber>
      <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
      <NewsFeed:EventId xsi:type="xsd:int">0</NewsFeed:EventId>
      <NewsFeed:StartDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:StartDate>
     </NewsFeed:Project>
     <NewsFeed:Sale xsi:type="NewsFeed:Sale">
      <NewsFeed:ContactName xsi:type="xsd:string"></NewsFeed:ContactName>
      <NewsFeed:SaleDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:SaleDate>
      <NewsFeed:SaleId xsi:type="xsd:int">0</NewsFeed:SaleId>
      <NewsFeed:Probability xsi:type="xsd:short">0</NewsFeed:Probability>
      <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
      <NewsFeed:Amount xsi:type="xsd:double">0.0</NewsFeed:Amount>
      <NewsFeed:Currency xsi:type="xsd:string"></NewsFeed:Currency>
      <NewsFeed:ProjectName xsi:type="xsd:string"></NewsFeed:ProjectName>
      <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
      <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
      <NewsFeed:Status xsi:type="NewsFeed:SaleStatus">Unknown</NewsFeed:Status>
      <NewsFeed:WeightedAmount xsi:type="xsd:double">0.0</NewsFeed:WeightedAmount>
      <NewsFeed:ProjectId xsi:type="xsd:int">0</NewsFeed:ProjectId>
      <NewsFeed:EarningPercent xsi:type="xsd:double">0.0</NewsFeed:EarningPercent>
      <NewsFeed:Earning xsi:type="xsd:double">0.0</NewsFeed:Earning>
      <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
      <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
      <NewsFeed:PersonId xsi:type="xsd:int">0</NewsFeed:PersonId>
      <NewsFeed:SaleTypeId xsi:type="xsd:int">0</NewsFeed:SaleTypeId>
      <NewsFeed:SaleTypeName xsi:type="xsd:string"></NewsFeed:SaleTypeName>
      <NewsFeed:PersonFullName xsi:type="xsd:string"></NewsFeed:PersonFullName>
      <NewsFeed:Completed xsi:type="NewsFeed:ActivityStatus">Unknown</NewsFeed:Completed>
      <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
      <NewsFeed:NextDueDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:NextDueDate>
      <NewsFeed:Number xsi:type="xsd:string"></NewsFeed:Number>
     </NewsFeed:Sale>
     <NewsFeed:ApplicationId xsi:type="xsd:string"></NewsFeed:ApplicationId>
    </NewsFeed:NewsFeedItem>
    <NewsFeed:ToAssociateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </NewsFeed:ToAssociateIds>
    <NewsFeed:ToGroupIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </NewsFeed:ToGroupIds>
    <NewsFeed:ToAll xsi:type="xsd:boolean">false</NewsFeed:ToAll>
   </NewsFeed:PostNewsFeedItem>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## PostNewsFeedItem Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NewsFeed="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <NewsFeed:PostNewsFeedItemResponse>
   <NewsFeed:Response xsi:type="NewsFeed:NewsFeedItem">
    <NewsFeed:NewsFeedItemId xsi:type="xsd:int">0</NewsFeed:NewsFeedItemId>
    <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
    <NewsFeed:Summary xsi:type="xsd:string"></NewsFeed:Summary>
    <NewsFeed:Description xsi:type="NewsFeed:StringDictionary">
     <NewsFeed:StringKeyValuePair>
      <NewsFeed:Key xsi:type="xsd:string"></NewsFeed:Key>
      <NewsFeed:Value xsi:type="xsd:string"></NewsFeed:Value>
     </NewsFeed:StringKeyValuePair>
    </NewsFeed:Description>
    <NewsFeed:Actions xsi:type="NewsFeed:ArrayOfNewsFeedCTA">
     <NewsFeed:NewsFeedCTA xsi:type="NewsFeed:NewsFeedCTA">
      <NewsFeed:Identifier xsi:type="xsd:string"></NewsFeed:Identifier>
      <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
      <NewsFeed:CtaType xsi:type="NewsFeed:CtaType">Unknown</NewsFeed:CtaType>
      <NewsFeed:CtaFlavor xsi:type="NewsFeed:CtaFlavor">Normal</NewsFeed:CtaFlavor>
     </NewsFeed:NewsFeedCTA>
    </NewsFeed:Actions>
    <NewsFeed:ImageLink xsi:type="xsd:string"></NewsFeed:ImageLink>
    <NewsFeed:SourceLink xsi:type="xsd:string"></NewsFeed:SourceLink>
    <NewsFeed:PreviewHint xsi:type="xsd:string"></NewsFeed:PreviewHint>
    <NewsFeed:FromName xsi:type="xsd:string"></NewsFeed:FromName>
    <NewsFeed:FromCategoryName xsi:type="xsd:string"></NewsFeed:FromCategoryName>
    <NewsFeed:Priority xsi:type="NewsFeed:EMailPriority">NoPriority</NewsFeed:Priority>
    <NewsFeed:Registered xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Registered>
    <NewsFeed:Updated xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Updated>
    <NewsFeed:ExpiresAt xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:ExpiresAt>
    <NewsFeed:Status xsi:type="NewsFeed:NewsFeedItemStatus">Normal</NewsFeed:Status>
    <NewsFeed:IsRead xsi:type="xsd:boolean">false</NewsFeed:IsRead>
    <NewsFeed:ReadAt xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:ReadAt>
    <NewsFeed:Contact xsi:type="NewsFeed:Contact">
     <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
     <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
     <NewsFeed:OrgNr xsi:type="xsd:string"></NewsFeed:OrgNr>
     <NewsFeed:Department xsi:type="xsd:string"></NewsFeed:Department>
     <NewsFeed:URL xsi:type="xsd:string"></NewsFeed:URL>
     <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
     <NewsFeed:DirectPhone xsi:type="xsd:string"></NewsFeed:DirectPhone>
     <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
     <NewsFeed:CountryId xsi:type="xsd:int">0</NewsFeed:CountryId>
     <NewsFeed:EmailAddress xsi:type="xsd:string"></NewsFeed:EmailAddress>
     <NewsFeed:Kananame xsi:type="xsd:string"></NewsFeed:Kananame>
     <NewsFeed:EmailAddressName xsi:type="xsd:string"></NewsFeed:EmailAddressName>
     <NewsFeed:URLName xsi:type="xsd:string"></NewsFeed:URLName>
     <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
     <NewsFeed:BusinessName xsi:type="xsd:string"></NewsFeed:BusinessName>
     <NewsFeed:CategoryName xsi:type="xsd:string"></NewsFeed:CategoryName>
     <NewsFeed:CountryName xsi:type="xsd:string"></NewsFeed:CountryName>
     <NewsFeed:Address xsi:type="NewsFeed:Address">
      <NewsFeed:Wgs84Latitude xsi:type="xsd:double">0.0</NewsFeed:Wgs84Latitude>
      <NewsFeed:Wgs84Longitude xsi:type="xsd:double">0.0</NewsFeed:Wgs84Longitude>
      <NewsFeed:LocalizedAddress xsi:type="NewsFeed:ArrayOfArrayOfLocalizedField">
       <NewsFeed:ArrayOfLocalizedField xsi:type="NewsFeed:ArrayOfLocalizedField">
        <NewsFeed:LocalizedField xsi:type="NewsFeed:LocalizedField">
         <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
         <NewsFeed:Value xsi:type="xsd:string"></NewsFeed:Value>
         <NewsFeed:Tooltip xsi:type="xsd:string"></NewsFeed:Tooltip>
         <NewsFeed:Label xsi:type="xsd:string"></NewsFeed:Label>
         <NewsFeed:ValueLength xsi:type="xsd:int">0</NewsFeed:ValueLength>
         <NewsFeed:AddressType xsi:type="xsd:string"></NewsFeed:AddressType>
        </NewsFeed:LocalizedField>
       </NewsFeed:ArrayOfLocalizedField>
      </NewsFeed:LocalizedAddress>
      <NewsFeed:Street xsi:type="NewsFeed:StructuredAddress">
       <NewsFeed:AtypeIdx xsi:type="NewsFeed:AddressType">Unknown</NewsFeed:AtypeIdx>
       <NewsFeed:Address1 xsi:type="xsd:string"></NewsFeed:Address1>
       <NewsFeed:Address2 xsi:type="xsd:string"></NewsFeed:Address2>
       <NewsFeed:Address3 xsi:type="xsd:string"></NewsFeed:Address3>
       <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
       <NewsFeed:County xsi:type="xsd:string"></NewsFeed:County>
       <NewsFeed:State xsi:type="xsd:string"></NewsFeed:State>
       <NewsFeed:Zipcode xsi:type="xsd:string"></NewsFeed:Zipcode>
       <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
      </NewsFeed:Street>
      <NewsFeed:Postal xsi:type="NewsFeed:StructuredAddress">
       <NewsFeed:AtypeIdx xsi:type="NewsFeed:AddressType">Unknown</NewsFeed:AtypeIdx>
       <NewsFeed:Address1 xsi:type="xsd:string"></NewsFeed:Address1>
       <NewsFeed:Address2 xsi:type="xsd:string"></NewsFeed:Address2>
       <NewsFeed:Address3 xsi:type="xsd:string"></NewsFeed:Address3>
       <NewsFeed:City xsi:type="xsd:string"></NewsFeed:City>
       <NewsFeed:County xsi:type="xsd:string"></NewsFeed:County>
       <NewsFeed:State xsi:type="xsd:string"></NewsFeed:State>
       <NewsFeed:Zipcode xsi:type="xsd:string"></NewsFeed:Zipcode>
       <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
      </NewsFeed:Postal>
      <NewsFeed:Formatted xsi:type="xsd:string"></NewsFeed:Formatted>
     </NewsFeed:Address>
     <NewsFeed:FormattedAddress xsi:type="xsd:string"></NewsFeed:FormattedAddress>
     <NewsFeed:FullName xsi:type="xsd:string"></NewsFeed:FullName>
     <NewsFeed:IsOwnerContact xsi:type="xsd:boolean">false</NewsFeed:IsOwnerContact>
     <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
     <NewsFeed:Number1 xsi:type="xsd:string"></NewsFeed:Number1>
     <NewsFeed:Number2 xsi:type="xsd:string"></NewsFeed:Number2>
    </NewsFeed:Contact>
    <NewsFeed:Person xsi:type="NewsFeed:Person">
     <NewsFeed:Position xsi:type="xsd:string"></NewsFeed:Position>
     <NewsFeed:PersonId xsi:type="xsd:int">0</NewsFeed:PersonId>
     <NewsFeed:Mrmrs xsi:type="xsd:string"></NewsFeed:Mrmrs>
     <NewsFeed:Firstname xsi:type="xsd:string"></NewsFeed:Firstname>
     <NewsFeed:Lastname xsi:type="xsd:string"></NewsFeed:Lastname>
     <NewsFeed:MiddleName xsi:type="xsd:string"></NewsFeed:MiddleName>
     <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
     <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
     <NewsFeed:Email xsi:type="xsd:string"></NewsFeed:Email>
     <NewsFeed:FullName xsi:type="xsd:string"></NewsFeed:FullName>
     <NewsFeed:DirectPhone xsi:type="xsd:string"></NewsFeed:DirectPhone>
     <NewsFeed:FormalName xsi:type="xsd:string"></NewsFeed:FormalName>
     <NewsFeed:CountryId xsi:type="xsd:int">0</NewsFeed:CountryId>
     <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
     <NewsFeed:ContactName xsi:type="xsd:string"></NewsFeed:ContactName>
     <NewsFeed:Retired xsi:type="xsd:short">0</NewsFeed:Retired>
     <NewsFeed:Rank xsi:type="xsd:short">0</NewsFeed:Rank>
     <NewsFeed:ActiveInterests xsi:type="xsd:short">0</NewsFeed:ActiveInterests>
     <NewsFeed:ContactDepartment xsi:type="xsd:string"></NewsFeed:ContactDepartment>
     <NewsFeed:ContactCountryId xsi:type="xsd:int">0</NewsFeed:ContactCountryId>
     <NewsFeed:ContactOrgNr xsi:type="xsd:string"></NewsFeed:ContactOrgNr>
     <NewsFeed:FaxPhone xsi:type="xsd:string"></NewsFeed:FaxPhone>
     <NewsFeed:MobilePhone xsi:type="xsd:string"></NewsFeed:MobilePhone>
     <NewsFeed:ContactPhone xsi:type="xsd:string"></NewsFeed:ContactPhone>
     <NewsFeed:AssociateName xsi:type="xsd:string"></NewsFeed:AssociateName>
     <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
     <NewsFeed:UsePersonAddress xsi:type="xsd:boolean">false</NewsFeed:UsePersonAddress>
     <NewsFeed:ContactFax xsi:type="xsd:string"></NewsFeed:ContactFax>
     <NewsFeed:Kanafname xsi:type="xsd:string"></NewsFeed:Kanafname>
     <NewsFeed:Kanalname xsi:type="xsd:string"></NewsFeed:Kanalname>
     <NewsFeed:Post1 xsi:type="xsd:string"></NewsFeed:Post1>
     <NewsFeed:Post2 xsi:type="xsd:string"></NewsFeed:Post2>
     <NewsFeed:Post3 xsi:type="xsd:string"></NewsFeed:Post3>
     <NewsFeed:EmailName xsi:type="xsd:string"></NewsFeed:EmailName>
     <NewsFeed:ContactFullName xsi:type="xsd:string"></NewsFeed:ContactFullName>
     <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
     <NewsFeed:TicketPriorityId xsi:type="xsd:int">0</NewsFeed:TicketPriorityId>
     <NewsFeed:SupportLanguageId xsi:type="xsd:int">0</NewsFeed:SupportLanguageId>
     <NewsFeed:SupportAssociateId xsi:type="xsd:int">0</NewsFeed:SupportAssociateId>
     <NewsFeed:CategoryName xsi:type="xsd:string"></NewsFeed:CategoryName>
     <NewsFeed:PersonNumber xsi:type="xsd:string"></NewsFeed:PersonNumber>
    </NewsFeed:Person>
    <NewsFeed:Project xsi:type="NewsFeed:Project">
     <NewsFeed:ProjectId xsi:type="xsd:int">0</NewsFeed:ProjectId>
     <NewsFeed:Name xsi:type="xsd:string"></NewsFeed:Name>
     <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
     <NewsFeed:URL xsi:type="xsd:string"></NewsFeed:URL>
     <NewsFeed:Type xsi:type="xsd:string"></NewsFeed:Type>
     <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
     <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
     <NewsFeed:TypeId xsi:type="xsd:int">0</NewsFeed:TypeId>
     <NewsFeed:Updated xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:Updated>
     <NewsFeed:StatusId xsi:type="xsd:int">0</NewsFeed:StatusId>
     <NewsFeed:Status xsi:type="xsd:string"></NewsFeed:Status>
     <NewsFeed:TextId xsi:type="xsd:int">0</NewsFeed:TextId>
     <NewsFeed:PublishTo xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:PublishTo>
     <NewsFeed:PublishFrom xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:PublishFrom>
     <NewsFeed:IsPublished xsi:type="xsd:boolean">false</NewsFeed:IsPublished>
     <NewsFeed:URLName xsi:type="xsd:string"></NewsFeed:URLName>
     <NewsFeed:ProjectNumber xsi:type="xsd:string"></NewsFeed:ProjectNumber>
     <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
     <NewsFeed:EventId xsi:type="xsd:int">0</NewsFeed:EventId>
     <NewsFeed:StartDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:StartDate>
    </NewsFeed:Project>
    <NewsFeed:Sale xsi:type="NewsFeed:Sale">
     <NewsFeed:ContactName xsi:type="xsd:string"></NewsFeed:ContactName>
     <NewsFeed:SaleDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:SaleDate>
     <NewsFeed:SaleId xsi:type="xsd:int">0</NewsFeed:SaleId>
     <NewsFeed:Probability xsi:type="xsd:short">0</NewsFeed:Probability>
     <NewsFeed:Title xsi:type="xsd:string"></NewsFeed:Title>
     <NewsFeed:Amount xsi:type="xsd:double">0.0</NewsFeed:Amount>
     <NewsFeed:Currency xsi:type="xsd:string"></NewsFeed:Currency>
     <NewsFeed:ProjectName xsi:type="xsd:string"></NewsFeed:ProjectName>
     <NewsFeed:AssociateFullName xsi:type="xsd:string"></NewsFeed:AssociateFullName>
     <NewsFeed:Description xsi:type="xsd:string"></NewsFeed:Description>
     <NewsFeed:Status xsi:type="NewsFeed:SaleStatus">Unknown</NewsFeed:Status>
     <NewsFeed:WeightedAmount xsi:type="xsd:double">0.0</NewsFeed:WeightedAmount>
     <NewsFeed:ProjectId xsi:type="xsd:int">0</NewsFeed:ProjectId>
     <NewsFeed:EarningPercent xsi:type="xsd:double">0.0</NewsFeed:EarningPercent>
     <NewsFeed:Earning xsi:type="xsd:double">0.0</NewsFeed:Earning>
     <NewsFeed:ContactId xsi:type="xsd:int">0</NewsFeed:ContactId>
     <NewsFeed:AssociateId xsi:type="xsd:int">0</NewsFeed:AssociateId>
     <NewsFeed:PersonId xsi:type="xsd:int">0</NewsFeed:PersonId>
     <NewsFeed:SaleTypeId xsi:type="xsd:int">0</NewsFeed:SaleTypeId>
     <NewsFeed:SaleTypeName xsi:type="xsd:string"></NewsFeed:SaleTypeName>
     <NewsFeed:PersonFullName xsi:type="xsd:string"></NewsFeed:PersonFullName>
     <NewsFeed:Completed xsi:type="NewsFeed:ActivityStatus">Unknown</NewsFeed:Completed>
     <NewsFeed:ActiveErpLinks xsi:type="xsd:int">0</NewsFeed:ActiveErpLinks>
     <NewsFeed:NextDueDate xsi:type="xsd:dateTime">2026-07-02T01:23:23Z</NewsFeed:NextDueDate>
     <NewsFeed:Number xsi:type="xsd:string"></NewsFeed:Number>
    </NewsFeed:Sale>
    <NewsFeed:ApplicationId xsi:type="xsd:string"></NewsFeed:ApplicationId>
   </NewsFeed:Response>
  </NewsFeed:PostNewsFeedItemResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

