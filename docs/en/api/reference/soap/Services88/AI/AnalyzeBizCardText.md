---
title: Services88.AIAgent.AnalyzeBizCardText SOAP
generated: true
uid: Services88-AI-AnalyzeBizCardText
content_type: reference
---

# Services88 AI AnalyzeBizCardText

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.AnalyzeBizCardText">SuperOffice.Services88.IAIAgent.AnalyzeBizCardText</see> method.

## AnalyzeBizCardText





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AnalyzeBizCardText Request

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
   <AI:AnalyzeBizCardText>
    <AI:Text xsi:type="xsd:string"></AI:Text>
    <AI:MergeWithDatabase xsi:type="xsd:boolean">false</AI:MergeWithDatabase>
   </AI:AnalyzeBizCardText>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AnalyzeBizCardText Response

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
  <AI:AnalyzeBizCardTextResponse>
   <AI:Response xsi:type="AI:BizCard">
    <AI:Contact xsi:type="AI:ContactEntity">
     <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
     <AI:Name xsi:type="xsd:string"></AI:Name>
     <AI:Department xsi:type="xsd:string"></AI:Department>
     <AI:OrgNr xsi:type="xsd:string"></AI:OrgNr>
     <AI:Number1 xsi:type="xsd:string"></AI:Number1>
     <AI:Number2 xsi:type="xsd:string"></AI:Number2>
     <AI:UpdatedDate xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:UpdatedDate>
     <AI:CreatedDate xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:CreatedDate>
     <AI:Emails xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Emails>
     <AI:Interests xsi:type="AI:ArrayOfSelectableMDOListItem">
      <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
       <AI:Id xsi:type="xsd:int">0</AI:Id>
       <AI:Name xsi:type="xsd:string"></AI:Name>
       <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
       <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
       <AI:Rank xsi:type="xsd:int">0</AI:Rank>
       <AI:Type xsi:type="xsd:string"></AI:Type>
       <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
       <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
       <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
       <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
       <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
        <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
         <AI:Id xsi:type="xsd:int">0</AI:Id>
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
         <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
         <AI:Rank xsi:type="xsd:int">0</AI:Rank>
         <AI:Type xsi:type="xsd:string"></AI:Type>
         <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
         <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
         <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
         <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
         <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
          <AI:SelectableMDOListItem xsi:nil="true"></AI:SelectableMDOListItem>
         </AI:ChildItems>
         <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
         <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
         <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
         <AI:FullName xsi:type="xsd:string"></AI:FullName>
        </AI:SelectableMDOListItem>
       </AI:ChildItems>
       <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
       <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
       <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
       <AI:FullName xsi:type="xsd:string"></AI:FullName>
      </AI:SelectableMDOListItem>
     </AI:Interests>
     <AI:Urls xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Urls>
     <AI:Phones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Phones>
     <AI:Faxes xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Faxes>
     <AI:Description xsi:type="xsd:string"></AI:Description>
     <AI:UpdatedBy xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:UpdatedBy>
     <AI:CreatedBy xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:CreatedBy>
     <AI:Associate xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:Associate>
     <AI:Business xsi:type="AI:Business">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Business>
     <AI:Category xsi:type="AI:Category">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Category>
     <AI:Country xsi:type="AI:Country">
      <AI:CountryId xsi:type="xsd:int">0</AI:CountryId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:CurrencyId xsi:type="xsd:int">0</AI:CurrencyId>
      <AI:EnglishName xsi:type="xsd:string"></AI:EnglishName>
      <AI:TwoLetterISOCountry xsi:type="xsd:string"></AI:TwoLetterISOCountry>
      <AI:ThreeLetterISOCountry xsi:type="xsd:string"></AI:ThreeLetterISOCountry>
      <AI:ImageDescription xsi:type="xsd:string"></AI:ImageDescription>
      <AI:OrgNrText xsi:type="xsd:string"></AI:OrgNrText>
      <AI:InterAreaPrefix xsi:type="xsd:string"></AI:InterAreaPrefix>
      <AI:DialInPrefix xsi:type="xsd:string"></AI:DialInPrefix>
      <AI:ZipPrefix xsi:type="xsd:string"></AI:ZipPrefix>
      <AI:DomainName xsi:type="xsd:string"></AI:DomainName>
      <AI:AddressLayoutId xsi:type="xsd:int">0</AI:AddressLayoutId>
      <AI:DomesticAddressLayoutId xsi:type="xsd:int">0</AI:DomesticAddressLayoutId>
      <AI:ForeignAddressLayoutId xsi:type="xsd:int">0</AI:ForeignAddressLayoutId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
     </AI:Country>
     <AI:Persons xsi:type="AI:ArrayOfPerson">
      <AI:Person xsi:type="AI:Person">
       <AI:Position xsi:type="xsd:string"></AI:Position>
       <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
       <AI:Mrmrs xsi:type="xsd:string"></AI:Mrmrs>
       <AI:Firstname xsi:type="xsd:string"></AI:Firstname>
       <AI:Lastname xsi:type="xsd:string"></AI:Lastname>
       <AI:MiddleName xsi:type="xsd:string"></AI:MiddleName>
       <AI:Title xsi:type="xsd:string"></AI:Title>
       <AI:Description xsi:type="xsd:string"></AI:Description>
       <AI:Email xsi:type="xsd:string"></AI:Email>
       <AI:FullName xsi:type="xsd:string"></AI:FullName>
       <AI:DirectPhone xsi:type="xsd:string"></AI:DirectPhone>
       <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
       <AI:CountryId xsi:type="xsd:int">0</AI:CountryId>
       <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
       <AI:ContactName xsi:type="xsd:string"></AI:ContactName>
       <AI:Retired xsi:type="xsd:short">0</AI:Retired>
       <AI:Rank xsi:type="xsd:short">0</AI:Rank>
       <AI:ActiveInterests xsi:type="xsd:short">0</AI:ActiveInterests>
       <AI:ContactDepartment xsi:type="xsd:string"></AI:ContactDepartment>
       <AI:ContactCountryId xsi:type="xsd:int">0</AI:ContactCountryId>
       <AI:ContactOrgNr xsi:type="xsd:string"></AI:ContactOrgNr>
       <AI:FaxPhone xsi:type="xsd:string"></AI:FaxPhone>
       <AI:MobilePhone xsi:type="xsd:string"></AI:MobilePhone>
       <AI:ContactPhone xsi:type="xsd:string"></AI:ContactPhone>
       <AI:AssociateName xsi:type="xsd:string"></AI:AssociateName>
       <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
       <AI:UsePersonAddress xsi:type="xsd:boolean">false</AI:UsePersonAddress>
       <AI:ContactFax xsi:type="xsd:string"></AI:ContactFax>
       <AI:Kanafname xsi:type="xsd:string"></AI:Kanafname>
       <AI:Kanalname xsi:type="xsd:string"></AI:Kanalname>
       <AI:Post1 xsi:type="xsd:string"></AI:Post1>
       <AI:Post2 xsi:type="xsd:string"></AI:Post2>
       <AI:Post3 xsi:type="xsd:string"></AI:Post3>
       <AI:EmailName xsi:type="xsd:string"></AI:EmailName>
       <AI:ContactFullName xsi:type="xsd:string"></AI:ContactFullName>
       <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
       <AI:TicketPriorityId xsi:type="xsd:int">0</AI:TicketPriorityId>
       <AI:SupportLanguageId xsi:type="xsd:int">0</AI:SupportLanguageId>
       <AI:SupportAssociateId xsi:type="xsd:int">0</AI:SupportAssociateId>
       <AI:CategoryName xsi:type="xsd:string"></AI:CategoryName>
       <AI:PersonNumber xsi:type="xsd:string"></AI:PersonNumber>
      </AI:Person>
     </AI:Persons>
     <AI:NoMailing xsi:type="xsd:boolean">false</AI:NoMailing>
     <AI:Kananame xsi:type="xsd:string"></AI:Kananame>
     <AI:Xstop xsi:type="xsd:boolean">false</AI:Xstop>
     <AI:ActiveInterests xsi:type="xsd:int">0</AI:ActiveInterests>
     <AI:GroupId xsi:type="xsd:int">0</AI:GroupId>
     <AI:ActiveStatusMonitorId xsi:type="xsd:int">0</AI:ActiveStatusMonitorId>
     <AI:SupportAssociate xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:SupportAssociate>
     <AI:TicketPriority xsi:type="AI:TicketPriority">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:TicketPriority>
     <AI:CustomerLanguage xsi:type="AI:CustomerLanguage">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:CustomerLanguage>
     <AI:Deleted xsi:type="xsd:short">0</AI:Deleted>
     <AI:DbiAgentId xsi:type="xsd:int">0</AI:DbiAgentId>
     <AI:DbiLastSyncronized xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:DbiLastSyncronized>
     <AI:DbiKey xsi:type="xsd:string"></AI:DbiKey>
     <AI:DbiLastModified xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:DbiLastModified>
     <AI:SupportPerson xsi:type="AI:Person">
      <AI:Position xsi:type="xsd:string"></AI:Position>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Mrmrs xsi:type="xsd:string"></AI:Mrmrs>
      <AI:Firstname xsi:type="xsd:string"></AI:Firstname>
      <AI:Lastname xsi:type="xsd:string"></AI:Lastname>
      <AI:MiddleName xsi:type="xsd:string"></AI:MiddleName>
      <AI:Title xsi:type="xsd:string"></AI:Title>
      <AI:Description xsi:type="xsd:string"></AI:Description>
      <AI:Email xsi:type="xsd:string"></AI:Email>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:DirectPhone xsi:type="xsd:string"></AI:DirectPhone>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:CountryId xsi:type="xsd:int">0</AI:CountryId>
      <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
      <AI:ContactName xsi:type="xsd:string"></AI:ContactName>
      <AI:Retired xsi:type="xsd:short">0</AI:Retired>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:ActiveInterests xsi:type="xsd:short">0</AI:ActiveInterests>
      <AI:ContactDepartment xsi:type="xsd:string"></AI:ContactDepartment>
      <AI:ContactCountryId xsi:type="xsd:int">0</AI:ContactCountryId>
      <AI:ContactOrgNr xsi:type="xsd:string"></AI:ContactOrgNr>
      <AI:FaxPhone xsi:type="xsd:string"></AI:FaxPhone>
      <AI:MobilePhone xsi:type="xsd:string"></AI:MobilePhone>
      <AI:ContactPhone xsi:type="xsd:string"></AI:ContactPhone>
      <AI:AssociateName xsi:type="xsd:string"></AI:AssociateName>
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:UsePersonAddress xsi:type="xsd:boolean">false</AI:UsePersonAddress>
      <AI:ContactFax xsi:type="xsd:string"></AI:ContactFax>
      <AI:Kanafname xsi:type="xsd:string"></AI:Kanafname>
      <AI:Kanalname xsi:type="xsd:string"></AI:Kanalname>
      <AI:Post1 xsi:type="xsd:string"></AI:Post1>
      <AI:Post2 xsi:type="xsd:string"></AI:Post2>
      <AI:Post3 xsi:type="xsd:string"></AI:Post3>
      <AI:EmailName xsi:type="xsd:string"></AI:EmailName>
      <AI:ContactFullName xsi:type="xsd:string"></AI:ContactFullName>
      <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
      <AI:TicketPriorityId xsi:type="xsd:int">0</AI:TicketPriorityId>
      <AI:SupportLanguageId xsi:type="xsd:int">0</AI:SupportLanguageId>
      <AI:SupportAssociateId xsi:type="xsd:int">0</AI:SupportAssociateId>
      <AI:CategoryName xsi:type="xsd:string"></AI:CategoryName>
      <AI:PersonNumber xsi:type="xsd:string"></AI:PersonNumber>
     </AI:SupportPerson>
     <AI:Address xsi:type="AI:Address">
      <AI:Wgs84Latitude xsi:type="xsd:double">0.0</AI:Wgs84Latitude>
      <AI:Wgs84Longitude xsi:type="xsd:double">0.0</AI:Wgs84Longitude>
      <AI:LocalizedAddress xsi:type="AI:ArrayOfArrayOfLocalizedField">
       <AI:ArrayOfLocalizedField xsi:type="AI:ArrayOfLocalizedField">
        <AI:LocalizedField xsi:type="AI:LocalizedField">
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:Value xsi:type="xsd:string"></AI:Value>
         <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
         <AI:Label xsi:type="xsd:string"></AI:Label>
         <AI:ValueLength xsi:type="xsd:int">0</AI:ValueLength>
         <AI:AddressType xsi:type="xsd:string"></AI:AddressType>
        </AI:LocalizedField>
       </AI:ArrayOfLocalizedField>
      </AI:LocalizedAddress>
      <AI:Street xsi:type="AI:StructuredAddress">
       <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
       <AI:Address1 xsi:type="xsd:string"></AI:Address1>
       <AI:Address2 xsi:type="xsd:string"></AI:Address2>
       <AI:Address3 xsi:type="xsd:string"></AI:Address3>
       <AI:City xsi:type="xsd:string"></AI:City>
       <AI:County xsi:type="xsd:string"></AI:County>
       <AI:State xsi:type="xsd:string"></AI:State>
       <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
       <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
      </AI:Street>
      <AI:Postal xsi:type="AI:StructuredAddress">
       <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
       <AI:Address1 xsi:type="xsd:string"></AI:Address1>
       <AI:Address2 xsi:type="xsd:string"></AI:Address2>
       <AI:Address3 xsi:type="xsd:string"></AI:Address3>
       <AI:City xsi:type="xsd:string"></AI:City>
       <AI:County xsi:type="xsd:string"></AI:County>
       <AI:State xsi:type="xsd:string"></AI:State>
       <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
       <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
      </AI:Postal>
      <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
     </AI:Address>
     <AI:Source xsi:type="xsd:short">0</AI:Source>
     <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
     <AI:BounceEmails xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </AI:BounceEmails>
     <AI:Domains xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </AI:Domains>
     <AI:UtmParameters xsi:type="AI:SavedUtmParameters">
      <AI:FormName xsi:type="xsd:string"></AI:FormName>
      <AI:FirsttouchSource xsi:type="xsd:string"></AI:FirsttouchSource>
      <AI:FirsttouchMedium xsi:type="xsd:string"></AI:FirsttouchMedium>
      <AI:FirsttouchCampaign xsi:type="xsd:string"></AI:FirsttouchCampaign>
      <AI:FirsttouchTerm xsi:type="xsd:string"></AI:FirsttouchTerm>
      <AI:FirsttouchContent xsi:type="xsd:string"></AI:FirsttouchContent>
      <AI:FirsttouchReferrerDomain xsi:type="xsd:string"></AI:FirsttouchReferrerDomain>
      <AI:Source xsi:type="xsd:string"></AI:Source>
      <AI:Medium xsi:type="xsd:string"></AI:Medium>
      <AI:Campaign xsi:type="xsd:string"></AI:Campaign>
      <AI:Term xsi:type="xsd:string"></AI:Term>
      <AI:Content xsi:type="xsd:string"></AI:Content>
      <AI:ReferrerDomain xsi:type="xsd:string"></AI:ReferrerDomain>
     </AI:UtmParameters>
     <AI:UserDefinedFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:UserDefinedFields>
     <AI:ExtraFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:ExtraFields>
     <AI:CustomFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:CustomFields>
    </AI:Contact>
    <AI:Person xsi:type="AI:PersonEntity">
     <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
     <AI:Firstname xsi:type="xsd:string"></AI:Firstname>
     <AI:MiddleName xsi:type="xsd:string"></AI:MiddleName>
     <AI:Lastname xsi:type="xsd:string"></AI:Lastname>
     <AI:Mrmrs xsi:type="xsd:string"></AI:Mrmrs>
     <AI:Title xsi:type="xsd:string"></AI:Title>
     <AI:UpdatedDate xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:UpdatedDate>
     <AI:CreatedDate xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:CreatedDate>
     <AI:BirthDate xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:BirthDate>
     <AI:CreatedBy xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:CreatedBy>
     <AI:Emails xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Emails>
     <AI:Description xsi:type="xsd:string"></AI:Description>
     <AI:IsAssociate xsi:type="xsd:boolean">false</AI:IsAssociate>
     <AI:PrivatePhones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:PrivatePhones>
     <AI:Faxes xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Faxes>
     <AI:MobilePhones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:MobilePhones>
     <AI:OfficePhones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:OfficePhones>
     <AI:OtherPhones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:OtherPhones>
     <AI:Position xsi:type="AI:Position">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Position>
     <AI:UpdatedBy xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:UpdatedBy>
     <AI:Contact xsi:type="AI:Contact">
      <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:OrgNr xsi:type="xsd:string"></AI:OrgNr>
      <AI:Department xsi:type="xsd:string"></AI:Department>
      <AI:URL xsi:type="xsd:string"></AI:URL>
      <AI:City xsi:type="xsd:string"></AI:City>
      <AI:DirectPhone xsi:type="xsd:string"></AI:DirectPhone>
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:CountryId xsi:type="xsd:int">0</AI:CountryId>
      <AI:EmailAddress xsi:type="xsd:string"></AI:EmailAddress>
      <AI:Kananame xsi:type="xsd:string"></AI:Kananame>
      <AI:EmailAddressName xsi:type="xsd:string"></AI:EmailAddressName>
      <AI:URLName xsi:type="xsd:string"></AI:URLName>
      <AI:AssociateFullName xsi:type="xsd:string"></AI:AssociateFullName>
      <AI:BusinessName xsi:type="xsd:string"></AI:BusinessName>
      <AI:CategoryName xsi:type="xsd:string"></AI:CategoryName>
      <AI:CountryName xsi:type="xsd:string"></AI:CountryName>
      <AI:Address xsi:type="AI:Address">
       <AI:Wgs84Latitude xsi:type="xsd:double">0.0</AI:Wgs84Latitude>
       <AI:Wgs84Longitude xsi:type="xsd:double">0.0</AI:Wgs84Longitude>
       <AI:LocalizedAddress xsi:type="AI:ArrayOfArrayOfLocalizedField">
        <AI:ArrayOfLocalizedField xsi:type="AI:ArrayOfLocalizedField">
         <AI:LocalizedField xsi:type="AI:LocalizedField">
          <AI:Name xsi:type="xsd:string"></AI:Name>
          <AI:Value xsi:type="xsd:string"></AI:Value>
          <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
          <AI:Label xsi:type="xsd:string"></AI:Label>
          <AI:ValueLength xsi:nil="true"></AI:ValueLength>
          <AI:AddressType xsi:type="xsd:string"></AI:AddressType>
         </AI:LocalizedField>
        </AI:ArrayOfLocalizedField>
       </AI:LocalizedAddress>
       <AI:Street xsi:type="AI:StructuredAddress">
        <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
        <AI:Address1 xsi:type="xsd:string"></AI:Address1>
        <AI:Address2 xsi:type="xsd:string"></AI:Address2>
        <AI:Address3 xsi:type="xsd:string"></AI:Address3>
        <AI:City xsi:type="xsd:string"></AI:City>
        <AI:County xsi:type="xsd:string"></AI:County>
        <AI:State xsi:type="xsd:string"></AI:State>
        <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
        <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
       </AI:Street>
       <AI:Postal xsi:type="AI:StructuredAddress">
        <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
        <AI:Address1 xsi:type="xsd:string"></AI:Address1>
        <AI:Address2 xsi:type="xsd:string"></AI:Address2>
        <AI:Address3 xsi:type="xsd:string"></AI:Address3>
        <AI:City xsi:type="xsd:string"></AI:City>
        <AI:County xsi:type="xsd:string"></AI:County>
        <AI:State xsi:type="xsd:string"></AI:State>
        <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
        <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
       </AI:Postal>
       <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
      </AI:Address>
      <AI:FormattedAddress xsi:type="xsd:string"></AI:FormattedAddress>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:IsOwnerContact xsi:type="xsd:boolean">false</AI:IsOwnerContact>
      <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
      <AI:Number1 xsi:type="xsd:string"></AI:Number1>
      <AI:Number2 xsi:type="xsd:string"></AI:Number2>
     </AI:Contact>
     <AI:Country xsi:type="AI:Country">
      <AI:CountryId xsi:type="xsd:int">0</AI:CountryId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:CurrencyId xsi:type="xsd:int">0</AI:CurrencyId>
      <AI:EnglishName xsi:type="xsd:string"></AI:EnglishName>
      <AI:TwoLetterISOCountry xsi:type="xsd:string"></AI:TwoLetterISOCountry>
      <AI:ThreeLetterISOCountry xsi:type="xsd:string"></AI:ThreeLetterISOCountry>
      <AI:ImageDescription xsi:type="xsd:string"></AI:ImageDescription>
      <AI:OrgNrText xsi:type="xsd:string"></AI:OrgNrText>
      <AI:InterAreaPrefix xsi:type="xsd:string"></AI:InterAreaPrefix>
      <AI:DialInPrefix xsi:type="xsd:string"></AI:DialInPrefix>
      <AI:ZipPrefix xsi:type="xsd:string"></AI:ZipPrefix>
      <AI:DomainName xsi:type="xsd:string"></AI:DomainName>
      <AI:AddressLayoutId xsi:type="xsd:int">0</AI:AddressLayoutId>
      <AI:DomesticAddressLayoutId xsi:type="xsd:int">0</AI:DomesticAddressLayoutId>
      <AI:ForeignAddressLayoutId xsi:type="xsd:int">0</AI:ForeignAddressLayoutId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
     </AI:Country>
     <AI:Interests xsi:type="AI:ArrayOfSelectableMDOListItem">
      <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
       <AI:Id xsi:type="xsd:int">0</AI:Id>
       <AI:Name xsi:type="xsd:string"></AI:Name>
       <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
       <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
       <AI:Rank xsi:type="xsd:int">0</AI:Rank>
       <AI:Type xsi:type="xsd:string"></AI:Type>
       <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
       <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
       <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
       <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
       <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
        <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
         <AI:Id xsi:type="xsd:int">0</AI:Id>
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
         <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
         <AI:Rank xsi:type="xsd:int">0</AI:Rank>
         <AI:Type xsi:type="xsd:string"></AI:Type>
         <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
         <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
         <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
         <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
         <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
          <AI:SelectableMDOListItem xsi:nil="true"></AI:SelectableMDOListItem>
         </AI:ChildItems>
         <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
         <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
         <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
         <AI:FullName xsi:type="xsd:string"></AI:FullName>
        </AI:SelectableMDOListItem>
       </AI:ChildItems>
       <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
       <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
       <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
       <AI:FullName xsi:type="xsd:string"></AI:FullName>
      </AI:SelectableMDOListItem>
     </AI:Interests>
     <AI:PersonNumber xsi:type="xsd:string"></AI:PersonNumber>
     <AI:FullName xsi:type="xsd:string"></AI:FullName>
     <AI:NoMailing xsi:type="xsd:boolean">false</AI:NoMailing>
     <AI:UsePersonAddress xsi:type="xsd:boolean">false</AI:UsePersonAddress>
     <AI:Retired xsi:type="xsd:boolean">false</AI:Retired>
     <AI:Urls xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:Urls>
     <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
     <AI:Address xsi:type="AI:Address">
      <AI:Wgs84Latitude xsi:type="xsd:double">0.0</AI:Wgs84Latitude>
      <AI:Wgs84Longitude xsi:type="xsd:double">0.0</AI:Wgs84Longitude>
      <AI:LocalizedAddress xsi:type="AI:ArrayOfArrayOfLocalizedField">
       <AI:ArrayOfLocalizedField xsi:type="AI:ArrayOfLocalizedField">
        <AI:LocalizedField xsi:type="AI:LocalizedField">
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:Value xsi:type="xsd:string"></AI:Value>
         <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
         <AI:Label xsi:type="xsd:string"></AI:Label>
         <AI:ValueLength xsi:type="xsd:int">0</AI:ValueLength>
         <AI:AddressType xsi:type="xsd:string"></AI:AddressType>
        </AI:LocalizedField>
       </AI:ArrayOfLocalizedField>
      </AI:LocalizedAddress>
      <AI:Street xsi:type="AI:StructuredAddress">
       <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
       <AI:Address1 xsi:type="xsd:string"></AI:Address1>
       <AI:Address2 xsi:type="xsd:string"></AI:Address2>
       <AI:Address3 xsi:type="xsd:string"></AI:Address3>
       <AI:City xsi:type="xsd:string"></AI:City>
       <AI:County xsi:type="xsd:string"></AI:County>
       <AI:State xsi:type="xsd:string"></AI:State>
       <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
       <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
      </AI:Street>
      <AI:Postal xsi:type="AI:StructuredAddress">
       <AI:AtypeIdx xsi:type="AI:AddressType">Unknown</AI:AtypeIdx>
       <AI:Address1 xsi:type="xsd:string"></AI:Address1>
       <AI:Address2 xsi:type="xsd:string"></AI:Address2>
       <AI:Address3 xsi:type="xsd:string"></AI:Address3>
       <AI:City xsi:type="xsd:string"></AI:City>
       <AI:County xsi:type="xsd:string"></AI:County>
       <AI:State xsi:type="xsd:string"></AI:State>
       <AI:Zipcode xsi:type="xsd:string"></AI:Zipcode>
       <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
      </AI:Postal>
      <AI:Formatted xsi:type="xsd:string"></AI:Formatted>
     </AI:Address>
     <AI:Post3 xsi:type="xsd:string"></AI:Post3>
     <AI:Post2 xsi:type="xsd:string"></AI:Post2>
     <AI:Post1 xsi:type="xsd:string"></AI:Post1>
     <AI:Kanalname xsi:type="xsd:string"></AI:Kanalname>
     <AI:Kanafname xsi:type="xsd:string"></AI:Kanafname>
     <AI:CorrespondingAssociate xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:CorrespondingAssociate>
     <AI:Category xsi:type="AI:Category">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Category>
     <AI:Business xsi:type="AI:Business">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Business>
     <AI:Associate xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:Associate>
     <AI:Salutation xsi:type="xsd:string"></AI:Salutation>
     <AI:ActiveInterests xsi:type="xsd:int">0</AI:ActiveInterests>
     <AI:SupportAssociate xsi:type="AI:Associate">
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Type xsi:type="AI:UserType">Unknown</AI:Type>
      <AI:GroupIdx xsi:type="xsd:int">0</AI:GroupIdx>
      <AI:FullName xsi:type="xsd:string"></AI:FullName>
      <AI:FormalName xsi:type="xsd:string"></AI:FormalName>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:ExtraFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:ExtraFields>
      <AI:CustomFields xsi:type="AI:StringDictionary">
       <AI:StringKeyValuePair>
        <AI:Key xsi:type="xsd:string"></AI:Key>
        <AI:Value xsi:type="xsd:string"></AI:Value>
       </AI:StringKeyValuePair>
      </AI:CustomFields>
     </AI:SupportAssociate>
     <AI:TicketPriority xsi:type="AI:TicketPriority">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:TicketPriority>
     <AI:CustomerLanguage xsi:type="AI:CustomerLanguage">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:CustomerLanguage>
     <AI:DbiAgentId xsi:type="xsd:int">0</AI:DbiAgentId>
     <AI:DbiKey xsi:type="xsd:string"></AI:DbiKey>
     <AI:DbiLastModified xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:DbiLastModified>
     <AI:DbiLastSyncronized xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:DbiLastSyncronized>
     <AI:SentInfo xsi:type="xsd:short">0</AI:SentInfo>
     <AI:ShowContactTickets xsi:type="xsd:short">0</AI:ShowContactTickets>
     <AI:UserInfo xsi:type="AI:UserInfo">
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:UserInfoId xsi:type="xsd:int">0</AI:UserInfoId>
      <AI:UserName xsi:type="xsd:string"></AI:UserName>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:UserGroupId xsi:type="xsd:int">0</AI:UserGroupId>
      <AI:EjUserId xsi:type="xsd:int">0</AI:EjUserId>
      <AI:UserType xsi:type="AI:UserType">Unknown</AI:UserType>
      <AI:GrantedLicenses xsi:type="NetServerServices882:ArrayOfstring">
       <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
      </AI:GrantedLicenses>
      <AI:CanLogon xsi:type="xsd:boolean">false</AI:CanLogon>
      <AI:RoleName xsi:type="xsd:string"></AI:RoleName>
      <AI:RoleTooltip xsi:type="xsd:string"></AI:RoleTooltip>
      <AI:UserGroupName xsi:type="xsd:string"></AI:UserGroupName>
      <AI:UserGroupTooltip xsi:type="xsd:string"></AI:UserGroupTooltip>
     </AI:UserInfo>
     <AI:ChatEmails xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:ChatEmails>
     <AI:InternetPhones xsi:type="AI:ArrayOfEntityElement">
      <AI:EntityElement xsi:type="AI:EntityElement">
       <AI:Value xsi:type="xsd:string"></AI:Value>
       <AI:StrippedValue xsi:type="xsd:string"></AI:StrippedValue>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:EntityElement>
     </AI:InternetPhones>
     <AI:Source xsi:type="xsd:short">0</AI:Source>
     <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
     <AI:ShipmentTypes xsi:type="AI:ArrayOfSelectableMDOListItem">
      <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
       <AI:Id xsi:type="xsd:int">0</AI:Id>
       <AI:Name xsi:type="xsd:string"></AI:Name>
       <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
       <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
       <AI:Rank xsi:type="xsd:int">0</AI:Rank>
       <AI:Type xsi:type="xsd:string"></AI:Type>
       <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
       <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
       <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
       <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
       <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
        <AI:SelectableMDOListItem xsi:type="AI:SelectableMDOListItem">
         <AI:Id xsi:type="xsd:int">0</AI:Id>
         <AI:Name xsi:type="xsd:string"></AI:Name>
         <AI:ToolTip xsi:type="xsd:string"></AI:ToolTip>
         <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
         <AI:Rank xsi:type="xsd:int">0</AI:Rank>
         <AI:Type xsi:type="xsd:string"></AI:Type>
         <AI:ColorBlock xsi:type="xsd:int">0</AI:ColorBlock>
         <AI:IconHint xsi:type="xsd:string"></AI:IconHint>
         <AI:Selected xsi:type="xsd:boolean">false</AI:Selected>
         <AI:LastChanged xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:LastChanged>
         <AI:ChildItems xsi:type="AI:ArrayOfSelectableMDOListItem">
          <AI:SelectableMDOListItem xsi:nil="true"></AI:SelectableMDOListItem>
         </AI:ChildItems>
         <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
         <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
         <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
         <AI:FullName xsi:type="xsd:string"></AI:FullName>
        </AI:SelectableMDOListItem>
       </AI:ChildItems>
       <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
       <AI:StyleHint xsi:type="xsd:string"></AI:StyleHint>
       <AI:Hidden xsi:type="xsd:boolean">false</AI:Hidden>
       <AI:FullName xsi:type="xsd:string"></AI:FullName>
      </AI:SelectableMDOListItem>
     </AI:ShipmentTypes>
     <AI:Consents xsi:type="AI:ArrayOfConsentInfo">
      <AI:ConsentInfo xsi:type="AI:ConsentInfo">
       <AI:ConsentPersonId xsi:type="xsd:int">0</AI:ConsentPersonId>
       <AI:Comment xsi:type="xsd:string"></AI:Comment>
       <AI:Registered xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:Registered>
       <AI:RegisteredAssociateId xsi:type="xsd:int">0</AI:RegisteredAssociateId>
       <AI:Updated xsi:type="xsd:dateTime">2025-09-19T01:39:12Z</AI:Updated>
       <AI:UpdatedAssociateId xsi:type="xsd:int">0</AI:UpdatedAssociateId>
       <AI:LegalBaseId xsi:type="xsd:int">0</AI:LegalBaseId>
       <AI:LegalBaseKey xsi:type="xsd:string"></AI:LegalBaseKey>
       <AI:LegalBaseName xsi:type="xsd:string"></AI:LegalBaseName>
       <AI:ConsentPurposeId xsi:type="xsd:int">0</AI:ConsentPurposeId>
       <AI:ConsentPurposeKey xsi:type="xsd:string"></AI:ConsentPurposeKey>
       <AI:ConsentPurposeName xsi:type="xsd:string"></AI:ConsentPurposeName>
       <AI:ConsentSourceId xsi:type="xsd:int">0</AI:ConsentSourceId>
       <AI:ConsentSourceKey xsi:type="xsd:string"></AI:ConsentSourceKey>
       <AI:ConsentSourceName xsi:type="xsd:string"></AI:ConsentSourceName>
      </AI:ConsentInfo>
     </AI:Consents>
     <AI:BounceEmails xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </AI:BounceEmails>
     <AI:ActiveStatusMonitorId xsi:type="xsd:int">0</AI:ActiveStatusMonitorId>
     <AI:CreatedByFormId xsi:type="xsd:int">0</AI:CreatedByFormId>
     <AI:UtmParameters xsi:type="AI:SavedUtmParameters">
      <AI:FormName xsi:type="xsd:string"></AI:FormName>
      <AI:FirsttouchSource xsi:type="xsd:string"></AI:FirsttouchSource>
      <AI:FirsttouchMedium xsi:type="xsd:string"></AI:FirsttouchMedium>
      <AI:FirsttouchCampaign xsi:type="xsd:string"></AI:FirsttouchCampaign>
      <AI:FirsttouchTerm xsi:type="xsd:string"></AI:FirsttouchTerm>
      <AI:FirsttouchContent xsi:type="xsd:string"></AI:FirsttouchContent>
      <AI:FirsttouchReferrerDomain xsi:type="xsd:string"></AI:FirsttouchReferrerDomain>
      <AI:Source xsi:type="xsd:string"></AI:Source>
      <AI:Medium xsi:type="xsd:string"></AI:Medium>
      <AI:Campaign xsi:type="xsd:string"></AI:Campaign>
      <AI:Term xsi:type="xsd:string"></AI:Term>
      <AI:Content xsi:type="xsd:string"></AI:Content>
      <AI:ReferrerDomain xsi:type="xsd:string"></AI:ReferrerDomain>
     </AI:UtmParameters>
     <AI:LeadstatusId xsi:type="xsd:int">0</AI:LeadstatusId>
     <AI:UserDefinedFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:UserDefinedFields>
     <AI:ExtraFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:ExtraFields>
     <AI:CustomFields xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:CustomFields>
    </AI:Person>
    <AI:LogoImage xsi:type="xsd:string"></AI:LogoImage>
    <AI:PhotoImage xsi:type="xsd:string"></AI:PhotoImage>
   </AI:Response>
  </AI:AnalyzeBizCardTextResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

