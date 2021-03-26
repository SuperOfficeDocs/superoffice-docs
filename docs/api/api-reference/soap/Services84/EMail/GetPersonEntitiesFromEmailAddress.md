---
uid: services84-email-getpersonentitiesfromemailaddress
title: Services84.EMailAgent.GetPersonEntitiesFromEmailAddress SOAP
Generated: true
---

# Services84 EMail GetPersonEntitiesFromEmailAddress SOAP

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.GetPersonEntitiesFromEmailAddress">SuperOffice.Services84.IEMailAgent.GetPersonEntitiesFromEmailAddress</see> method.

## GetPersonEntitiesFromEmailAddress

Get all persons and contacts with the given email address

* **emailAddress:** The emailAddress to find persons and contacts fors



[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPersonEntitiesFromEmailAddress Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:GetPersonEntitiesFromEmailAddress>
    <EMail:EmailAddress xsi:type="xsd:string"></EMail:EmailAddress>
   </EMail:GetPersonEntitiesFromEmailAddress>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPersonEntitiesFromEmailAddress Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:GetPersonEntitiesFromEmailAddressResponse>
   <EMail:Response xsi:type="EMail:ArrayOfPersonEntity">
    <EMail:PersonEntity xsi:type="EMail:PersonEntity">
     <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
     <EMail:Firstname xsi:type="xsd:string"></EMail:Firstname>
     <EMail:MiddleName xsi:type="xsd:string"></EMail:MiddleName>
     <EMail:Lastname xsi:type="xsd:string"></EMail:Lastname>
     <EMail:Mrmrs xsi:type="xsd:string"></EMail:Mrmrs>
     <EMail:Title xsi:type="xsd:string"></EMail:Title>
     <EMail:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:UpdatedDate>
     <EMail:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:CreatedDate>
     <EMail:BirthDate xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:BirthDate>
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
     <EMail:Emails xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:Emails>
     <EMail:Description xsi:type="xsd:string"></EMail:Description>
     <EMail:IsAssociate xsi:type="xsd:boolean">false</EMail:IsAssociate>
     <EMail:PrivatePhones xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:PrivatePhones>
     <EMail:Faxes xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:Faxes>
     <EMail:MobilePhones xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:MobilePhones>
     <EMail:OfficePhones xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:OfficePhones>
     <EMail:OtherPhones xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:OtherPhones>
     <EMail:Position xsi:type="EMail:Position">
      <EMail:Id xsi:type="xsd:int">0</EMail:Id>
      <EMail:Value xsi:type="xsd:string"></EMail:Value>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:Position>
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
     <EMail:Country xsi:type="EMail:Country">
      <EMail:CountryId xsi:type="xsd:int">0</EMail:CountryId>
      <EMail:Name xsi:type="xsd:string"></EMail:Name>
      <EMail:CurrencyId xsi:type="xsd:int">0</EMail:CurrencyId>
      <EMail:EnglishName xsi:type="xsd:string"></EMail:EnglishName>
      <EMail:TwoLetterISOCountry xsi:type="xsd:string"></EMail:TwoLetterISOCountry>
      <EMail:ThreeLetterISOCountry xsi:type="xsd:string"></EMail:ThreeLetterISOCountry>
      <EMail:ImageDescription xsi:type="xsd:string"></EMail:ImageDescription>
      <EMail:OrgNrText xsi:type="xsd:string"></EMail:OrgNrText>
      <EMail:InterAreaPrefix xsi:type="xsd:string"></EMail:InterAreaPrefix>
      <EMail:DialInPrefix xsi:type="xsd:string"></EMail:DialInPrefix>
      <EMail:ZipPrefix xsi:type="xsd:string"></EMail:ZipPrefix>
      <EMail:DomainName xsi:type="xsd:string"></EMail:DomainName>
      <EMail:AddressLayoutId xsi:type="xsd:int">0</EMail:AddressLayoutId>
      <EMail:DomesticAddressLayoutId xsi:type="xsd:int">0</EMail:DomesticAddressLayoutId>
      <EMail:ForeignAddressLayoutId xsi:type="xsd:int">0</EMail:ForeignAddressLayoutId>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
     </EMail:Country>
     <EMail:Interests xsi:type="EMail:ArrayOfSelectableMDOListItem">
      <EMail:SelectableMDOListItem xsi:type="EMail:SelectableMDOListItem">
       <EMail:Id xsi:type="xsd:int">0</EMail:Id>
       <EMail:Name xsi:type="xsd:string"></EMail:Name>
       <EMail:ToolTip xsi:type="xsd:string"></EMail:ToolTip>
       <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
       <EMail:Rank xsi:type="xsd:int">0</EMail:Rank>
       <EMail:Type xsi:type="xsd:string"></EMail:Type>
       <EMail:ColorBlock xsi:type="xsd:int">0</EMail:ColorBlock>
       <EMail:IconHint xsi:type="xsd:string"></EMail:IconHint>
       <EMail:Selected xsi:type="xsd:boolean">false</EMail:Selected>
       <EMail:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:LastChanged>
       <EMail:ChildItems xsi:type="EMail:ArrayOfSelectableMDOListItem">
        <EMail:SelectableMDOListItem xsi:type="EMail:SelectableMDOListItem">
         <EMail:Id xsi:type="xsd:int">0</EMail:Id>
         <EMail:Name xsi:type="xsd:string"></EMail:Name>
         <EMail:ToolTip xsi:type="xsd:string"></EMail:ToolTip>
         <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
         <EMail:Rank xsi:type="xsd:int">0</EMail:Rank>
         <EMail:Type xsi:type="xsd:string"></EMail:Type>
         <EMail:ColorBlock xsi:type="xsd:int">0</EMail:ColorBlock>
         <EMail:IconHint xsi:type="xsd:string"></EMail:IconHint>
         <EMail:Selected xsi:type="xsd:boolean">false</EMail:Selected>
         <EMail:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:LastChanged>
         <EMail:ChildItems xsi:type="EMail:ArrayOfSelectableMDOListItem">
          <EMail:SelectableMDOListItem xsi:nil="true"></EMail:SelectableMDOListItem>
         </EMail:ChildItems>
         <EMail:ExtraInfo xsi:type="xsd:string"></EMail:ExtraInfo>
         <EMail:StyleHint xsi:type="xsd:string"></EMail:StyleHint>
         <EMail:Hidden xsi:type="xsd:boolean">false</EMail:Hidden>
         <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
        </EMail:SelectableMDOListItem>
       </EMail:ChildItems>
       <EMail:ExtraInfo xsi:type="xsd:string"></EMail:ExtraInfo>
       <EMail:StyleHint xsi:type="xsd:string"></EMail:StyleHint>
       <EMail:Hidden xsi:type="xsd:boolean">false</EMail:Hidden>
       <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      </EMail:SelectableMDOListItem>
     </EMail:Interests>
     <EMail:PersonNumber xsi:type="xsd:string"></EMail:PersonNumber>
     <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
     <EMail:NoMailing xsi:type="xsd:boolean">false</EMail:NoMailing>
     <EMail:UsePersonAddress xsi:type="xsd:boolean">false</EMail:UsePersonAddress>
     <EMail:Retired xsi:type="xsd:boolean">false</EMail:Retired>
     <EMail:Urls xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:Urls>
     <EMail:FormalName xsi:type="xsd:string"></EMail:FormalName>
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
         <EMail:ValueLength xsi:type="xsd:int">0</EMail:ValueLength>
         <EMail:AddressType xsi:type="xsd:string"></EMail:AddressType>
        </EMail:LocalizedField>
       </EMail:ArrayOfLocalizedField>
      </EMail:LocalizedAddress>
     </EMail:Address>
     <EMail:Post3 xsi:type="xsd:string"></EMail:Post3>
     <EMail:Post2 xsi:type="xsd:string"></EMail:Post2>
     <EMail:Post1 xsi:type="xsd:string"></EMail:Post1>
     <EMail:Kanalname xsi:type="xsd:string"></EMail:Kanalname>
     <EMail:Kanafname xsi:type="xsd:string"></EMail:Kanafname>
     <EMail:CorrespondingAssociate xsi:type="EMail:Associate">
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
     </EMail:CorrespondingAssociate>
     <EMail:Category xsi:type="EMail:Category">
      <EMail:Id xsi:type="xsd:int">0</EMail:Id>
      <EMail:Value xsi:type="xsd:string"></EMail:Value>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:Category>
     <EMail:Business xsi:type="EMail:Business">
      <EMail:Id xsi:type="xsd:int">0</EMail:Id>
      <EMail:Value xsi:type="xsd:string"></EMail:Value>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:Business>
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
     <EMail:Salutation xsi:type="xsd:string"></EMail:Salutation>
     <EMail:ActiveInterests xsi:type="xsd:int">0</EMail:ActiveInterests>
     <EMail:SupportAssociate xsi:type="EMail:Associate">
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
     </EMail:SupportAssociate>
     <EMail:TicketPriority xsi:type="EMail:TicketPriority">
      <EMail:Id xsi:type="xsd:int">0</EMail:Id>
      <EMail:Value xsi:type="xsd:string"></EMail:Value>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:TicketPriority>
     <EMail:CustomerLanguage xsi:type="EMail:CustomerLanguage">
      <EMail:Id xsi:type="xsd:int">0</EMail:Id>
      <EMail:Value xsi:type="xsd:string"></EMail:Value>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
     </EMail:CustomerLanguage>
     <EMail:DbiAgentId xsi:type="xsd:int">0</EMail:DbiAgentId>
     <EMail:DbiKey xsi:type="xsd:string"></EMail:DbiKey>
     <EMail:DbiLastModified xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:DbiLastModified>
     <EMail:DbiLastSyncronized xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:DbiLastSyncronized>
     <EMail:SentInfo xsi:type="xsd:short">0</EMail:SentInfo>
     <EMail:ShowContactTickets xsi:type="xsd:short">0</EMail:ShowContactTickets>
     <EMail:UserInfo xsi:type="EMail:UserInfo">
      <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
      <EMail:UserInfoId xsi:type="xsd:int">0</EMail:UserInfoId>
      <EMail:UserName xsi:type="xsd:string"></EMail:UserName>
      <EMail:PersonId xsi:type="xsd:int">0</EMail:PersonId>
      <EMail:Rank xsi:type="xsd:short">0</EMail:Rank>
      <EMail:Tooltip xsi:type="xsd:string"></EMail:Tooltip>
      <EMail:UserGroupId xsi:type="xsd:int">0</EMail:UserGroupId>
      <EMail:EjUserId xsi:type="xsd:int">0</EMail:EjUserId>
      <EMail:UserType xsi:type="EMail:UserType">Unknown</EMail:UserType>
      <EMail:GrantedLicenses xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </EMail:GrantedLicenses>
      <EMail:CanLogon xsi:type="xsd:boolean">false</EMail:CanLogon>
      <EMail:RoleName xsi:type="xsd:string"></EMail:RoleName>
      <EMail:RoleTooltip xsi:type="xsd:string"></EMail:RoleTooltip>
      <EMail:UserGroupName xsi:type="xsd:string"></EMail:UserGroupName>
      <EMail:UserGroupTooltip xsi:type="xsd:string"></EMail:UserGroupTooltip>
     </EMail:UserInfo>
     <EMail:ChatEmails xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:ChatEmails>
     <EMail:InternetPhones xsi:type="EMail:ArrayOfEntityElement">
      <EMail:EntityElement xsi:type="EMail:EntityElement">
       <EMail:Value xsi:type="xsd:string"></EMail:Value>
       <EMail:StrippedValue xsi:type="xsd:string"></EMail:StrippedValue>
       <EMail:Description xsi:type="xsd:string"></EMail:Description>
      </EMail:EntityElement>
     </EMail:InternetPhones>
     <EMail:Source xsi:type="xsd:short">0</EMail:Source>
     <EMail:ActiveErpLinks xsi:type="xsd:int">0</EMail:ActiveErpLinks>
     <EMail:ShipmentTypes xsi:type="EMail:ArrayOfSelectableMDOListItem">
      <EMail:SelectableMDOListItem xsi:type="EMail:SelectableMDOListItem">
       <EMail:Id xsi:type="xsd:int">0</EMail:Id>
       <EMail:Name xsi:type="xsd:string"></EMail:Name>
       <EMail:ToolTip xsi:type="xsd:string"></EMail:ToolTip>
       <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
       <EMail:Rank xsi:type="xsd:int">0</EMail:Rank>
       <EMail:Type xsi:type="xsd:string"></EMail:Type>
       <EMail:ColorBlock xsi:type="xsd:int">0</EMail:ColorBlock>
       <EMail:IconHint xsi:type="xsd:string"></EMail:IconHint>
       <EMail:Selected xsi:type="xsd:boolean">false</EMail:Selected>
       <EMail:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:LastChanged>
       <EMail:ChildItems xsi:type="EMail:ArrayOfSelectableMDOListItem">
        <EMail:SelectableMDOListItem xsi:type="EMail:SelectableMDOListItem">
         <EMail:Id xsi:type="xsd:int">0</EMail:Id>
         <EMail:Name xsi:type="xsd:string"></EMail:Name>
         <EMail:ToolTip xsi:type="xsd:string"></EMail:ToolTip>
         <EMail:Deleted xsi:type="xsd:boolean">false</EMail:Deleted>
         <EMail:Rank xsi:type="xsd:int">0</EMail:Rank>
         <EMail:Type xsi:type="xsd:string"></EMail:Type>
         <EMail:ColorBlock xsi:type="xsd:int">0</EMail:ColorBlock>
         <EMail:IconHint xsi:type="xsd:string"></EMail:IconHint>
         <EMail:Selected xsi:type="xsd:boolean">false</EMail:Selected>
         <EMail:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:LastChanged>
         <EMail:ChildItems xsi:type="EMail:ArrayOfSelectableMDOListItem">
          <EMail:SelectableMDOListItem xsi:nil="true"></EMail:SelectableMDOListItem>
         </EMail:ChildItems>
         <EMail:ExtraInfo xsi:type="xsd:string"></EMail:ExtraInfo>
         <EMail:StyleHint xsi:type="xsd:string"></EMail:StyleHint>
         <EMail:Hidden xsi:type="xsd:boolean">false</EMail:Hidden>
         <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
        </EMail:SelectableMDOListItem>
       </EMail:ChildItems>
       <EMail:ExtraInfo xsi:type="xsd:string"></EMail:ExtraInfo>
       <EMail:StyleHint xsi:type="xsd:string"></EMail:StyleHint>
       <EMail:Hidden xsi:type="xsd:boolean">false</EMail:Hidden>
       <EMail:FullName xsi:type="xsd:string"></EMail:FullName>
      </EMail:SelectableMDOListItem>
     </EMail:ShipmentTypes>
     <EMail:Consents xsi:type="EMail:ArrayOfConsentInfo">
      <EMail:ConsentInfo xsi:type="EMail:ConsentInfo">
       <EMail:ConsentPersonId xsi:type="xsd:int">0</EMail:ConsentPersonId>
       <EMail:Comment xsi:type="xsd:string"></EMail:Comment>
       <EMail:Registered xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:Registered>
       <EMail:RegisteredAssociateId xsi:type="xsd:int">0</EMail:RegisteredAssociateId>
       <EMail:Updated xsi:type="xsd:dateTime">2021-03-25T21:35:25Z</EMail:Updated>
       <EMail:UpdatedAssociateId xsi:type="xsd:int">0</EMail:UpdatedAssociateId>
       <EMail:LegalBaseId xsi:type="xsd:int">0</EMail:LegalBaseId>
       <EMail:LegalBaseKey xsi:type="xsd:string"></EMail:LegalBaseKey>
       <EMail:LegalBaseName xsi:type="xsd:string"></EMail:LegalBaseName>
       <EMail:ConsentPurposeId xsi:type="xsd:int">0</EMail:ConsentPurposeId>
       <EMail:ConsentPurposeKey xsi:type="xsd:string"></EMail:ConsentPurposeKey>
       <EMail:ConsentPurposeName xsi:type="xsd:string"></EMail:ConsentPurposeName>
       <EMail:ConsentSourceId xsi:type="xsd:int">0</EMail:ConsentSourceId>
       <EMail:ConsentSourceKey xsi:type="xsd:string"></EMail:ConsentSourceKey>
       <EMail:ConsentSourceName xsi:type="xsd:string"></EMail:ConsentSourceName>
      </EMail:ConsentInfo>
     </EMail:Consents>
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
    </EMail:PersonEntity>
   </EMail:Response>
  </EMail:GetPersonEntitiesFromEmailAddressResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

