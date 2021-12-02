---
title: Services87.DocumentAgent.CreateNewPhysicalDocumentFromTemplate SOAP
generated: 1
uid: Services87-Document-CreateNewPhysicalDocumentFromTemplate
---

# Services87 Document CreateNewPhysicalDocumentFromTemplate

SOAP request and response examples **Remote/Services87/Document.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDocumentAgent.CreateNewPhysicalDocumentFromTemplate">SuperOffice.Services87.IDocumentAgent.CreateNewPhysicalDocumentFromTemplate</see> method.

## CreateNewPhysicalDocumentFromTemplate

Create a new document content based on a document template and store it in the document archive.  Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.

* **contactId:** Identifier for a contact. Defaults to document's contact if 0
* **personId:** Identifier for a person. Defaults to document's person if 0
* **appointmentId:** identifier for an appointment. Defaults to document if 0
* **documentId:** Identifier for a document. The document defines the template to use.
* **saleId:** Identifier for sale. Defaults to document's sale if 0.
* **selectionId:** identifier for selection.
* **projectId:** identifier for project. Defaults to document's project if 0
* **uiCulture:** Language variation of template to use when creating document content. (ISO code "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** The updated document entity, after creating the document content from the template.


[WSDL file for Services87/Document](../Services87-Document.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateNewPhysicalDocumentFromTemplate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Document:ApplicationToken>1234567-1234-9876</Document:ApplicationToken>
  <Document:Credentials>
    <Document:Ticket>7T:1234abcxyzExample==</Document:Ticket>
  </Document:Credentials>
 <SOAP-ENV:Body>
   <Document:CreateNewPhysicalDocumentFromTemplate>
    <Document:ContactId xsi:type="xsd:int">0</Document:ContactId>
    <Document:PersonId xsi:type="xsd:int">0</Document:PersonId>
    <Document:AppointmentId xsi:type="xsd:int">0</Document:AppointmentId>
    <Document:DocumentId xsi:type="xsd:int">0</Document:DocumentId>
    <Document:SaleId xsi:type="xsd:int">0</Document:SaleId>
    <Document:SelectionId xsi:type="xsd:int">0</Document:SelectionId>
    <Document:ProjectId xsi:type="xsd:int">0</Document:ProjectId>
    <Document:UiCulture xsi:type="xsd:string"></Document:UiCulture>
   </Document:CreateNewPhysicalDocumentFromTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateNewPhysicalDocumentFromTemplate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Document="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Document:CreateNewPhysicalDocumentFromTemplateResponse>
   <Document:Response xsi:type="Document:DocumentEntity">
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
     <Document:UserName xsi:type="xsd:string"></Document:UserName>
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
     <Document:UserName xsi:type="xsd:string"></Document:UserName>
    </Document:CreatedBy>
    <Document:Attention xsi:type="xsd:string"></Document:Attention>
    <Document:Header xsi:type="xsd:string"></Document:Header>
    <Document:Name xsi:type="xsd:string"></Document:Name>
    <Document:OurRef xsi:type="xsd:string"></Document:OurRef>
    <Document:YourRef xsi:type="xsd:string"></Document:YourRef>
    <Document:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:CreatedDate>
    <Document:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:UpdatedDate>
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
     <Document:TicketPriorityId xsi:type="xsd:int">0</Document:TicketPriorityId>
     <Document:SupportLanguageId xsi:type="xsd:int">0</Document:SupportLanguageId>
     <Document:SupportAssociateId xsi:type="xsd:int">0</Document:SupportAssociateId>
     <Document:CategoryName xsi:type="xsd:string"></Document:CategoryName>
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
     <Document:UserName xsi:type="xsd:string"></Document:UserName>
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
        <Document:LocalizedField xsi:type="Document:LocalizedField">
         <Document:Name xsi:type="xsd:string"></Document:Name>
         <Document:Value xsi:type="xsd:string"></Document:Value>
         <Document:Tooltip xsi:type="xsd:string"></Document:Tooltip>
         <Document:Label xsi:type="xsd:string"></Document:Label>
         <Document:ValueLength xsi:type="xsd:int">0</Document:ValueLength>
         <Document:AddressType xsi:type="xsd:string"></Document:AddressType>
        </Document:LocalizedField>
       </Document:ArrayOfLocalizedField>
      </Document:LocalizedAddress>
      <Document:Street xsi:type="Document:StructuredAddress">
       <Document:AtypeIdx xsi:type="Document:AddressType">Unknown</Document:AtypeIdx>
       <Document:Address1 xsi:type="xsd:string"></Document:Address1>
       <Document:Address2 xsi:type="xsd:string"></Document:Address2>
       <Document:Address3 xsi:type="xsd:string"></Document:Address3>
       <Document:City xsi:type="xsd:string"></Document:City>
       <Document:County xsi:type="xsd:string"></Document:County>
       <Document:State xsi:type="xsd:string"></Document:State>
       <Document:Zipcode xsi:type="xsd:string"></Document:Zipcode>
       <Document:Formatted xsi:type="xsd:string"></Document:Formatted>
      </Document:Street>
      <Document:Postal xsi:type="Document:StructuredAddress">
       <Document:AtypeIdx xsi:type="Document:AddressType">Unknown</Document:AtypeIdx>
       <Document:Address1 xsi:type="xsd:string"></Document:Address1>
       <Document:Address2 xsi:type="xsd:string"></Document:Address2>
       <Document:Address3 xsi:type="xsd:string"></Document:Address3>
       <Document:City xsi:type="xsd:string"></Document:City>
       <Document:County xsi:type="xsd:string"></Document:County>
       <Document:State xsi:type="xsd:string"></Document:State>
       <Document:Zipcode xsi:type="xsd:string"></Document:Zipcode>
       <Document:Formatted xsi:type="xsd:string"></Document:Formatted>
      </Document:Postal>
      <Document:Formatted xsi:type="xsd:string"></Document:Formatted>
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
     <Document:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:Updated>
     <Document:StatusId xsi:type="xsd:int">0</Document:StatusId>
     <Document:Status xsi:type="xsd:string"></Document:Status>
     <Document:TextId xsi:type="xsd:int">0</Document:TextId>
     <Document:PublishTo xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:PublishTo>
     <Document:PublishFrom xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:PublishFrom>
     <Document:IsPublished xsi:type="xsd:boolean">false</Document:IsPublished>
     <Document:URLName xsi:type="xsd:string"></Document:URLName>
     <Document:ProjectNumber xsi:type="xsd:string"></Document:ProjectNumber>
     <Document:ActiveErpLinks xsi:type="xsd:int">0</Document:ActiveErpLinks>
    </Document:Project>
    <Document:Date xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:Date>
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
     <Document:SaleDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:SaleDate>
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
     <Document:NextDueDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:NextDueDate>
    </Document:Sale>
    <Document:SuggestedDocumentId xsi:type="xsd:int">0</Document:SuggestedDocumentId>
    <Document:Snum xsi:type="xsd:int">0</Document:Snum>
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
    <Document:CustomFields xsi:type="Document:StringDictionary">
     <Document:StringKeyValuePair>
      <Document:Key xsi:type="xsd:string"></Document:Key>
      <Document:Value xsi:type="xsd:string"></Document:Value>
     </Document:StringKeyValuePair>
    </Document:CustomFields>
    <Document:PublishEventDate xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:PublishEventDate>
    <Document:PublishTo xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:PublishTo>
    <Document:PublishFrom xsi:type="xsd:dateTime">2021-11-30T13:23:13Z</Document:PublishFrom>
    <Document:IsPublished xsi:type="xsd:boolean">false</Document:IsPublished>
    <Document:VisibleFor xsi:type="Document:ArrayOfVisibleFor">
     <Document:VisibleFor xsi:type="Document:VisibleFor">
      <Document:VisibleId xsi:type="xsd:int">0</Document:VisibleId>
      <Document:Visibility xsi:type="Document:Visibility">All</Document:Visibility>
      <Document:DisplayValue xsi:type="xsd:string"></Document:DisplayValue>
     </Document:VisibleFor>
    </Document:VisibleFor>
   </Document:Response>
  </Document:CreateNewPhysicalDocumentFromTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

