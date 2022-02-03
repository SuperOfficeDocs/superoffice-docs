---
title: Services88.ContactAgent.GetMyBizCard SOAP
generated: 1
uid: Services88-Contact-GetMyBizCard
---

# Services88 Contact GetMyBizCard

SOAP request and response examples **Remote/Services88/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IContactAgent.GetMyBizCard">SuperOffice.Services88.IContactAgent.GetMyBizCard</see> method.

## GetMyBizCard

Returns all data needed to display the logged on person's business card. That is company, person, and company interest data.


**Returns:** The contact object with persons and interests


[WSDL file for Services88/Contact](../Services88-Contact.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetMyBizCard Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetMyBizCard>
   </Contact:GetMyBizCard>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetMyBizCard Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Contact:GetMyBizCardResponse>
   <Contact:Response xsi:type="Contact:ContactEntity">
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:Name xsi:type="xsd:string"></Contact:Name>
    <Contact:Department xsi:type="xsd:string"></Contact:Department>
    <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
    <Contact:Number1 xsi:type="xsd:string"></Contact:Number1>
    <Contact:Number2 xsi:type="xsd:string"></Contact:Number2>
    <Contact:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:UpdatedDate>
    <Contact:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:CreatedDate>
    <Contact:Emails xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Emails>
    <Contact:Interests xsi:type="Contact:ArrayOfSelectableMDOListItem">
     <Contact:SelectableMDOListItem xsi:type="Contact:SelectableMDOListItem">
      <Contact:Id xsi:type="xsd:int">0</Contact:Id>
      <Contact:Name xsi:type="xsd:string"></Contact:Name>
      <Contact:ToolTip xsi:type="xsd:string"></Contact:ToolTip>
      <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
      <Contact:Rank xsi:type="xsd:int">0</Contact:Rank>
      <Contact:Type xsi:type="xsd:string"></Contact:Type>
      <Contact:ColorBlock xsi:type="xsd:int">0</Contact:ColorBlock>
      <Contact:IconHint xsi:type="xsd:string"></Contact:IconHint>
      <Contact:Selected xsi:type="xsd:boolean">false</Contact:Selected>
      <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:LastChanged>
      <Contact:ChildItems xsi:type="Contact:ArrayOfSelectableMDOListItem">
       <Contact:SelectableMDOListItem xsi:type="Contact:SelectableMDOListItem">
        <Contact:Id xsi:type="xsd:int">0</Contact:Id>
        <Contact:Name xsi:type="xsd:string"></Contact:Name>
        <Contact:ToolTip xsi:type="xsd:string"></Contact:ToolTip>
        <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
        <Contact:Rank xsi:type="xsd:int">0</Contact:Rank>
        <Contact:Type xsi:type="xsd:string"></Contact:Type>
        <Contact:ColorBlock xsi:type="xsd:int">0</Contact:ColorBlock>
        <Contact:IconHint xsi:type="xsd:string"></Contact:IconHint>
        <Contact:Selected xsi:type="xsd:boolean">false</Contact:Selected>
        <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:LastChanged>
        <Contact:ChildItems xsi:type="Contact:ArrayOfSelectableMDOListItem">
         <Contact:SelectableMDOListItem xsi:type="Contact:SelectableMDOListItem">
          <Contact:Id xsi:nil="true"></Contact:Id>
          <Contact:Name xsi:type="xsd:string"></Contact:Name>
          <Contact:ToolTip xsi:type="xsd:string"></Contact:ToolTip>
          <Contact:Deleted xsi:nil="true"></Contact:Deleted>
          <Contact:Rank xsi:nil="true"></Contact:Rank>
          <Contact:Type xsi:type="xsd:string"></Contact:Type>
          <Contact:ColorBlock xsi:nil="true"></Contact:ColorBlock>
          <Contact:IconHint xsi:type="xsd:string"></Contact:IconHint>
          <Contact:Selected xsi:nil="true"></Contact:Selected>
          <Contact:LastChanged xsi:nil="true"></Contact:LastChanged>
          <Contact:ChildItems xsi:nil="true"></Contact:ChildItems>
          <Contact:ExtraInfo xsi:type="xsd:string"></Contact:ExtraInfo>
          <Contact:StyleHint xsi:type="xsd:string"></Contact:StyleHint>
          <Contact:Hidden xsi:nil="true"></Contact:Hidden>
          <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
         </Contact:SelectableMDOListItem>
        </Contact:ChildItems>
        <Contact:ExtraInfo xsi:type="xsd:string"></Contact:ExtraInfo>
        <Contact:StyleHint xsi:type="xsd:string"></Contact:StyleHint>
        <Contact:Hidden xsi:type="xsd:boolean">false</Contact:Hidden>
        <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
       </Contact:SelectableMDOListItem>
      </Contact:ChildItems>
      <Contact:ExtraInfo xsi:type="xsd:string"></Contact:ExtraInfo>
      <Contact:StyleHint xsi:type="xsd:string"></Contact:StyleHint>
      <Contact:Hidden xsi:type="xsd:boolean">false</Contact:Hidden>
      <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     </Contact:SelectableMDOListItem>
    </Contact:Interests>
    <Contact:Urls xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Urls>
    <Contact:Phones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Phones>
    <Contact:Faxes xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Faxes>
    <Contact:Description xsi:type="xsd:string"></Contact:Description>
    <Contact:UpdatedBy xsi:type="Contact:Associate">
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:Type xsi:type="Contact:UserType">Unknown</Contact:Type>
     <Contact:GroupIdx xsi:type="xsd:int">0</Contact:GroupIdx>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
     <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
     <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
    </Contact:UpdatedBy>
    <Contact:CreatedBy xsi:type="Contact:Associate">
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:Type xsi:type="Contact:UserType">Unknown</Contact:Type>
     <Contact:GroupIdx xsi:type="xsd:int">0</Contact:GroupIdx>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
     <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
     <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
    </Contact:CreatedBy>
    <Contact:Associate xsi:type="Contact:Associate">
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:Type xsi:type="Contact:UserType">Unknown</Contact:Type>
     <Contact:GroupIdx xsi:type="xsd:int">0</Contact:GroupIdx>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
     <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
     <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
    </Contact:Associate>
    <Contact:Business xsi:type="Contact:Business">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:Business>
    <Contact:Category xsi:type="Contact:Category">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:Category>
    <Contact:Country xsi:type="Contact:Country">
     <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:CurrencyId xsi:type="xsd:int">0</Contact:CurrencyId>
     <Contact:EnglishName xsi:type="xsd:string"></Contact:EnglishName>
     <Contact:TwoLetterISOCountry xsi:type="xsd:string"></Contact:TwoLetterISOCountry>
     <Contact:ThreeLetterISOCountry xsi:type="xsd:string"></Contact:ThreeLetterISOCountry>
     <Contact:ImageDescription xsi:type="xsd:string"></Contact:ImageDescription>
     <Contact:OrgNrText xsi:type="xsd:string"></Contact:OrgNrText>
     <Contact:InterAreaPrefix xsi:type="xsd:string"></Contact:InterAreaPrefix>
     <Contact:DialInPrefix xsi:type="xsd:string"></Contact:DialInPrefix>
     <Contact:ZipPrefix xsi:type="xsd:string"></Contact:ZipPrefix>
     <Contact:DomainName xsi:type="xsd:string"></Contact:DomainName>
     <Contact:AddressLayoutId xsi:type="xsd:int">0</Contact:AddressLayoutId>
     <Contact:DomesticAddressLayoutId xsi:type="xsd:int">0</Contact:DomesticAddressLayoutId>
     <Contact:ForeignAddressLayoutId xsi:type="xsd:int">0</Contact:ForeignAddressLayoutId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
    </Contact:Country>
    <Contact:Persons xsi:type="Contact:ArrayOfPerson">
     <Contact:Person xsi:type="Contact:Person">
      <Contact:Position xsi:type="xsd:string"></Contact:Position>
      <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
      <Contact:Mrmrs xsi:type="xsd:string"></Contact:Mrmrs>
      <Contact:Firstname xsi:type="xsd:string"></Contact:Firstname>
      <Contact:Lastname xsi:type="xsd:string"></Contact:Lastname>
      <Contact:MiddleName xsi:type="xsd:string"></Contact:MiddleName>
      <Contact:Title xsi:type="xsd:string"></Contact:Title>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
      <Contact:Email xsi:type="xsd:string"></Contact:Email>
      <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
      <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
      <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
      <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
      <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
      <Contact:ContactName xsi:type="xsd:string"></Contact:ContactName>
      <Contact:Retired xsi:type="xsd:short">0</Contact:Retired>
      <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
      <Contact:ActiveInterests xsi:type="xsd:short">0</Contact:ActiveInterests>
      <Contact:ContactDepartment xsi:type="xsd:string"></Contact:ContactDepartment>
      <Contact:ContactCountryId xsi:type="xsd:int">0</Contact:ContactCountryId>
      <Contact:ContactOrgNr xsi:type="xsd:string"></Contact:ContactOrgNr>
      <Contact:FaxPhone xsi:type="xsd:string"></Contact:FaxPhone>
      <Contact:MobilePhone xsi:type="xsd:string"></Contact:MobilePhone>
      <Contact:ContactPhone xsi:type="xsd:string"></Contact:ContactPhone>
      <Contact:AssociateName xsi:type="xsd:string"></Contact:AssociateName>
      <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
      <Contact:UsePersonAddress xsi:type="xsd:boolean">false</Contact:UsePersonAddress>
      <Contact:ContactFax xsi:type="xsd:string"></Contact:ContactFax>
      <Contact:Kanafname xsi:type="xsd:string"></Contact:Kanafname>
      <Contact:Kanalname xsi:type="xsd:string"></Contact:Kanalname>
      <Contact:Post1 xsi:type="xsd:string"></Contact:Post1>
      <Contact:Post2 xsi:type="xsd:string"></Contact:Post2>
      <Contact:Post3 xsi:type="xsd:string"></Contact:Post3>
      <Contact:EmailName xsi:type="xsd:string"></Contact:EmailName>
      <Contact:ContactFullName xsi:type="xsd:string"></Contact:ContactFullName>
      <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
      <Contact:TicketPriorityId xsi:type="xsd:int">0</Contact:TicketPriorityId>
      <Contact:SupportLanguageId xsi:type="xsd:int">0</Contact:SupportLanguageId>
      <Contact:SupportAssociateId xsi:type="xsd:int">0</Contact:SupportAssociateId>
      <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
     </Contact:Person>
    </Contact:Persons>
    <Contact:NoMailing xsi:type="xsd:boolean">false</Contact:NoMailing>
    <Contact:Kananame xsi:type="xsd:string"></Contact:Kananame>
    <Contact:Xstop xsi:type="xsd:boolean">false</Contact:Xstop>
    <Contact:ActiveInterests xsi:type="xsd:int">0</Contact:ActiveInterests>
    <Contact:GroupId xsi:type="xsd:int">0</Contact:GroupId>
    <Contact:ActiveStatusMonitorId xsi:type="xsd:int">0</Contact:ActiveStatusMonitorId>
    <Contact:SupportAssociate xsi:type="Contact:Associate">
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:Type xsi:type="Contact:UserType">Unknown</Contact:Type>
     <Contact:GroupIdx xsi:type="xsd:int">0</Contact:GroupIdx>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
     <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
     <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
    </Contact:SupportAssociate>
    <Contact:TicketPriority xsi:type="Contact:TicketPriority">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:TicketPriority>
    <Contact:CustomerLanguage xsi:type="Contact:CustomerLanguage">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:CustomerLanguage>
    <Contact:Deleted xsi:type="xsd:short">0</Contact:Deleted>
    <Contact:DbiAgentId xsi:type="xsd:int">0</Contact:DbiAgentId>
    <Contact:DbiLastSyncronized xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:DbiLastSyncronized>
    <Contact:DbiKey xsi:type="xsd:string"></Contact:DbiKey>
    <Contact:DbiLastModified xsi:type="xsd:dateTime">2021-11-30T13:23:35Z</Contact:DbiLastModified>
    <Contact:SupportPerson xsi:type="Contact:Person">
     <Contact:Position xsi:type="xsd:string"></Contact:Position>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Mrmrs xsi:type="xsd:string"></Contact:Mrmrs>
     <Contact:Firstname xsi:type="xsd:string"></Contact:Firstname>
     <Contact:Lastname xsi:type="xsd:string"></Contact:Lastname>
     <Contact:MiddleName xsi:type="xsd:string"></Contact:MiddleName>
     <Contact:Title xsi:type="xsd:string"></Contact:Title>
     <Contact:Description xsi:type="xsd:string"></Contact:Description>
     <Contact:Email xsi:type="xsd:string"></Contact:Email>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
     <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
     <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
     <Contact:ContactName xsi:type="xsd:string"></Contact:ContactName>
     <Contact:Retired xsi:type="xsd:short">0</Contact:Retired>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:ActiveInterests xsi:type="xsd:short">0</Contact:ActiveInterests>
     <Contact:ContactDepartment xsi:type="xsd:string"></Contact:ContactDepartment>
     <Contact:ContactCountryId xsi:type="xsd:int">0</Contact:ContactCountryId>
     <Contact:ContactOrgNr xsi:type="xsd:string"></Contact:ContactOrgNr>
     <Contact:FaxPhone xsi:type="xsd:string"></Contact:FaxPhone>
     <Contact:MobilePhone xsi:type="xsd:string"></Contact:MobilePhone>
     <Contact:ContactPhone xsi:type="xsd:string"></Contact:ContactPhone>
     <Contact:AssociateName xsi:type="xsd:string"></Contact:AssociateName>
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:UsePersonAddress xsi:type="xsd:boolean">false</Contact:UsePersonAddress>
     <Contact:ContactFax xsi:type="xsd:string"></Contact:ContactFax>
     <Contact:Kanafname xsi:type="xsd:string"></Contact:Kanafname>
     <Contact:Kanalname xsi:type="xsd:string"></Contact:Kanalname>
     <Contact:Post1 xsi:type="xsd:string"></Contact:Post1>
     <Contact:Post2 xsi:type="xsd:string"></Contact:Post2>
     <Contact:Post3 xsi:type="xsd:string"></Contact:Post3>
     <Contact:EmailName xsi:type="xsd:string"></Contact:EmailName>
     <Contact:ContactFullName xsi:type="xsd:string"></Contact:ContactFullName>
     <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
     <Contact:TicketPriorityId xsi:type="xsd:int">0</Contact:TicketPriorityId>
     <Contact:SupportLanguageId xsi:type="xsd:int">0</Contact:SupportLanguageId>
     <Contact:SupportAssociateId xsi:type="xsd:int">0</Contact:SupportAssociateId>
     <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
    </Contact:SupportPerson>
    <Contact:Address xsi:type="Contact:Address">
     <Contact:Wgs84Latitude xsi:type="xsd:double">0.0</Contact:Wgs84Latitude>
     <Contact:Wgs84Longitude xsi:type="xsd:double">0.0</Contact:Wgs84Longitude>
     <Contact:LocalizedAddress xsi:type="Contact:ArrayOfArrayOfLocalizedField">
      <Contact:ArrayOfLocalizedField xsi:type="Contact:ArrayOfLocalizedField">
       <Contact:LocalizedField xsi:type="Contact:LocalizedField">
        <Contact:Name xsi:type="xsd:string"></Contact:Name>
        <Contact:Value xsi:type="xsd:string"></Contact:Value>
        <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
        <Contact:Label xsi:type="xsd:string"></Contact:Label>
        <Contact:ValueLength xsi:type="xsd:int">0</Contact:ValueLength>
        <Contact:AddressType xsi:type="xsd:string"></Contact:AddressType>
       </Contact:LocalizedField>
      </Contact:ArrayOfLocalizedField>
     </Contact:LocalizedAddress>
     <Contact:Street xsi:type="Contact:StructuredAddress">
      <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
      <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
      <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
      <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
      <Contact:City xsi:type="xsd:string"></Contact:City>
      <Contact:County xsi:type="xsd:string"></Contact:County>
      <Contact:State xsi:type="xsd:string"></Contact:State>
      <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
      <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
     </Contact:Street>
     <Contact:Postal xsi:type="Contact:StructuredAddress">
      <Contact:AtypeIdx xsi:type="Contact:AddressType">Unknown</Contact:AtypeIdx>
      <Contact:Address1 xsi:type="xsd:string"></Contact:Address1>
      <Contact:Address2 xsi:type="xsd:string"></Contact:Address2>
      <Contact:Address3 xsi:type="xsd:string"></Contact:Address3>
      <Contact:City xsi:type="xsd:string"></Contact:City>
      <Contact:County xsi:type="xsd:string"></Contact:County>
      <Contact:State xsi:type="xsd:string"></Contact:State>
      <Contact:Zipcode xsi:type="xsd:string"></Contact:Zipcode>
      <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
     </Contact:Postal>
     <Contact:Formatted xsi:type="xsd:string"></Contact:Formatted>
    </Contact:Address>
    <Contact:Source xsi:type="xsd:short">0</Contact:Source>
    <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
    <Contact:BounceEmails xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Contact:BounceEmails>
    <Contact:Domains xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Contact:Domains>
    <Contact:UserDefinedFields xsi:type="Contact:StringDictionary">
     <Contact:StringKeyValuePair>
      <Contact:Key xsi:type="xsd:string"></Contact:Key>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
     </Contact:StringKeyValuePair>
    </Contact:UserDefinedFields>
    <Contact:ExtraFields xsi:type="Contact:StringDictionary">
     <Contact:StringKeyValuePair>
      <Contact:Key xsi:type="xsd:string"></Contact:Key>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
     </Contact:StringKeyValuePair>
    </Contact:ExtraFields>
    <Contact:CustomFields xsi:type="Contact:StringDictionary">
     <Contact:StringKeyValuePair>
      <Contact:Key xsi:type="xsd:string"></Contact:Key>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
     </Contact:StringKeyValuePair>
    </Contact:CustomFields>
   </Contact:Response>
  </Contact:GetMyBizCardResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

