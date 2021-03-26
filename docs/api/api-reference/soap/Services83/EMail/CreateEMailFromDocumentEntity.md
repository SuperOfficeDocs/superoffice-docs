---
uid: services83-email-createemailfromdocumententity
title: Services83.EMailAgent.CreateEMailFromDocumentEntity SOAP
Generated: true
---

# Services83 EMail CreateEMailFromDocumentEntity SOAP

SOAP request and response examples **Remote/Services83/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IEMailAgent.CreateEMailFromDocumentEntity">SuperOffice.Services83.IEMailAgent.CreateEMailFromDocumentEntity</see> method.

## CreateEMailFromDocumentEntity

Get an e-mail based on the provided DocumentEntity

* **documentEntity:** DocumentEntity data

**Returns:** The e-mail


[WSDL file for Services83/EMail](../Services83-EMail.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateEMailFromDocumentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:CreateEMailFromDocumentEntity>
    <EMail:DocumentEntity xsi:type="EMail:DocumentEntity">
     <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
     <EMail:UpdatedBy xsi:type="EMail:Associate">
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:Type xsi:type="EMail:UserType">Unknown</EMail:Type>
      <EMail:GroupIdx xsi:type="xsd:int">0</EMail:GroupIdx>
      <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
      <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
      <EMail:EjUserId xsi:type="xsd:int">0</EMail:EjUserId>
     </EMail:UpdatedBy>
     <EMail:CreatedBy xsi:type="EMail:Associate">
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:Type xsi:type="EMail:UserType">Unknown</EMail:Type>
      <EMail:GroupIdx xsi:type="xsd:int">0</EMail:GroupIdx>
      <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
      <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
      <EMail:EjUserId xsi:type="xsd:int">0</EMail:EjUserId>
     </EMail:CreatedBy>
     <EMail:Attention xsi:type="xsd:string"></EMail:Attention>
     <EMail:Header xsi:type="xsd:string"></EMail:Header>
     <EMail:Name xsi:type="xsd:string"></EMail:Name>
     <EMail:OurRef xsi:type="xsd:string"></EMail:OurRef>
     <EMail:YourRef xsi:type="xsd:string"></EMail:YourRef>
     <EMail:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:CreatedDate>
     <EMail:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:UpdatedDate>
     <EMail:Description xsi:type="xsd:string"></EMail:Description>
     <EMail:DocumentTemplate xsi:type="EMail:DocumentTemplate">
      <EMail:DocumentTemplateId xsi:type="xsd:int">0</EMail:DocumentTemplateId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:SaveInDb xsi:type="xsd:short">0</EMail:SaveInDb>
      <EMail:Filename xsi:type="xsd:string"></EMail:Filename>
      <EMail:DefaultOref xsi:type="xsd:string"></EMail:DefaultOref>
      <EMail:RecordType xsi:type="EMail:DocTmplType">Unknown</EMail:RecordType>
      <EMail:Deleted xsi:type="xsd:short">0</EMail:Deleted>
      <EMail:Direction xsi:type="EMail:DocTmplDirection">Unknown</EMail:Direction>
      <EMail:AutoeventId xsi:type="xsd:int">0</EMail:AutoeventId>
      <EMail:QuoteDocType xsi:type="EMail:DocTmplQuoteType">None</EMail:QuoteDocType>
     </EMail:DocumentTemplate>
     <EMail:Person xsi:type="EMail:Person">
      <EMail:Position xsi:type="xsd:string"></EMail:Position>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:Mrmrs xsi:type="xsd:string"></EMail:Mrmrs>
      <EMail:Firstname xsi:type="xsd:string"></EMail:Firstname>
      <EMail:Lastname xsi:type="xsd:string"></EMail:Lastname>
      <EMail:MiddleName xsi:type="xsd:string"></EMail:MiddleName>
      <EMail:Title xsi:type="xsd:string"></EMail:Title>
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:Email xsi:type="xsd:string"></EMail:Email>
      <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      <EMail:DirectPhone xsi:type="xsd:string"></EMail:DirectPhone>
      <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
      <EMail:CountryId xsi:type="xsd:int">0</EMail:CountryId>
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:Retired xsi:type="xsd:short">0</EMail:Retired>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:ActiveInterests xsi:type="xsd:short">0</EMail:ActiveInterests>
      <EMail:ContactDepartment xsi:type="xsd:string"></EMail:ContactDepartment>
      <EMail:ContactCountryId xsi:type="xsd:int">0</EMail:ContactCountryId>
      <EMail:ContactOrgNr xsi:type="xsd:string"></EMail:ContactOrgNr>
      <EMail:FaxPhone xsi:type="xsd:string"></EMail:FaxPhone>
      <EMail:MobilePhone xsi:type="xsd:string"></EMail:MobilePhone>
      <EMail:ContactPhone xsi:type="xsd:string"></EMail:ContactPhone>
      <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:UsePersonAddress xsi:type="xsd:boolean">false</EMail:UsePersonAddress>
      <EMail:ContactFax xsi:type="xsd:string"></EMail:ContactFax>
      <EMail:Kanafname xsi:type="xsd:string"></EMail:Kanafname>
      <EMail:Kanalname xsi:type="xsd:string"></EMail:Kanalname>
      <EMail:Post1 xsi:type="xsd:string"></EMail:Post1>
      <EMail:Post2 xsi:type="xsd:string"></EMail:Post2>
      <EMail:Post3 xsi:type="xsd:string"></EMail:Post3>
      <EMail:EmailName xsi:type="xsd:string"></EMail:EmailName>
      <EMail:ContactFullName xsi:type="xsd:string"></EMail:ContactFullName>
      <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
     </EMail:Person>
     <EMail:Associate xsi:type="EMail:Associate">
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:Type xsi:type="EMail:UserType">Unknown</EMail:Type>
      <EMail:GroupIdx xsi:type="xsd:int">0</EMail:GroupIdx>
      <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
      <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
      <EMail:EjUserId xsi:type="xsd:int">0</EMail:EjUserId>
     </EMail:Associate>
     <EMail:Contact xsi:type="EMail:Contact">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:OrgNr xsi:type="xsd:string"></EMail:OrgNr>
      <EMail:Department xsi:type="xsd:string"></EMail:Department>
      <EMail:URL xsi:type="xsd:string"></EMail:URL>
      <EMail:City xsi:type="xsd:string"></EMail:City>
      <EMail:DirectPhone xsi:type="xsd:string"></EMail:DirectPhone>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:CountryId xsi:type="xsd:int">0</EMail:CountryId>
      <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
      <EMail:Kananame xsi:type="xsd:string"></EMail:Kananame>
      <EMail:EmailAddressName xsi:type="xsd:string"></EMail:EmailAddressName>
      <EMail:URLName xsi:type="xsd:string"></EMail:URLName>
      <EMail:AssociateFullName xsi:type="xsd:string"></EMail:AssociateFullName>
      <EMail:BusinessName xsi:type="xsd:string"></EMail:BusinessName>
      <EMail:CategoryName xsi:type="xsd:string"></EMail:CategoryName>
      <EMail:CountryName xsi:type="xsd:string"></EMail:CountryName>
      <EMail:Address xsi:type="EMail:Address">
       <EMail:Wgs84Latitude xsi:type="xsd:double">0.0</EMail:Wgs84Latitude>
       <EMail:Wgs84Longitude xsi:type="xsd:double">0.0</EMail:Wgs84Longitude>
       <EMail:LocalizedAddress xsi:type="EMail:ArrayOfArrayOfLocalizedField">
        <EMail:ArrayOfLocalizedField xsi:type="EMail:ArrayOfLocalizedField">
         <EMail:LocalizedField xsi:type="EMail:LocalizedField">
          <EMail:Name xsi:type="xsd:string"></EMail:Name>
          <EMail:Value xsi:type="xsd:string"></EMail:Value>
          <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
          <EMail:Label xsi:type="xsd:string"></EMail:Label>
          <EMail:ValueLength xsi:nil="true"></EMail:ValueLength>
          <EMail:AddressType xsi:type="xsd:string"></EMail:AddressType>
         </EMail:LocalizedField>
        </EMail:ArrayOfLocalizedField>
       </EMail:LocalizedAddress>
      </EMail:Address>
      <EMail:FormattedAddress xsi:type="xsd:string"></EMail:FormattedAddress>
      <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      <EMail:IsOwnerContact xsi:type="xsd:boolean">false</EMail:IsOwnerContact>
      <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
     </EMail:Contact>
     <EMail:Project xsi:type="EMail:Project">
      <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:URL xsi:type="xsd:string"></EMail:URL>
      <EMail:Type xsi:type="xsd:string"></EMail:Type>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:AssociateFullName xsi:type="xsd:string"></EMail:AssociateFullName>
      <EMail:TypeId xsi:type="xsd:int">0</EMail:TypeId>
      <EMail:Updated xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:Updated>
      <EMail:StatusId xsi:type="xsd:int">0</EMail:StatusId>
      <EMail:Status xsi:type="xsd:string"></EMail:Status>
      <EMail:TextId xsi:type="xsd:int">0</EMail:TextId>
      <EMail:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:PublishTo>
      <EMail:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:PublishFrom>
      <EMail:IsPublished xsi:type="xsd:boolean">false</EMail:IsPublished>
      <EMail:URLName xsi:type="xsd:string"></EMail:URLName>
      <EMail:ProjectNumber xsi:type="xsd:string"></EMail:ProjectNumber>
      <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
     </EMail:Project>
     <EMail:Date xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:Date>
     <EMail:ExternalRef xsi:type="xsd:string"></EMail:ExternalRef>
     <EMail:Completed xsi:type="EMail:ActivityStatus">Unknown</EMail:Completed>
     <EMail:ActiveLinks xsi:type="xsd:int">0</EMail:ActiveLinks>
     <EMail:Type xsi:type="EMail:AppointmentType">Unknown</EMail:Type>
     <EMail:Links xsi:type="EMail:ArrayOfLink">
      <EMail:Link xsi:type="EMail:Link">
       <EMail:EntityName xsi:type="xsd:string"></EMail:EntityName>
       <EMail:Id xsi:type="xsd:int">0</EMail:Id>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
       <EMail:ExtraInfo xsi:type="xsd:string"></EMail:ExtraInfo>
       <EMail:LinkId xsi:type="xsd:int">0</EMail:LinkId>
      </EMail:Link>
     </EMail:Links>
     <EMail:LockSemantics xsi:type="EMail:DocumentLockSemantics">None</EMail:LockSemantics>
     <EMail:Sale xsi:type="EMail:Sale">
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:SaleDate>
      <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
      <EMail:Probability xsi:type="xsd:short">0</EMail:Probability>
      <EMail:Title xsi:type="xsd:string"></EMail:Title>
      <EMail:Amount xsi:type="xsd:double">0.0</EMail:Amount>
      <EMail:Currency xsi:type="xsd:string"></EMail:Currency>
      <EMail:ProjectName xsi:type="xsd:string"></EMail:ProjectName>
      <EMail:AssociateFullName xsi:type="xsd:string"></EMail:AssociateFullName>
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:Status xsi:type="EMail:SaleStatus">Unknown</EMail:Status>
      <EMail:WeightedAmount xsi:type="xsd:double">0.0</EMail:WeightedAmount>
      <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
      <EMail:EarningPercent xsi:type="xsd:double">0.0</EMail:EarningPercent>
      <EMail:Earning xsi:type="xsd:double">0.0</EMail:Earning>
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:SaleTypeId xsi:type="xsd:int">0</EMail:SaleTypeId>
      <EMail:SaleTypeName xsi:type="xsd:string"></EMail:SaleTypeName>
      <EMail:PersonFullName xsi:type="xsd:string"></EMail:PersonFullName>
      <EMail:Completed xsi:type="EMail:ActivityStatus">Unknown</EMail:Completed>
      <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
      <EMail:NextDueDate xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:NextDueDate>
     </EMail:Sale>
     <EMail:SuggestedDocumentId xsi:type="xsd:int">0</EMail:SuggestedDocumentId>
     <EMail:UserDefinedFields xsi:type="EMail:StringDictionary">
      <EMail:StringKeyValuePair>
       <EMail:Key xsi:type="xsd:string"></EMail:Key>
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
      </EMail:StringKeyValuePair>
     </EMail:UserDefinedFields>
     <EMail:ExtraFields xsi:type="EMail:StringDictionary">
      <EMail:StringKeyValuePair>
       <EMail:Key xsi:type="xsd:string"></EMail:Key>
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
      </EMail:StringKeyValuePair>
     </EMail:ExtraFields>
     <EMail:PublishEventDate xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:PublishEventDate>
     <EMail:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:PublishTo>
     <EMail:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:PublishFrom>
     <EMail:IsPublished xsi:type="xsd:boolean">false</EMail:IsPublished>
     <EMail:VisibleFor xsi:type="EMail:ArrayOfVisibleFor">
      <EMail:VisibleFor xsi:type="EMail:VisibleFor">
       <EMail:VisibleId xsi:type="xsd:int">0</EMail:VisibleId>
       <EMail:Visibility xsi:type="EMail:Visibility">All</EMail:Visibility>
       <EMail:DisplayValue xsi:type="xsd:string"></EMail:DisplayValue>
      </EMail:VisibleFor>
     </EMail:VisibleFor>
    </EMail:DocumentEntity>
   </EMail:CreateEMailFromDocumentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateEMailFromDocumentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <EMail:CreateEMailFromDocumentEntityResponse>
   <EMail:Response xsi:type="EMail:EMailEntity">
    <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
       <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:To>
    <EMail:Cc xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
       <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:Cc>
    <EMail:Bcc xsi:type="EMail:ArrayOfEMailAddress">
     <EMail:EMailAddress xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
       <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:EMailAddress>
    </EMail:Bcc>
    <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
    <EMail:HTMLBody xsi:type="xsd:string"></EMail:HTMLBody>
    <EMail:From xsi:type="EMail:EMailAddress">
     <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
     <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     <EMail:Address xsi:type="xsd:string"></EMail:Address>
     <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
     <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
      <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
     </EMail:DuplicatePersonIds>
     <EMail:Name xsi:type="xsd:string"></EMail:Name>
    </EMail:From>
    <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:Sent>
    <EMail:Size xsi:type="xsd:int">0</EMail:Size>
    <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
    <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
    <EMail:MessageID xsi:type="xsd:string"></EMail:MessageID>
    <EMail:PlainBody xsi:type="xsd:string"></EMail:PlainBody>
    <EMail:IsSent xsi:type="xsd:boolean">false</EMail:IsSent>
    <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
     <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
     <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
     <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
     <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
     <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
     <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:ArchivedAt>
     <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
     <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
    </EMail:EMailSOInfo>
    <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
    <EMail:Attachments xsi:type="EMail:ArrayOfEMailAttachment">
     <EMail:EMailAttachment xsi:type="EMail:EMailAttachment">
      <EMail:Description xsi:type="xsd:string"></EMail:Description>
      <EMail:Filename xsi:type="xsd:string"></EMail:Filename>
      <EMail:Size xsi:type="xsd:int">0</EMail:Size>
      <EMail:Type xsi:type="xsd:string"></EMail:Type>
      <EMail:Encoding xsi:type="xsd:string"></EMail:Encoding>
      <EMail:Id xsi:type="xsd:string"></EMail:Id>
      <EMail:Disposition xsi:type="xsd:string"></EMail:Disposition>
      <EMail:Stream xsi:type="xsd:base64Binary"></EMail:Stream>
     </EMail:EMailAttachment>
    </EMail:Attachments>
    <EMail:CustomHeaderList xsi:type="EMail:ArrayOfEMailCustomHeader">
     <EMail:EMailCustomHeader xsi:type="EMail:EMailCustomHeader">
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:Values xsi:type="NetServerServices832:ArrayOfstring">
       <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
      </EMail:Values>
     </EMail:EMailCustomHeader>
    </EMail:CustomHeaderList>
    <EMail:FolderName xsi:type="xsd:string"></EMail:FolderName>
    <EMail:EmailItemId xsi:type="xsd:int">0</EMail:EmailItemId>
    <EMail:AccountId xsi:type="xsd:int">0</EMail:AccountId>
    <EMail:ReceivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:ReceivedAt>
    <EMail:InReplyTo xsi:type="EMail:EMailEnvelope">
     <EMail:ServerId xsi:type="xsd:int">0</EMail:ServerId>
     <EMail:MessageId xsi:type="xsd:string"></EMail:MessageId>
     <EMail:Subject xsi:type="xsd:string"></EMail:Subject>
     <EMail:From xsi:type="EMail:EMailAddress">
      <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
      <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
      <EMail:Address xsi:type="xsd:string"></EMail:Address>
      <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
      <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
       <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
      </EMail:DuplicatePersonIds>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
     </EMail:From>
     <EMail:To xsi:type="EMail:ArrayOfEMailAddress">
      <EMail:EMailAddress xsi:type="EMail:EMailAddress">
       <EMail:ContactId xsi:type="xsd:int">0</EMail:ContactId>
       <EMail:ContactName xsi:type="xsd:string"></EMail:ContactName>
       <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
       <EMail:PersonName xsi:type="xsd:string"></EMail:PersonName>
       <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
       <EMail:Address xsi:type="xsd:string"></EMail:Address>
       <EMail:EmailId xsi:type="xsd:int">0</EMail:EmailId>
       <EMail:DuplicatePersonIds xsi:type="NetServerServices832:ArrayOfint">
        <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
       </EMail:DuplicatePersonIds>
       <EMail:Name xsi:type="xsd:string"></EMail:Name>
      </EMail:EMailAddress>
     </EMail:To>
     <EMail:Sent xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:Sent>
     <EMail:Priority xsi:type="EMail:EMailPriority">NoPriority</EMail:Priority>
     <EMail:Flags xsi:type="EMail:EMailFlags">Seen</EMail:Flags>
     <EMail:Size xsi:type="xsd:int">0</EMail:Size>
     <EMail:EMailSOInfo xsi:type="EMail:EMailSOInfo">
      <EMail:DocumentId xsi:type="xsd:int">0</EMail:DocumentId>
      <EMail:AppointmentId xsi:type="xsd:int">0</EMail:AppointmentId>
      <EMail:ProjectId xsi:type="xsd:int">0</EMail:ProjectId>
      <EMail:SaleId xsi:type="xsd:int">0</EMail:SaleId>
      <EMail:Archived xsi:type="xsd:boolean">false</EMail:Archived>
      <EMail:ArchivedAt xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:ArchivedAt>
      <EMail:ArchivedBy xsi:type="xsd:int">0</EMail:ArchivedBy>
      <EMail:ArchivedDisplayName xsi:type="xsd:string"></EMail:ArchivedDisplayName>
     </EMail:EMailSOInfo>
    </EMail:InReplyTo>
    <EMail:RepliedAt xsi:type="xsd:dateTime">2021-03-25T21:35:04Z</EMail:RepliedAt>
   </EMail:Response>
  </EMail:CreateEMailFromDocumentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

