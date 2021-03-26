---
uid: services83-document-substitutetemplatevariablesex
title: Services83.DocumentAgent.SubstituteTemplateVariablesEx SOAP
Generated: true
---

# Services83 Document SubstituteTemplateVariablesEx SOAP

SOAP request and response examples **Remote/Services83/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IDocumentAgent.SubstituteTemplateVariablesEx">SuperOffice.Services83.IDocumentAgent.SubstituteTemplateVariablesEx</see> method.

## SubstituteTemplateVariablesEx

Parse the source string, and replace any template variable tags with their values, based on the identities, custom values and entities specified in the other parameters.

* **parameters:** Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept whatever current culture is set on the server (possibly not a good choice in multinational organizations with a single server).

**Returns:** Source string with templates substituted, using the same encoding as for the source (binary data will be returned in Base64).


[WSDL file for Services83/Document](../Services83-Document.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SubstituteTemplateVariablesEx Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:SubstituteTemplateVariablesEx>
    <Document:Parameters xsi:type="Document:TemplateVariablesParameters">
     <Document:SourceInput xsi:type="xsd:string"></Document:SourceInput>
     <Document:Encoding xsi:type="Document:GeneratorEncoding">Text</Document:Encoding>
     <Document:CultureName xsi:type="xsd:string"></Document:CultureName>
     <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
     <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
     <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
     <Document:SelectionId xsi:type="xsd:int">0</Document:SelectionId>
     <Document:AppointmentId xsi:type="xsd:int">0</Document:AppointmentId>
     <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
     <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
     <Document:QuoteLineId xsi:type="xsd:int">0</Document:QuoteLineId>
     <Document:QuoteAlternativeId xsi:type="xsd:int">0</Document:QuoteAlternativeId>
     <Document:ProductKey xsi:type="xsd:string"></Document:ProductKey>
     <Document:CustomTags xsi:type="NetServerServices832:ArrayOfArrayOfstring">
      <NetServerServices832:ArrayOfstring xsi:type="NetServerServices832:ArrayOfstring">
       <NetServerServices832:string xsi:type="xsd:string"></NetServerServices832:string>
      </NetServerServices832:ArrayOfstring>
     </Document:CustomTags>
     <Document:DocumentEntity xsi:type="Document:DocumentEntity">
      <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
      <Document:UpdatedBy xsi:type="Document:Associate">
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
       <Document:Rank xsi:type="xsd:short">0</Document:Rank>
       <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
       <Document:Type xsi:type="Document:UserType">Unknown</Document:Type>
       <Document:GroupIdx xsi:type="xsd:int">0</Document:GroupIdx>
       <Document:FullName xsi:type="xsd:string"></Document:FullName>
       <Document:FormalName xsi:type="xsd:string"></Document:FormalName>
       <Document:Deleted xsi:type="xsd:boolean">false</Document:Deleted>
       <Document:EjUserId xsi:type="xsd:int">0</Document:EjUserId>
      </Document:UpdatedBy>
      <Document:CreatedBy xsi:type="Document:Associate">
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
       <Document:Rank xsi:type="xsd:short">0</Document:Rank>
       <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
       <Document:Type xsi:type="Document:UserType">Unknown</Document:Type>
       <Document:GroupIdx xsi:type="xsd:int">0</Document:GroupIdx>
       <Document:FullName xsi:type="xsd:string"></Document:FullName>
       <Document:FormalName xsi:type="xsd:string"></Document:FormalName>
       <Document:Deleted xsi:type="xsd:boolean">false</Document:Deleted>
       <Document:EjUserId xsi:type="xsd:int">0</Document:EjUserId>
      </Document:CreatedBy>
      <Document:Attention xsi:type="xsd:string"></Document:Attention>
      <Document:Header xsi:type="xsd:string"></Document:Header>
      <Document:Name xsi:type="xsd:string"></Document:Name>
      <Document:OurRef xsi:type="xsd:string"></Document:OurRef>
      <Document:YourRef xsi:type="xsd:string"></Document:YourRef>
      <Document:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:CreatedDate>
      <Document:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:UpdatedDate>
      <Document:Description xsi:type="xsd:string"></Document:Description>
      <Document:DocumentTemplate xsi:type="Document:DocumentTemplate">
       <Document:DocumentTemplateId xsi:type="xsd:int">0</Document:DocumentTemplateId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
       <Document:SaveInDb xsi:type="xsd:short">0</Document:SaveInDb>
       <Document:Filename xsi:type="xsd:string"></Document:Filename>
       <Document:DefaultOref xsi:type="xsd:string"></Document:DefaultOref>
       <Document:RecordType xsi:type="Document:DocTmplType">Unknown</Document:RecordType>
       <Document:Deleted xsi:type="xsd:short">0</Document:Deleted>
       <Document:Direction xsi:type="Document:DocTmplDirection">Unknown</Document:Direction>
       <Document:AutoeventId xsi:type="xsd:int">0</Document:AutoeventId>
       <Document:QuoteDocType xsi:type="Document:DocTmplQuoteType">None</Document:QuoteDocType>
      </Document:DocumentTemplate>
      <Document:Person xsi:type="Document:Person">
       <Document:Position xsi:type="xsd:string"></Document:Position>
       <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
       <Document:Mrmrs xsi:type="xsd:string"></Document:Mrmrs>
       <Document:Firstname xsi:type="xsd:string"></Document:Firstname>
       <Document:Lastname xsi:type="xsd:string"></Document:Lastname>
       <Document:MiddleName xsi:type="xsd:string"></Document:MiddleName>
       <Document:Title xsi:type="xsd:string"></Document:Title>
       <Document:Description xsi:type="xsd:string"></Document:Description>
       <Document:Email xsi:type="xsd:string"></Document:Email>
       <Document:FullName xsi:type="xsd:string"></Document:FullName>
       <Document:DirectPhone xsi:type="xsd:string"></Document:DirectPhone>
       <Document:FormalName xsi:type="xsd:string"></Document:FormalName>
       <Document:CountryId xsi:type="xsd:int">0</Document:CountryId>
       <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
       <Document:ContactName xsi:type="xsd:string"></Document:ContactName>
       <Document:Retired xsi:type="xsd:short">0</Document:Retired>
       <Document:Rank xsi:type="xsd:short">0</Document:Rank>
       <Document:ActiveInterests xsi:type="xsd:short">0</Document:ActiveInterests>
       <Document:ContactDepartment xsi:type="xsd:string"></Document:ContactDepartment>
       <Document:ContactCountryId xsi:type="xsd:int">0</Document:ContactCountryId>
       <Document:ContactOrgNr xsi:type="xsd:string"></Document:ContactOrgNr>
       <Document:FaxPhone xsi:type="xsd:string"></Document:FaxPhone>
       <Document:MobilePhone xsi:type="xsd:string"></Document:MobilePhone>
       <Document:ContactPhone xsi:type="xsd:string"></Document:ContactPhone>
       <Document:AssociateName xsi:type="xsd:string"></Document:AssociateName>
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:UsePersonAddress xsi:type="xsd:boolean">false</Document:UsePersonAddress>
       <Document:ContactFax xsi:type="xsd:string"></Document:ContactFax>
       <Document:Kanafname xsi:type="xsd:string"></Document:Kanafname>
       <Document:Kanalname xsi:type="xsd:string"></Document:Kanalname>
       <Document:Post1 xsi:type="xsd:string"></Document:Post1>
       <Document:Post2 xsi:type="xsd:string"></Document:Post2>
       <Document:Post3 xsi:type="xsd:string"></Document:Post3>
       <Document:EmailName xsi:type="xsd:string"></Document:EmailName>
       <Document:ContactFullName xsi:type="xsd:string"></Document:ContactFullName>
       <Document:ActiveErpLinks xsi:type="xsd:int">0</Document:ActiveErpLinks>
      </Document:Person>
      <Document:Associate xsi:type="Document:Associate">
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
       <Document:Rank xsi:type="xsd:short">0</Document:Rank>
       <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
       <Document:Type xsi:type="Document:UserType">Unknown</Document:Type>
       <Document:GroupIdx xsi:type="xsd:int">0</Document:GroupIdx>
       <Document:FullName xsi:type="xsd:string"></Document:FullName>
       <Document:FormalName xsi:type="xsd:string"></Document:FormalName>
       <Document:Deleted xsi:type="xsd:boolean">false</Document:Deleted>
       <Document:EjUserId xsi:type="xsd:int">0</Document:EjUserId>
      </Document:Associate>
      <Document:Contact xsi:type="Document:Contact">
       <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:OrgNr xsi:type="xsd:string"></Document:OrgNr>
       <Document:Department xsi:type="xsd:string"></Document:Department>
       <Document:URL xsi:type="xsd:string"></Document:URL>
       <Document:City xsi:type="xsd:string"></Document:City>
       <Document:DirectPhone xsi:type="xsd:string"></Document:DirectPhone>
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:CountryId xsi:type="xsd:int">0</Document:CountryId>
       <Document:EmailAddress xsi:type="xsd:string"></Document:EmailAddress>
       <Document:Kananame xsi:type="xsd:string"></Document:Kananame>
       <Document:EmailAddressName xsi:type="xsd:string"></Document:EmailAddressName>
       <Document:URLName xsi:type="xsd:string"></Document:URLName>
       <Document:AssociateFullName xsi:type="xsd:string"></Document:AssociateFullName>
       <Document:BusinessName xsi:type="xsd:string"></Document:BusinessName>
       <Document:CategoryName xsi:type="xsd:string"></Document:CategoryName>
       <Document:CountryName xsi:type="xsd:string"></Document:CountryName>
       <Document:Address xsi:type="Document:Address">
        <Document:Wgs84Latitude xsi:type="xsd:double">0.0</Document:Wgs84Latitude>
        <Document:Wgs84Longitude xsi:type="xsd:double">0.0</Document:Wgs84Longitude>
        <Document:LocalizedAddress xsi:type="Document:ArrayOfArrayOfLocalizedField">
         <Document:ArrayOfLocalizedField xsi:type="Document:ArrayOfLocalizedField">
          <Document:LocalizedField xsi:nil="true"></Document:LocalizedField>
         </Document:ArrayOfLocalizedField>
        </Document:LocalizedAddress>
       </Document:Address>
       <Document:FormattedAddress xsi:type="xsd:string"></Document:FormattedAddress>
       <Document:FullName xsi:type="xsd:string"></Document:FullName>
       <Document:IsOwnerContact xsi:type="xsd:boolean">false</Document:IsOwnerContact>
       <Document:ActiveErpLinks xsi:type="xsd:int">0</Document:ActiveErpLinks>
      </Document:Contact>
      <Document:Project xsi:type="Document:Project">
       <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
       <Document:Name xsi:type="xsd:string"></Document:Name>
       <Document:Description xsi:type="xsd:string"></Document:Description>
       <Document:URL xsi:type="xsd:string"></Document:URL>
       <Document:Type xsi:type="xsd:string"></Document:Type>
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:AssociateFullName xsi:type="xsd:string"></Document:AssociateFullName>
       <Document:TypeId xsi:type="xsd:int">0</Document:TypeId>
       <Document:Updated xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:Updated>
       <Document:StatusId xsi:type="xsd:int">0</Document:StatusId>
       <Document:Status xsi:type="xsd:string"></Document:Status>
       <Document:TextId xsi:type="xsd:int">0</Document:TextId>
       <Document:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:PublishTo>
       <Document:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:PublishFrom>
       <Document:IsPublished xsi:type="xsd:boolean">false</Document:IsPublished>
       <Document:URLName xsi:type="xsd:string"></Document:URLName>
       <Document:ProjectNumber xsi:type="xsd:string"></Document:ProjectNumber>
       <Document:ActiveErpLinks xsi:type="xsd:int">0</Document:ActiveErpLinks>
      </Document:Project>
      <Document:Date xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:Date>
      <Document:ExternalRef xsi:type="xsd:string"></Document:ExternalRef>
      <Document:Completed xsi:type="Document:ActivityStatus">Unknown</Document:Completed>
      <Document:ActiveLinks xsi:type="xsd:int">0</Document:ActiveLinks>
      <Document:Type xsi:type="Document:AppointmentType">Unknown</Document:Type>
      <Document:Links xsi:type="Document:ArrayOfLink">
       <Document:Link xsi:type="Document:Link">
        <Document:EntityName xsi:type="xsd:string"></Document:EntityName>
        <Document:Id xsi:type="xsd:int">0</Document:Id>
        <Document:Description xsi:type="xsd:string"></Document:Description>
        <Document:ExtraInfo xsi:type="xsd:string"></Document:ExtraInfo>
        <Document:LinkId xsi:type="xsd:int">0</Document:LinkId>
       </Document:Link>
      </Document:Links>
      <Document:LockSemantics xsi:type="Document:DocumentLockSemantics">None</Document:LockSemantics>
      <Document:Sale xsi:type="Document:Sale">
       <Document:ContactName xsi:type="xsd:string"></Document:ContactName>
       <Document:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:SaleDate>
       <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
       <Document:Probability xsi:type="xsd:short">0</Document:Probability>
       <Document:Title xsi:type="xsd:string"></Document:Title>
       <Document:Amount xsi:type="xsd:double">0.0</Document:Amount>
       <Document:Currency xsi:type="xsd:string"></Document:Currency>
       <Document:ProjectName xsi:type="xsd:string"></Document:ProjectName>
       <Document:AssociateFullName xsi:type="xsd:string"></Document:AssociateFullName>
       <Document:Description xsi:type="xsd:string"></Document:Description>
       <Document:Status xsi:type="Document:SaleStatus">Unknown</Document:Status>
       <Document:WeightedAmount xsi:type="xsd:double">0.0</Document:WeightedAmount>
       <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
       <Document:EarningPercent xsi:type="xsd:double">0.0</Document:EarningPercent>
       <Document:Earning xsi:type="xsd:double">0.0</Document:Earning>
       <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
       <Document:AssociateId xsi:type="xsd:int">0</Document:AssociateId>
       <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
       <Document:SaleTypeId xsi:type="xsd:int">0</Document:SaleTypeId>
       <Document:SaleTypeName xsi:type="xsd:string"></Document:SaleTypeName>
       <Document:PersonFullName xsi:type="xsd:string"></Document:PersonFullName>
       <Document:Completed xsi:type="Document:ActivityStatus">Unknown</Document:Completed>
       <Document:ActiveErpLinks xsi:type="xsd:int">0</Document:ActiveErpLinks>
       <Document:NextDueDate xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:NextDueDate>
      </Document:Sale>
      <Document:SuggestedDocumentId xsi:type="xsd:int">0</Document:SuggestedDocumentId>
      <Document:UserDefinedFields xsi:type="Document:StringDictionary">
       <Document:StringKeyValuePair>
        <Document:Key xsi:type="xsd:string"></Document:Key>
        <Document:Value xsi:type="xsd:string"></Document:Value>
       </Document:StringKeyValuePair>
      </Document:UserDefinedFields>
      <Document:ExtraFields xsi:type="Document:StringDictionary">
       <Document:StringKeyValuePair>
        <Document:Key xsi:type="xsd:string"></Document:Key>
        <Document:Value xsi:type="xsd:string"></Document:Value>
       </Document:StringKeyValuePair>
      </Document:ExtraFields>
      <Document:PublishEventDate xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:PublishEventDate>
      <Document:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:PublishTo>
      <Document:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:35:03Z</Document:PublishFrom>
      <Document:IsPublished xsi:type="xsd:boolean">false</Document:IsPublished>
      <Document:VisibleFor xsi:type="Document:ArrayOfVisibleFor">
       <Document:VisibleFor xsi:type="Document:VisibleFor">
        <Document:VisibleId xsi:type="xsd:int">0</Document:VisibleId>
        <Document:Visibility xsi:type="Document:Visibility">All</Document:Visibility>
        <Document:DisplayValue xsi:type="xsd:string"></Document:DisplayValue>
       </Document:VisibleFor>
      </Document:VisibleFor>
     </Document:DocumentEntity>
    </Document:Parameters>
   </Document:SubstituteTemplateVariablesEx>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SubstituteTemplateVariablesEx Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Document:SubstituteTemplateVariablesExResponse>
   <Document:Response xsi:type="xsd:string"></Document:Response>
  </Document:SubstituteTemplateVariablesExResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

