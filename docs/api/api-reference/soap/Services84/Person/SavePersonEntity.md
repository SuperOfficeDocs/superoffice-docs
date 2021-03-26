---
uid: services84-person-savepersonentity
title: Services84.PersonAgent.SavePersonEntity SOAP
Generated: true
---

# Services84 Person SavePersonEntity SOAP

SOAP request and response examples **Remote/Services84/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPersonAgent.SavePersonEntity">SuperOffice.Services84.IPersonAgent.SavePersonEntity</see> method.

## SavePersonEntity

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is 0.

* **personEntity:** The PersonEntity that is saved.

**Returns:** New or updated PersonEntity


[WSDL file for Services84/Person](../Services84-Person.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePersonEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:SavePersonEntity>
    <Person:PersonEntity xsi:type="Person:PersonEntity">
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Firstname xsi:type="xsd:string"></Person:Firstname>
     <Person:MiddleName xsi:type="xsd:string"></Person:MiddleName>
     <Person:Lastname xsi:type="xsd:string"></Person:Lastname>
     <Person:Mrmrs xsi:type="xsd:string"></Person:Mrmrs>
     <Person:Title xsi:type="xsd:string"></Person:Title>
     <Person:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:UpdatedDate>
     <Person:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:CreatedDate>
     <Person:BirthDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:BirthDate>
     <Person:CreatedBy xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     </Person:CreatedBy>
     <Person:Emails xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:Emails>
     <Person:Description xsi:type="xsd:string"></Person:Description>
     <Person:IsAssociate xsi:type="xsd:boolean">false</Person:IsAssociate>
     <Person:PrivatePhones xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:PrivatePhones>
     <Person:Faxes xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:Faxes>
     <Person:MobilePhones xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:MobilePhones>
     <Person:OfficePhones xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:OfficePhones>
     <Person:OtherPhones xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:OtherPhones>
     <Person:Position xsi:type="Person:Position">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     </Person:Position>
     <Person:UpdatedBy xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     </Person:UpdatedBy>
     <Person:Contact xsi:type="Person:Contact">
      <Person:ContactId xsi:type="xsd:int">0</Person:ContactId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:OrgNr xsi:type="xsd:string"></Person:OrgNr>
      <Person:Department xsi:type="xsd:string"></Person:Department>
      <Person:URL xsi:type="xsd:string"></Person:URL>
      <Person:City xsi:type="xsd:string"></Person:City>
      <Person:DirectPhone xsi:type="xsd:string"></Person:DirectPhone>
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
      <Person:EmailAddress xsi:type="xsd:string"></Person:EmailAddress>
      <Person:Kananame xsi:type="xsd:string"></Person:Kananame>
      <Person:EmailAddressName xsi:type="xsd:string"></Person:EmailAddressName>
      <Person:URLName xsi:type="xsd:string"></Person:URLName>
      <Person:AssociateFullName xsi:type="xsd:string"></Person:AssociateFullName>
      <Person:BusinessName xsi:type="xsd:string"></Person:BusinessName>
      <Person:CategoryName xsi:type="xsd:string"></Person:CategoryName>
      <Person:CountryName xsi:type="xsd:string"></Person:CountryName>
      <Person:Address xsi:type="Person:Address">
       <Person:Wgs84Latitude xsi:type="xsd:double">0.0</Person:Wgs84Latitude>
       <Person:Wgs84Longitude xsi:type="xsd:double">0.0</Person:Wgs84Longitude>
       <Person:LocalizedAddress xsi:type="Person:ArrayOfArrayOfLocalizedField">
        <Person:ArrayOfLocalizedField xsi:type="Person:ArrayOfLocalizedField">
         <Person:LocalizedField xsi:type="Person:LocalizedField">
          <Person:Name xsi:type="xsd:string"></Person:Name>
          <Person:Value xsi:type="xsd:string"></Person:Value>
          <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
          <Person:Label xsi:type="xsd:string"></Person:Label>
          <Person:ValueLength xsi:nil="true"></Person:ValueLength>
          <Person:AddressType xsi:type="xsd:string"></Person:AddressType>
         </Person:LocalizedField>
        </Person:ArrayOfLocalizedField>
       </Person:LocalizedAddress>
      </Person:Address>
      <Person:FormattedAddress xsi:type="xsd:string"></Person:FormattedAddress>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:IsOwnerContact xsi:type="xsd:boolean">false</Person:IsOwnerContact>
      <Person:ActiveErpLinks xsi:type="xsd:int">0</Person:ActiveErpLinks>
     </Person:Contact>
     <Person:Country xsi:type="Person:Country">
      <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:CurrencyId xsi:type="xsd:int">0</Person:CurrencyId>
      <Person:EnglishName xsi:type="xsd:string"></Person:EnglishName>
      <Person:TwoLetterISOCountry xsi:type="xsd:string"></Person:TwoLetterISOCountry>
      <Person:ThreeLetterISOCountry xsi:type="xsd:string"></Person:ThreeLetterISOCountry>
      <Person:ImageDescription xsi:type="xsd:string"></Person:ImageDescription>
      <Person:OrgNrText xsi:type="xsd:string"></Person:OrgNrText>
      <Person:InterAreaPrefix xsi:type="xsd:string"></Person:InterAreaPrefix>
      <Person:DialInPrefix xsi:type="xsd:string"></Person:DialInPrefix>
      <Person:ZipPrefix xsi:type="xsd:string"></Person:ZipPrefix>
      <Person:DomainName xsi:type="xsd:string"></Person:DomainName>
      <Person:AddressLayoutId xsi:type="xsd:int">0</Person:AddressLayoutId>
      <Person:DomesticAddressLayoutId xsi:type="xsd:int">0</Person:DomesticAddressLayoutId>
      <Person:ForeignAddressLayoutId xsi:type="xsd:int">0</Person:ForeignAddressLayoutId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     </Person:Country>
     <Person:Interests xsi:type="Person:ArrayOfSelectableMDOListItem">
      <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
       <Person:Id xsi:type="xsd:int">0</Person:Id>
       <Person:Name xsi:type="xsd:string"></Person:Name>
       <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
       <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
       <Person:Rank xsi:type="xsd:int">0</Person:Rank>
       <Person:Type xsi:type="xsd:string"></Person:Type>
       <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
       <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
       <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
       <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
       <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
        <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
         <Person:Id xsi:type="xsd:int">0</Person:Id>
         <Person:Name xsi:type="xsd:string"></Person:Name>
         <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
         <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
         <Person:Rank xsi:type="xsd:int">0</Person:Rank>
         <Person:Type xsi:type="xsd:string"></Person:Type>
         <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
         <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
         <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
         <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
         <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
          <Person:SelectableMDOListItem xsi:nil="true"></Person:SelectableMDOListItem>
         </Person:ChildItems>
         <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
         <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
         <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
         <Person:FullName xsi:type="xsd:string"></Person:FullName>
        </Person:SelectableMDOListItem>
       </Person:ChildItems>
       <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
       <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
       <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
       <Person:FullName xsi:type="xsd:string"></Person:FullName>
      </Person:SelectableMDOListItem>
     </Person:Interests>
     <Person:PersonNumber xsi:type="xsd:string"></Person:PersonNumber>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:NoMailing xsi:type="xsd:boolean">false</Person:NoMailing>
     <Person:UsePersonAddress xsi:type="xsd:boolean">false</Person:UsePersonAddress>
     <Person:Retired xsi:type="xsd:boolean">false</Person:Retired>
     <Person:Urls xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:Urls>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Address xsi:type="Person:Address">
      <Person:Wgs84Latitude xsi:type="xsd:double">0.0</Person:Wgs84Latitude>
      <Person:Wgs84Longitude xsi:type="xsd:double">0.0</Person:Wgs84Longitude>
      <Person:LocalizedAddress xsi:type="Person:ArrayOfArrayOfLocalizedField">
       <Person:ArrayOfLocalizedField xsi:type="Person:ArrayOfLocalizedField">
        <Person:LocalizedField xsi:type="Person:LocalizedField">
         <Person:Name xsi:type="xsd:string"></Person:Name>
         <Person:Value xsi:type="xsd:string"></Person:Value>
         <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
         <Person:Label xsi:type="xsd:string"></Person:Label>
         <Person:ValueLength xsi:type="xsd:int">0</Person:ValueLength>
         <Person:AddressType xsi:type="xsd:string"></Person:AddressType>
        </Person:LocalizedField>
       </Person:ArrayOfLocalizedField>
      </Person:LocalizedAddress>
     </Person:Address>
     <Person:Post3 xsi:type="xsd:string"></Person:Post3>
     <Person:Post2 xsi:type="xsd:string"></Person:Post2>
     <Person:Post1 xsi:type="xsd:string"></Person:Post1>
     <Person:Kanalname xsi:type="xsd:string"></Person:Kanalname>
     <Person:Kanafname xsi:type="xsd:string"></Person:Kanafname>
     <Person:CorrespondingAssociate xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     </Person:CorrespondingAssociate>
     <Person:Category xsi:type="Person:Category">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     </Person:Category>
     <Person:Business xsi:type="Person:Business">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     </Person:Business>
     <Person:Associate xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     </Person:Associate>
     <Person:Salutation xsi:type="xsd:string"></Person:Salutation>
     <Person:ActiveInterests xsi:type="xsd:int">0</Person:ActiveInterests>
     <Person:SupportAssociate xsi:type="Person:Associate">
      <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
      <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
      <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     </Person:SupportAssociate>
     <Person:TicketPriority xsi:type="Person:TicketPriority">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     </Person:TicketPriority>
     <Person:CustomerLanguage xsi:type="Person:CustomerLanguage">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     </Person:CustomerLanguage>
     <Person:DbiAgentId xsi:type="xsd:int">0</Person:DbiAgentId>
     <Person:DbiKey xsi:type="xsd:string"></Person:DbiKey>
     <Person:DbiLastModified xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:DbiLastModified>
     <Person:DbiLastSyncronized xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:DbiLastSyncronized>
     <Person:SentInfo xsi:type="xsd:short">0</Person:SentInfo>
     <Person:ShowContactTickets xsi:type="xsd:short">0</Person:ShowContactTickets>
     <Person:UserInfo xsi:type="Person:UserInfo">
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:UserInfoId xsi:type="xsd:int">0</Person:UserInfoId>
      <Person:UserName xsi:type="xsd:string"></Person:UserName>
      <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
      <Person:Rank xsi:type="xsd:short">0</Person:Rank>
      <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
      <Person:UserGroupId xsi:type="xsd:int">0</Person:UserGroupId>
      <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
      <Person:UserType xsi:type="Person:UserType">Unknown</Person:UserType>
      <Person:GrantedLicenses xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Person:GrantedLicenses>
      <Person:CanLogon xsi:type="xsd:boolean">false</Person:CanLogon>
      <Person:RoleName xsi:type="xsd:string"></Person:RoleName>
      <Person:RoleTooltip xsi:type="xsd:string"></Person:RoleTooltip>
      <Person:UserGroupName xsi:type="xsd:string"></Person:UserGroupName>
      <Person:UserGroupTooltip xsi:type="xsd:string"></Person:UserGroupTooltip>
     </Person:UserInfo>
     <Person:ChatEmails xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:ChatEmails>
     <Person:InternetPhones xsi:type="Person:ArrayOfEntityElement">
      <Person:EntityElement xsi:type="Person:EntityElement">
       <Person:Value xsi:type="xsd:string"></Person:Value>
       <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
       <Person:Description xsi:type="xsd:string"></Person:Description>
      </Person:EntityElement>
     </Person:InternetPhones>
     <Person:Source xsi:type="xsd:short">0</Person:Source>
     <Person:ActiveErpLinks xsi:type="xsd:int">0</Person:ActiveErpLinks>
     <Person:ShipmentTypes xsi:type="Person:ArrayOfSelectableMDOListItem">
      <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
       <Person:Id xsi:type="xsd:int">0</Person:Id>
       <Person:Name xsi:type="xsd:string"></Person:Name>
       <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
       <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
       <Person:Rank xsi:type="xsd:int">0</Person:Rank>
       <Person:Type xsi:type="xsd:string"></Person:Type>
       <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
       <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
       <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
       <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
       <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
        <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
         <Person:Id xsi:type="xsd:int">0</Person:Id>
         <Person:Name xsi:type="xsd:string"></Person:Name>
         <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
         <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
         <Person:Rank xsi:type="xsd:int">0</Person:Rank>
         <Person:Type xsi:type="xsd:string"></Person:Type>
         <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
         <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
         <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
         <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
         <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
          <Person:SelectableMDOListItem xsi:nil="true"></Person:SelectableMDOListItem>
         </Person:ChildItems>
         <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
         <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
         <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
         <Person:FullName xsi:type="xsd:string"></Person:FullName>
        </Person:SelectableMDOListItem>
       </Person:ChildItems>
       <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
       <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
       <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
       <Person:FullName xsi:type="xsd:string"></Person:FullName>
      </Person:SelectableMDOListItem>
     </Person:ShipmentTypes>
     <Person:Consents xsi:type="Person:ArrayOfConsentInfo">
      <Person:ConsentInfo xsi:type="Person:ConsentInfo">
       <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
       <Person:Comment xsi:type="xsd:string"></Person:Comment>
       <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:Registered>
       <Person:RegisteredAssociateId xsi:type="xsd:int">0</Person:RegisteredAssociateId>
       <Person:Updated xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:Updated>
       <Person:UpdatedAssociateId xsi:type="xsd:int">0</Person:UpdatedAssociateId>
       <Person:LegalBaseId xsi:type="xsd:int">0</Person:LegalBaseId>
       <Person:LegalBaseKey xsi:type="xsd:string"></Person:LegalBaseKey>
       <Person:LegalBaseName xsi:type="xsd:string"></Person:LegalBaseName>
       <Person:ConsentPurposeId xsi:type="xsd:int">0</Person:ConsentPurposeId>
       <Person:ConsentPurposeKey xsi:type="xsd:string"></Person:ConsentPurposeKey>
       <Person:ConsentPurposeName xsi:type="xsd:string"></Person:ConsentPurposeName>
       <Person:ConsentSourceId xsi:type="xsd:int">0</Person:ConsentSourceId>
       <Person:ConsentSourceKey xsi:type="xsd:string"></Person:ConsentSourceKey>
       <Person:ConsentSourceName xsi:type="xsd:string"></Person:ConsentSourceName>
      </Person:ConsentInfo>
     </Person:Consents>
     <Person:UserDefinedFields xsi:type="Person:StringDictionary">
      <Person:StringKeyValuePair>
       <Person:Key xsi:type="xsd:string"></Person:Key>
       <Person:Value xsi:type="xsd:string"></Person:Value>
      </Person:StringKeyValuePair>
     </Person:UserDefinedFields>
     <Person:ExtraFields xsi:type="Person:StringDictionary">
      <Person:StringKeyValuePair>
       <Person:Key xsi:type="xsd:string"></Person:Key>
       <Person:Value xsi:type="xsd:string"></Person:Value>
      </Person:StringKeyValuePair>
     </Person:ExtraFields>
    </Person:PersonEntity>
   </Person:SavePersonEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePersonEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Person:SavePersonEntityResponse>
   <Person:Response xsi:type="Person:PersonEntity">
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:Firstname xsi:type="xsd:string"></Person:Firstname>
    <Person:MiddleName xsi:type="xsd:string"></Person:MiddleName>
    <Person:Lastname xsi:type="xsd:string"></Person:Lastname>
    <Person:Mrmrs xsi:type="xsd:string"></Person:Mrmrs>
    <Person:Title xsi:type="xsd:string"></Person:Title>
    <Person:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:UpdatedDate>
    <Person:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:CreatedDate>
    <Person:BirthDate xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:BirthDate>
    <Person:CreatedBy xsi:type="Person:Associate">
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
     <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
    </Person:CreatedBy>
    <Person:Emails xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:Emails>
    <Person:Description xsi:type="xsd:string"></Person:Description>
    <Person:IsAssociate xsi:type="xsd:boolean">false</Person:IsAssociate>
    <Person:PrivatePhones xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:PrivatePhones>
    <Person:Faxes xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:Faxes>
    <Person:MobilePhones xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:MobilePhones>
    <Person:OfficePhones xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:OfficePhones>
    <Person:OtherPhones xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:OtherPhones>
    <Person:Position xsi:type="Person:Position">
     <Person:Id xsi:type="xsd:int">0</Person:Id>
     <Person:Value xsi:type="xsd:string"></Person:Value>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
    </Person:Position>
    <Person:UpdatedBy xsi:type="Person:Associate">
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
     <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
    </Person:UpdatedBy>
    <Person:Contact xsi:type="Person:Contact">
     <Person:ContactId xsi:type="xsd:int">0</Person:ContactId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:OrgNr xsi:type="xsd:string"></Person:OrgNr>
     <Person:Department xsi:type="xsd:string"></Person:Department>
     <Person:URL xsi:type="xsd:string"></Person:URL>
     <Person:City xsi:type="xsd:string"></Person:City>
     <Person:DirectPhone xsi:type="xsd:string"></Person:DirectPhone>
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
     <Person:EmailAddress xsi:type="xsd:string"></Person:EmailAddress>
     <Person:Kananame xsi:type="xsd:string"></Person:Kananame>
     <Person:EmailAddressName xsi:type="xsd:string"></Person:EmailAddressName>
     <Person:URLName xsi:type="xsd:string"></Person:URLName>
     <Person:AssociateFullName xsi:type="xsd:string"></Person:AssociateFullName>
     <Person:BusinessName xsi:type="xsd:string"></Person:BusinessName>
     <Person:CategoryName xsi:type="xsd:string"></Person:CategoryName>
     <Person:CountryName xsi:type="xsd:string"></Person:CountryName>
     <Person:Address xsi:type="Person:Address">
      <Person:Wgs84Latitude xsi:type="xsd:double">0.0</Person:Wgs84Latitude>
      <Person:Wgs84Longitude xsi:type="xsd:double">0.0</Person:Wgs84Longitude>
      <Person:LocalizedAddress xsi:type="Person:ArrayOfArrayOfLocalizedField">
       <Person:ArrayOfLocalizedField xsi:type="Person:ArrayOfLocalizedField">
        <Person:LocalizedField xsi:type="Person:LocalizedField">
         <Person:Name xsi:type="xsd:string"></Person:Name>
         <Person:Value xsi:type="xsd:string"></Person:Value>
         <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
         <Person:Label xsi:type="xsd:string"></Person:Label>
         <Person:ValueLength xsi:type="xsd:int">0</Person:ValueLength>
         <Person:AddressType xsi:type="xsd:string"></Person:AddressType>
        </Person:LocalizedField>
       </Person:ArrayOfLocalizedField>
      </Person:LocalizedAddress>
     </Person:Address>
     <Person:FormattedAddress xsi:type="xsd:string"></Person:FormattedAddress>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:IsOwnerContact xsi:type="xsd:boolean">false</Person:IsOwnerContact>
     <Person:ActiveErpLinks xsi:type="xsd:int">0</Person:ActiveErpLinks>
    </Person:Contact>
    <Person:Country xsi:type="Person:Country">
     <Person:CountryId xsi:type="xsd:int">0</Person:CountryId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:CurrencyId xsi:type="xsd:int">0</Person:CurrencyId>
     <Person:EnglishName xsi:type="xsd:string"></Person:EnglishName>
     <Person:TwoLetterISOCountry xsi:type="xsd:string"></Person:TwoLetterISOCountry>
     <Person:ThreeLetterISOCountry xsi:type="xsd:string"></Person:ThreeLetterISOCountry>
     <Person:ImageDescription xsi:type="xsd:string"></Person:ImageDescription>
     <Person:OrgNrText xsi:type="xsd:string"></Person:OrgNrText>
     <Person:InterAreaPrefix xsi:type="xsd:string"></Person:InterAreaPrefix>
     <Person:DialInPrefix xsi:type="xsd:string"></Person:DialInPrefix>
     <Person:ZipPrefix xsi:type="xsd:string"></Person:ZipPrefix>
     <Person:DomainName xsi:type="xsd:string"></Person:DomainName>
     <Person:AddressLayoutId xsi:type="xsd:int">0</Person:AddressLayoutId>
     <Person:DomesticAddressLayoutId xsi:type="xsd:int">0</Person:DomesticAddressLayoutId>
     <Person:ForeignAddressLayoutId xsi:type="xsd:int">0</Person:ForeignAddressLayoutId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
    </Person:Country>
    <Person:Interests xsi:type="Person:ArrayOfSelectableMDOListItem">
     <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:Rank xsi:type="xsd:int">0</Person:Rank>
      <Person:Type xsi:type="xsd:string"></Person:Type>
      <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
      <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
      <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
      <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
      <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
       <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
        <Person:Id xsi:type="xsd:int">0</Person:Id>
        <Person:Name xsi:type="xsd:string"></Person:Name>
        <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
        <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
        <Person:Rank xsi:type="xsd:int">0</Person:Rank>
        <Person:Type xsi:type="xsd:string"></Person:Type>
        <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
        <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
        <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
        <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
        <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
         <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
          <Person:Id xsi:nil="true"></Person:Id>
          <Person:Name xsi:type="xsd:string"></Person:Name>
          <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
          <Person:Deleted xsi:nil="true"></Person:Deleted>
          <Person:Rank xsi:nil="true"></Person:Rank>
          <Person:Type xsi:type="xsd:string"></Person:Type>
          <Person:ColorBlock xsi:nil="true"></Person:ColorBlock>
          <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
          <Person:Selected xsi:nil="true"></Person:Selected>
          <Person:LastChanged xsi:nil="true"></Person:LastChanged>
          <Person:ChildItems xsi:nil="true"></Person:ChildItems>
          <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
          <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
          <Person:Hidden xsi:nil="true"></Person:Hidden>
          <Person:FullName xsi:type="xsd:string"></Person:FullName>
         </Person:SelectableMDOListItem>
        </Person:ChildItems>
        <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
        <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
        <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
        <Person:FullName xsi:type="xsd:string"></Person:FullName>
       </Person:SelectableMDOListItem>
      </Person:ChildItems>
      <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
      <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
      <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
     </Person:SelectableMDOListItem>
    </Person:Interests>
    <Person:PersonNumber xsi:type="xsd:string"></Person:PersonNumber>
    <Person:FullName xsi:type="xsd:string"></Person:FullName>
    <Person:NoMailing xsi:type="xsd:boolean">false</Person:NoMailing>
    <Person:UsePersonAddress xsi:type="xsd:boolean">false</Person:UsePersonAddress>
    <Person:Retired xsi:type="xsd:boolean">false</Person:Retired>
    <Person:Urls xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:Urls>
    <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
    <Person:Address xsi:type="Person:Address">
     <Person:Wgs84Latitude xsi:type="xsd:double">0.0</Person:Wgs84Latitude>
     <Person:Wgs84Longitude xsi:type="xsd:double">0.0</Person:Wgs84Longitude>
     <Person:LocalizedAddress xsi:type="Person:ArrayOfArrayOfLocalizedField">
      <Person:ArrayOfLocalizedField xsi:type="Person:ArrayOfLocalizedField">
       <Person:LocalizedField xsi:type="Person:LocalizedField">
        <Person:Name xsi:type="xsd:string"></Person:Name>
        <Person:Value xsi:type="xsd:string"></Person:Value>
        <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
        <Person:Label xsi:type="xsd:string"></Person:Label>
        <Person:ValueLength xsi:type="xsd:int">0</Person:ValueLength>
        <Person:AddressType xsi:type="xsd:string"></Person:AddressType>
       </Person:LocalizedField>
      </Person:ArrayOfLocalizedField>
     </Person:LocalizedAddress>
    </Person:Address>
    <Person:Post3 xsi:type="xsd:string"></Person:Post3>
    <Person:Post2 xsi:type="xsd:string"></Person:Post2>
    <Person:Post1 xsi:type="xsd:string"></Person:Post1>
    <Person:Kanalname xsi:type="xsd:string"></Person:Kanalname>
    <Person:Kanafname xsi:type="xsd:string"></Person:Kanafname>
    <Person:CorrespondingAssociate xsi:type="Person:Associate">
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
     <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
    </Person:CorrespondingAssociate>
    <Person:Category xsi:type="Person:Category">
     <Person:Id xsi:type="xsd:int">0</Person:Id>
     <Person:Value xsi:type="xsd:string"></Person:Value>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
    </Person:Category>
    <Person:Business xsi:type="Person:Business">
     <Person:Id xsi:type="xsd:int">0</Person:Id>
     <Person:Value xsi:type="xsd:string"></Person:Value>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
    </Person:Business>
    <Person:Associate xsi:type="Person:Associate">
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
     <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
    </Person:Associate>
    <Person:Salutation xsi:type="xsd:string"></Person:Salutation>
    <Person:ActiveInterests xsi:type="xsd:int">0</Person:ActiveInterests>
    <Person:SupportAssociate xsi:type="Person:Associate">
     <Person:AssociateId xsi:type="xsd:int">0</Person:AssociateId>
     <Person:Name xsi:type="xsd:string"></Person:Name>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:Type xsi:type="Person:UserType">Unknown</Person:Type>
     <Person:GroupIdx xsi:type="xsd:int">0</Person:GroupIdx>
     <Person:FullName xsi:type="xsd:string"></Person:FullName>
     <Person:FormalName xsi:type="xsd:string"></Person:FormalName>
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
    </Person:SupportAssociate>
    <Person:TicketPriority xsi:type="Person:TicketPriority">
     <Person:Id xsi:type="xsd:int">0</Person:Id>
     <Person:Value xsi:type="xsd:string"></Person:Value>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
    </Person:TicketPriority>
    <Person:CustomerLanguage xsi:type="Person:CustomerLanguage">
     <Person:Id xsi:type="xsd:int">0</Person:Id>
     <Person:Value xsi:type="xsd:string"></Person:Value>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
    </Person:CustomerLanguage>
    <Person:DbiAgentId xsi:type="xsd:int">0</Person:DbiAgentId>
    <Person:DbiKey xsi:type="xsd:string"></Person:DbiKey>
    <Person:DbiLastModified xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:DbiLastModified>
    <Person:DbiLastSyncronized xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:DbiLastSyncronized>
    <Person:SentInfo xsi:type="xsd:short">0</Person:SentInfo>
    <Person:ShowContactTickets xsi:type="xsd:short">0</Person:ShowContactTickets>
    <Person:UserInfo xsi:type="Person:UserInfo">
     <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
     <Person:UserInfoId xsi:type="xsd:int">0</Person:UserInfoId>
     <Person:UserName xsi:type="xsd:string"></Person:UserName>
     <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
     <Person:Rank xsi:type="xsd:short">0</Person:Rank>
     <Person:Tooltip xsi:type="xsd:string"></Person:Tooltip>
     <Person:UserGroupId xsi:type="xsd:int">0</Person:UserGroupId>
     <Person:EjUserId xsi:type="xsd:int">0</Person:EjUserId>
     <Person:UserType xsi:type="Person:UserType">Unknown</Person:UserType>
     <Person:GrantedLicenses xsi:type="NetServerServices842:ArrayOfstring">
      <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
     </Person:GrantedLicenses>
     <Person:CanLogon xsi:type="xsd:boolean">false</Person:CanLogon>
     <Person:RoleName xsi:type="xsd:string"></Person:RoleName>
     <Person:RoleTooltip xsi:type="xsd:string"></Person:RoleTooltip>
     <Person:UserGroupName xsi:type="xsd:string"></Person:UserGroupName>
     <Person:UserGroupTooltip xsi:type="xsd:string"></Person:UserGroupTooltip>
    </Person:UserInfo>
    <Person:ChatEmails xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:ChatEmails>
    <Person:InternetPhones xsi:type="Person:ArrayOfEntityElement">
     <Person:EntityElement xsi:type="Person:EntityElement">
      <Person:Value xsi:type="xsd:string"></Person:Value>
      <Person:StrippedValue xsi:type="xsd:string"></Person:StrippedValue>
      <Person:Description xsi:type="xsd:string"></Person:Description>
     </Person:EntityElement>
    </Person:InternetPhones>
    <Person:Source xsi:type="xsd:short">0</Person:Source>
    <Person:ActiveErpLinks xsi:type="xsd:int">0</Person:ActiveErpLinks>
    <Person:ShipmentTypes xsi:type="Person:ArrayOfSelectableMDOListItem">
     <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
      <Person:Id xsi:type="xsd:int">0</Person:Id>
      <Person:Name xsi:type="xsd:string"></Person:Name>
      <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
      <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
      <Person:Rank xsi:type="xsd:int">0</Person:Rank>
      <Person:Type xsi:type="xsd:string"></Person:Type>
      <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
      <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
      <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
      <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
      <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
       <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
        <Person:Id xsi:type="xsd:int">0</Person:Id>
        <Person:Name xsi:type="xsd:string"></Person:Name>
        <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
        <Person:Deleted xsi:type="xsd:boolean">false</Person:Deleted>
        <Person:Rank xsi:type="xsd:int">0</Person:Rank>
        <Person:Type xsi:type="xsd:string"></Person:Type>
        <Person:ColorBlock xsi:type="xsd:int">0</Person:ColorBlock>
        <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
        <Person:Selected xsi:type="xsd:boolean">false</Person:Selected>
        <Person:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:LastChanged>
        <Person:ChildItems xsi:type="Person:ArrayOfSelectableMDOListItem">
         <Person:SelectableMDOListItem xsi:type="Person:SelectableMDOListItem">
          <Person:Id xsi:nil="true"></Person:Id>
          <Person:Name xsi:type="xsd:string"></Person:Name>
          <Person:ToolTip xsi:type="xsd:string"></Person:ToolTip>
          <Person:Deleted xsi:nil="true"></Person:Deleted>
          <Person:Rank xsi:nil="true"></Person:Rank>
          <Person:Type xsi:type="xsd:string"></Person:Type>
          <Person:ColorBlock xsi:nil="true"></Person:ColorBlock>
          <Person:IconHint xsi:type="xsd:string"></Person:IconHint>
          <Person:Selected xsi:nil="true"></Person:Selected>
          <Person:LastChanged xsi:nil="true"></Person:LastChanged>
          <Person:ChildItems xsi:nil="true"></Person:ChildItems>
          <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
          <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
          <Person:Hidden xsi:nil="true"></Person:Hidden>
          <Person:FullName xsi:type="xsd:string"></Person:FullName>
         </Person:SelectableMDOListItem>
        </Person:ChildItems>
        <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
        <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
        <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
        <Person:FullName xsi:type="xsd:string"></Person:FullName>
       </Person:SelectableMDOListItem>
      </Person:ChildItems>
      <Person:ExtraInfo xsi:type="xsd:string"></Person:ExtraInfo>
      <Person:StyleHint xsi:type="xsd:string"></Person:StyleHint>
      <Person:Hidden xsi:type="xsd:boolean">false</Person:Hidden>
      <Person:FullName xsi:type="xsd:string"></Person:FullName>
     </Person:SelectableMDOListItem>
    </Person:ShipmentTypes>
    <Person:Consents xsi:type="Person:ArrayOfConsentInfo">
     <Person:ConsentInfo xsi:type="Person:ConsentInfo">
      <Person:ConsentPersonId xsi:type="xsd:int">0</Person:ConsentPersonId>
      <Person:Comment xsi:type="xsd:string"></Person:Comment>
      <Person:Registered xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:Registered>
      <Person:RegisteredAssociateId xsi:type="xsd:int">0</Person:RegisteredAssociateId>
      <Person:Updated xsi:type="xsd:dateTime">2021-03-25T21:35:31Z</Person:Updated>
      <Person:UpdatedAssociateId xsi:type="xsd:int">0</Person:UpdatedAssociateId>
      <Person:LegalBaseId xsi:type="xsd:int">0</Person:LegalBaseId>
      <Person:LegalBaseKey xsi:type="xsd:string"></Person:LegalBaseKey>
      <Person:LegalBaseName xsi:type="xsd:string"></Person:LegalBaseName>
      <Person:ConsentPurposeId xsi:type="xsd:int">0</Person:ConsentPurposeId>
      <Person:ConsentPurposeKey xsi:type="xsd:string"></Person:ConsentPurposeKey>
      <Person:ConsentPurposeName xsi:type="xsd:string"></Person:ConsentPurposeName>
      <Person:ConsentSourceId xsi:type="xsd:int">0</Person:ConsentSourceId>
      <Person:ConsentSourceKey xsi:type="xsd:string"></Person:ConsentSourceKey>
      <Person:ConsentSourceName xsi:type="xsd:string"></Person:ConsentSourceName>
     </Person:ConsentInfo>
    </Person:Consents>
    <Person:UserDefinedFields xsi:type="Person:StringDictionary">
     <Person:StringKeyValuePair>
      <Person:Key xsi:type="xsd:string"></Person:Key>
      <Person:Value xsi:type="xsd:string"></Person:Value>
     </Person:StringKeyValuePair>
    </Person:UserDefinedFields>
    <Person:ExtraFields xsi:type="Person:StringDictionary">
     <Person:StringKeyValuePair>
      <Person:Key xsi:type="xsd:string"></Person:Key>
      <Person:Value xsi:type="xsd:string"></Person:Value>
     </Person:StringKeyValuePair>
    </Person:ExtraFields>
   </Person:Response>
  </Person:SavePersonEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

