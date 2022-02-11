---
title: Services86.ContactAgent.AddPerson SOAP
generated: 1
uid: Services86-Contact-AddPerson
---

# Services86 Contact AddPerson

SOAP request and response examples **Remote/Services86/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IContactAgent.AddPerson">SuperOffice.Services86.IContactAgent.AddPerson</see> method.

## AddPerson

Add a person to the given contact

* **contactId:** Contact to add person to
* **newPersonEntity:** Person object to add

**Returns:** Updated person object


[WSDL file for Services86/Contact](../Services86-Contact.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddPerson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:AddPerson>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:NewPersonEntity xsi:type="Contact:PersonEntity">
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Firstname xsi:type="xsd:string"></Contact:Firstname>
     <Contact:MiddleName xsi:type="xsd:string"></Contact:MiddleName>
     <Contact:Lastname xsi:type="xsd:string"></Contact:Lastname>
     <Contact:Mrmrs xsi:type="xsd:string"></Contact:Mrmrs>
     <Contact:Title xsi:type="xsd:string"></Contact:Title>
     <Contact:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:UpdatedDate>
     <Contact:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:CreatedDate>
     <Contact:BirthDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:BirthDate>
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
     <Contact:Emails xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:Emails>
     <Contact:Description xsi:type="xsd:string"></Contact:Description>
     <Contact:IsAssociate xsi:type="xsd:boolean">false</Contact:IsAssociate>
     <Contact:PrivatePhones xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:PrivatePhones>
     <Contact:Faxes xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:Faxes>
     <Contact:MobilePhones xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:MobilePhones>
     <Contact:OfficePhones xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:OfficePhones>
     <Contact:OtherPhones xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:OtherPhones>
     <Contact:Position xsi:type="Contact:Position">
      <Contact:Id xsi:type="xsd:int">0</Contact:Id>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     </Contact:Position>
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
     <Contact:Contact xsi:type="Contact:Contact">
      <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
      <Contact:Name xsi:type="xsd:string"></Contact:Name>
      <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
      <Contact:Department xsi:type="xsd:string"></Contact:Department>
      <Contact:URL xsi:type="xsd:string"></Contact:URL>
      <Contact:City xsi:type="xsd:string"></Contact:City>
      <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
      <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
      <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
      <Contact:EmailAddress xsi:type="xsd:string"></Contact:EmailAddress>
      <Contact:Kananame xsi:type="xsd:string"></Contact:Kananame>
      <Contact:EmailAddressName xsi:type="xsd:string"></Contact:EmailAddressName>
      <Contact:URLName xsi:type="xsd:string"></Contact:URLName>
      <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
      <Contact:BusinessName xsi:type="xsd:string"></Contact:BusinessName>
      <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
      <Contact:CountryName xsi:type="xsd:string"></Contact:CountryName>
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
          <Contact:ValueLength xsi:nil="true"></Contact:ValueLength>
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
       </Contact:Postal>
      </Contact:Address>
      <Contact:FormattedAddress xsi:type="xsd:string"></Contact:FormattedAddress>
      <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
      <Contact:IsOwnerContact xsi:type="xsd:boolean">false</Contact:IsOwnerContact>
      <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
     </Contact:Contact>
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
       <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
         <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
         <Contact:ChildItems xsi:type="Contact:ArrayOfSelectableMDOListItem">
          <Contact:SelectableMDOListItem xsi:nil="true"></Contact:SelectableMDOListItem>
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
     <Contact:PersonNumber xsi:type="xsd:string"></Contact:PersonNumber>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:NoMailing xsi:type="xsd:boolean">false</Contact:NoMailing>
     <Contact:UsePersonAddress xsi:type="xsd:boolean">false</Contact:UsePersonAddress>
     <Contact:Retired xsi:type="xsd:boolean">false</Contact:Retired>
     <Contact:Urls xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:Urls>
     <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
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
      </Contact:Postal>
     </Contact:Address>
     <Contact:Post3 xsi:type="xsd:string"></Contact:Post3>
     <Contact:Post2 xsi:type="xsd:string"></Contact:Post2>
     <Contact:Post1 xsi:type="xsd:string"></Contact:Post1>
     <Contact:Kanalname xsi:type="xsd:string"></Contact:Kanalname>
     <Contact:Kanafname xsi:type="xsd:string"></Contact:Kanafname>
     <Contact:CorrespondingAssociate xsi:type="Contact:Associate">
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
     </Contact:CorrespondingAssociate>
     <Contact:Category xsi:type="Contact:Category">
      <Contact:Id xsi:type="xsd:int">0</Contact:Id>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     </Contact:Category>
     <Contact:Business xsi:type="Contact:Business">
      <Contact:Id xsi:type="xsd:int">0</Contact:Id>
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     </Contact:Business>
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
     <Contact:Salutation xsi:type="xsd:string"></Contact:Salutation>
     <Contact:ActiveInterests xsi:type="xsd:int">0</Contact:ActiveInterests>
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
     <Contact:DbiAgentId xsi:type="xsd:int">0</Contact:DbiAgentId>
     <Contact:DbiKey xsi:type="xsd:string"></Contact:DbiKey>
     <Contact:DbiLastModified xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:DbiLastModified>
     <Contact:DbiLastSyncronized xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:DbiLastSyncronized>
     <Contact:SentInfo xsi:type="xsd:short">0</Contact:SentInfo>
     <Contact:ShowContactTickets xsi:type="xsd:short">0</Contact:ShowContactTickets>
     <Contact:UserInfo xsi:type="Contact:UserInfo">
      <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
      <Contact:UserInfoId xsi:type="xsd:int">0</Contact:UserInfoId>
      <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
      <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
      <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
      <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
      <Contact:UserGroupId xsi:type="xsd:int">0</Contact:UserGroupId>
      <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
      <Contact:UserType xsi:type="Contact:UserType">Unknown</Contact:UserType>
      <Contact:GrantedLicenses xsi:type="NetServerServices862:ArrayOfstring">
       <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
      </Contact:GrantedLicenses>
      <Contact:CanLogon xsi:type="xsd:boolean">false</Contact:CanLogon>
      <Contact:RoleName xsi:type="xsd:string"></Contact:RoleName>
      <Contact:RoleTooltip xsi:type="xsd:string"></Contact:RoleTooltip>
      <Contact:UserGroupName xsi:type="xsd:string"></Contact:UserGroupName>
      <Contact:UserGroupTooltip xsi:type="xsd:string"></Contact:UserGroupTooltip>
     </Contact:UserInfo>
     <Contact:ChatEmails xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:ChatEmails>
     <Contact:InternetPhones xsi:type="Contact:ArrayOfEntityElement">
      <Contact:EntityElement xsi:type="Contact:EntityElement">
       <Contact:Value xsi:type="xsd:string"></Contact:Value>
       <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
       <Contact:Description xsi:type="xsd:string"></Contact:Description>
      </Contact:EntityElement>
     </Contact:InternetPhones>
     <Contact:Source xsi:type="xsd:short">0</Contact:Source>
     <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
     <Contact:ShipmentTypes xsi:type="Contact:ArrayOfSelectableMDOListItem">
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
       <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
         <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
         <Contact:ChildItems xsi:type="Contact:ArrayOfSelectableMDOListItem">
          <Contact:SelectableMDOListItem xsi:nil="true"></Contact:SelectableMDOListItem>
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
     </Contact:ShipmentTypes>
     <Contact:Consents xsi:type="Contact:ArrayOfConsentInfo">
      <Contact:ConsentInfo xsi:type="Contact:ConsentInfo">
       <Contact:ConsentPersonId xsi:type="xsd:int">0</Contact:ConsentPersonId>
       <Contact:Comment xsi:type="xsd:string"></Contact:Comment>
       <Contact:Registered xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:Registered>
       <Contact:RegisteredAssociateId xsi:type="xsd:int">0</Contact:RegisteredAssociateId>
       <Contact:Updated xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:Updated>
       <Contact:UpdatedAssociateId xsi:type="xsd:int">0</Contact:UpdatedAssociateId>
       <Contact:LegalBaseId xsi:type="xsd:int">0</Contact:LegalBaseId>
       <Contact:LegalBaseKey xsi:type="xsd:string"></Contact:LegalBaseKey>
       <Contact:LegalBaseName xsi:type="xsd:string"></Contact:LegalBaseName>
       <Contact:ConsentPurposeId xsi:type="xsd:int">0</Contact:ConsentPurposeId>
       <Contact:ConsentPurposeKey xsi:type="xsd:string"></Contact:ConsentPurposeKey>
       <Contact:ConsentPurposeName xsi:type="xsd:string"></Contact:ConsentPurposeName>
       <Contact:ConsentSourceId xsi:type="xsd:int">0</Contact:ConsentSourceId>
       <Contact:ConsentSourceKey xsi:type="xsd:string"></Contact:ConsentSourceKey>
       <Contact:ConsentSourceName xsi:type="xsd:string"></Contact:ConsentSourceName>
      </Contact:ConsentInfo>
     </Contact:Consents>
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
    </Contact:NewPersonEntity>
   </Contact:AddPerson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddPerson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Contact:AddPersonResponse>
   <Contact:Response xsi:type="Contact:PersonEntity">
    <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
    <Contact:Firstname xsi:type="xsd:string"></Contact:Firstname>
    <Contact:MiddleName xsi:type="xsd:string"></Contact:MiddleName>
    <Contact:Lastname xsi:type="xsd:string"></Contact:Lastname>
    <Contact:Mrmrs xsi:type="xsd:string"></Contact:Mrmrs>
    <Contact:Title xsi:type="xsd:string"></Contact:Title>
    <Contact:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:UpdatedDate>
    <Contact:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:CreatedDate>
    <Contact:BirthDate xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:BirthDate>
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
    <Contact:Emails xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Emails>
    <Contact:Description xsi:type="xsd:string"></Contact:Description>
    <Contact:IsAssociate xsi:type="xsd:boolean">false</Contact:IsAssociate>
    <Contact:PrivatePhones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:PrivatePhones>
    <Contact:Faxes xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Faxes>
    <Contact:MobilePhones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:MobilePhones>
    <Contact:OfficePhones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:OfficePhones>
    <Contact:OtherPhones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:OtherPhones>
    <Contact:Position xsi:type="Contact:Position">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:Position>
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
    <Contact:Contact xsi:type="Contact:Contact">
     <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
     <Contact:Name xsi:type="xsd:string"></Contact:Name>
     <Contact:OrgNr xsi:type="xsd:string"></Contact:OrgNr>
     <Contact:Department xsi:type="xsd:string"></Contact:Department>
     <Contact:URL xsi:type="xsd:string"></Contact:URL>
     <Contact:City xsi:type="xsd:string"></Contact:City>
     <Contact:DirectPhone xsi:type="xsd:string"></Contact:DirectPhone>
     <Contact:AssociateId xsi:type="xsd:int">0</Contact:AssociateId>
     <Contact:CountryId xsi:type="xsd:int">0</Contact:CountryId>
     <Contact:EmailAddress xsi:type="xsd:string"></Contact:EmailAddress>
     <Contact:Kananame xsi:type="xsd:string"></Contact:Kananame>
     <Contact:EmailAddressName xsi:type="xsd:string"></Contact:EmailAddressName>
     <Contact:URLName xsi:type="xsd:string"></Contact:URLName>
     <Contact:AssociateFullName xsi:type="xsd:string"></Contact:AssociateFullName>
     <Contact:BusinessName xsi:type="xsd:string"></Contact:BusinessName>
     <Contact:CategoryName xsi:type="xsd:string"></Contact:CategoryName>
     <Contact:CountryName xsi:type="xsd:string"></Contact:CountryName>
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
      </Contact:Postal>
     </Contact:Address>
     <Contact:FormattedAddress xsi:type="xsd:string"></Contact:FormattedAddress>
     <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
     <Contact:IsOwnerContact xsi:type="xsd:boolean">false</Contact:IsOwnerContact>
     <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
    </Contact:Contact>
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
      <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
        <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
    <Contact:PersonNumber xsi:type="xsd:string"></Contact:PersonNumber>
    <Contact:FullName xsi:type="xsd:string"></Contact:FullName>
    <Contact:NoMailing xsi:type="xsd:boolean">false</Contact:NoMailing>
    <Contact:UsePersonAddress xsi:type="xsd:boolean">false</Contact:UsePersonAddress>
    <Contact:Retired xsi:type="xsd:boolean">false</Contact:Retired>
    <Contact:Urls xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:Urls>
    <Contact:FormalName xsi:type="xsd:string"></Contact:FormalName>
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
     </Contact:Postal>
    </Contact:Address>
    <Contact:Post3 xsi:type="xsd:string"></Contact:Post3>
    <Contact:Post2 xsi:type="xsd:string"></Contact:Post2>
    <Contact:Post1 xsi:type="xsd:string"></Contact:Post1>
    <Contact:Kanalname xsi:type="xsd:string"></Contact:Kanalname>
    <Contact:Kanafname xsi:type="xsd:string"></Contact:Kanafname>
    <Contact:CorrespondingAssociate xsi:type="Contact:Associate">
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
    </Contact:CorrespondingAssociate>
    <Contact:Category xsi:type="Contact:Category">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:Category>
    <Contact:Business xsi:type="Contact:Business">
     <Contact:Id xsi:type="xsd:int">0</Contact:Id>
     <Contact:Value xsi:type="xsd:string"></Contact:Value>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
    </Contact:Business>
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
    <Contact:Salutation xsi:type="xsd:string"></Contact:Salutation>
    <Contact:ActiveInterests xsi:type="xsd:int">0</Contact:ActiveInterests>
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
    <Contact:DbiAgentId xsi:type="xsd:int">0</Contact:DbiAgentId>
    <Contact:DbiKey xsi:type="xsd:string"></Contact:DbiKey>
    <Contact:DbiLastModified xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:DbiLastModified>
    <Contact:DbiLastSyncronized xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:DbiLastSyncronized>
    <Contact:SentInfo xsi:type="xsd:short">0</Contact:SentInfo>
    <Contact:ShowContactTickets xsi:type="xsd:short">0</Contact:ShowContactTickets>
    <Contact:UserInfo xsi:type="Contact:UserInfo">
     <Contact:Deleted xsi:type="xsd:boolean">false</Contact:Deleted>
     <Contact:UserInfoId xsi:type="xsd:int">0</Contact:UserInfoId>
     <Contact:UserName xsi:type="xsd:string"></Contact:UserName>
     <Contact:PersonId xsi:type="xsd:int">0</Contact:PersonId>
     <Contact:Rank xsi:type="xsd:short">0</Contact:Rank>
     <Contact:Tooltip xsi:type="xsd:string"></Contact:Tooltip>
     <Contact:UserGroupId xsi:type="xsd:int">0</Contact:UserGroupId>
     <Contact:EjUserId xsi:type="xsd:int">0</Contact:EjUserId>
     <Contact:UserType xsi:type="Contact:UserType">Unknown</Contact:UserType>
     <Contact:GrantedLicenses xsi:type="NetServerServices862:ArrayOfstring">
      <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
     </Contact:GrantedLicenses>
     <Contact:CanLogon xsi:type="xsd:boolean">false</Contact:CanLogon>
     <Contact:RoleName xsi:type="xsd:string"></Contact:RoleName>
     <Contact:RoleTooltip xsi:type="xsd:string"></Contact:RoleTooltip>
     <Contact:UserGroupName xsi:type="xsd:string"></Contact:UserGroupName>
     <Contact:UserGroupTooltip xsi:type="xsd:string"></Contact:UserGroupTooltip>
    </Contact:UserInfo>
    <Contact:ChatEmails xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:ChatEmails>
    <Contact:InternetPhones xsi:type="Contact:ArrayOfEntityElement">
     <Contact:EntityElement xsi:type="Contact:EntityElement">
      <Contact:Value xsi:type="xsd:string"></Contact:Value>
      <Contact:StrippedValue xsi:type="xsd:string"></Contact:StrippedValue>
      <Contact:Description xsi:type="xsd:string"></Contact:Description>
     </Contact:EntityElement>
    </Contact:InternetPhones>
    <Contact:Source xsi:type="xsd:short">0</Contact:Source>
    <Contact:ActiveErpLinks xsi:type="xsd:int">0</Contact:ActiveErpLinks>
    <Contact:ShipmentTypes xsi:type="Contact:ArrayOfSelectableMDOListItem">
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
      <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
        <Contact:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:LastChanged>
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
    </Contact:ShipmentTypes>
    <Contact:Consents xsi:type="Contact:ArrayOfConsentInfo">
     <Contact:ConsentInfo xsi:type="Contact:ConsentInfo">
      <Contact:ConsentPersonId xsi:type="xsd:int">0</Contact:ConsentPersonId>
      <Contact:Comment xsi:type="xsd:string"></Contact:Comment>
      <Contact:Registered xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:Registered>
      <Contact:RegisteredAssociateId xsi:type="xsd:int">0</Contact:RegisteredAssociateId>
      <Contact:Updated xsi:type="xsd:dateTime">2021-11-30T13:22:49Z</Contact:Updated>
      <Contact:UpdatedAssociateId xsi:type="xsd:int">0</Contact:UpdatedAssociateId>
      <Contact:LegalBaseId xsi:type="xsd:int">0</Contact:LegalBaseId>
      <Contact:LegalBaseKey xsi:type="xsd:string"></Contact:LegalBaseKey>
      <Contact:LegalBaseName xsi:type="xsd:string"></Contact:LegalBaseName>
      <Contact:ConsentPurposeId xsi:type="xsd:int">0</Contact:ConsentPurposeId>
      <Contact:ConsentPurposeKey xsi:type="xsd:string"></Contact:ConsentPurposeKey>
      <Contact:ConsentPurposeName xsi:type="xsd:string"></Contact:ConsentPurposeName>
      <Contact:ConsentSourceId xsi:type="xsd:int">0</Contact:ConsentSourceId>
      <Contact:ConsentSourceKey xsi:type="xsd:string"></Contact:ConsentSourceKey>
      <Contact:ConsentSourceName xsi:type="xsd:string"></Contact:ConsentSourceName>
     </Contact:ConsentInfo>
    </Contact:Consents>
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
   </Contact:Response>
  </Contact:AddPersonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

