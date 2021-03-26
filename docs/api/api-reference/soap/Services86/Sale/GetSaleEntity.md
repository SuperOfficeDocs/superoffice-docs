---
uid: services86-sale-getsaleentity
title: Services86.SaleAgent.GetSaleEntity SOAP
Generated: true
---

# Services86 Sale GetSaleEntity SOAP

SOAP request and response examples **Remote/Services86/Sale.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISaleAgent.GetSaleEntity">SuperOffice.Services86.ISaleAgent.GetSaleEntity</see> method.

## GetSaleEntity

Gets a SaleEntity object.

* **saleEntityId:** The identifier of the SaleEntity object

**Returns:** SaleEntity


[WSDL file for Services86/Sale](../Services86-Sale.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSaleEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Sale:ApplicationToken>1234567-1234-9876</Sale:ApplicationToken>
  <Sale:Credentials>
    <Sale:Ticket>7T:1234abcxyzExample==</Sale:Ticket>
  </Sale:Credentials>
 <SOAP-ENV:Body>
   <Sale:GetSaleEntity>
    <Sale:SaleEntityId xsi:type="xsd:int">0</Sale:SaleEntityId>
   </Sale:GetSaleEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSaleEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sale="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Sale:GetSaleEntityResponse>
   <Sale:Response xsi:type="Sale:SaleEntity">
    <Sale:Appointment xsi:type="Sale:Appointment">
     <Sale:AppointmentId xsi:type="xsd:int">0</Sale:AppointmentId>
     <Sale:StartDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:StartDate>
     <Sale:EndDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:EndDate>
     <Sale:Type xsi:type="Sale:AppointmentType">Unknown</Sale:Type>
     <Sale:Task xsi:type="xsd:string"></Sale:Task>
     <Sale:AssociateFullName xsi:type="xsd:string"></Sale:AssociateFullName>
     <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
     <Sale:Description xsi:type="xsd:string"></Sale:Description>
     <Sale:PersonFullName xsi:type="xsd:string"></Sale:PersonFullName>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
     <Sale:ProjectId xsi:type="xsd:int">0</Sale:ProjectId>
     <Sale:ProjectName xsi:type="xsd:string"></Sale:ProjectName>
     <Sale:IsPublished xsi:type="xsd:boolean">false</Sale:IsPublished>
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:ColorIndex xsi:type="xsd:short">0</Sale:ColorIndex>
     <Sale:IsFree xsi:type="xsd:boolean">false</Sale:IsFree>
     <Sale:HasAlarm xsi:type="xsd:boolean">false</Sale:HasAlarm>
     <Sale:IsAlldayEvent xsi:type="xsd:boolean">false</Sale:IsAlldayEvent>
     <Sale:Private xsi:type="Sale:AppointmentPrivate">Public</Sale:Private>
     <Sale:PriorityId xsi:type="xsd:int">0</Sale:PriorityId>
     <Sale:PriorityName xsi:type="xsd:string"></Sale:PriorityName>
     <Sale:TaskType xsi:type="Sale:TaskType">Unknown</Sale:TaskType>
     <Sale:IsBookingMain xsi:type="xsd:boolean">false</Sale:IsBookingMain>
     <Sale:IsRecurrence xsi:type="xsd:boolean">false</Sale:IsRecurrence>
     <Sale:IsBooking xsi:type="xsd:boolean">false</Sale:IsBooking>
     <Sale:ActiveDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:ActiveDate>
     <Sale:AssignmentStatus xsi:type="Sale:AssignmentStatus">Unknown</Sale:AssignmentStatus>
     <Sale:InvitationStatus xsi:type="Sale:InvitationStatus">Unknown</Sale:InvitationStatus>
     <Sale:BookingType xsi:type="Sale:BookingType">Unknown</Sale:BookingType>
     <Sale:Completed xsi:type="Sale:ActivityStatus">Unknown</Sale:Completed>
     <Sale:RecurringPattern xsi:type="Sale:RecurrencePattern">Unknown</Sale:RecurringPattern>
     <Sale:RecurringStartDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:RecurringStartDate>
     <Sale:RecurringEndDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:RecurringEndDate>
     <Sale:MotherId xsi:type="xsd:int">0</Sale:MotherId>
     <Sale:AssignedBy xsi:type="xsd:int">0</Sale:AssignedBy>
     <Sale:AssignedByFullName xsi:type="xsd:string"></Sale:AssignedByFullName>
     <Sale:RejectReason xsi:type="xsd:string"></Sale:RejectReason>
     <Sale:Location xsi:type="xsd:string"></Sale:Location>
     <Sale:AlarmLeadTime xsi:type="NetServerServices861:duration"></Sale:AlarmLeadTime>
     <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
     <Sale:SaleName xsi:type="xsd:string"></Sale:SaleName>
     <Sale:AssociateName xsi:type="xsd:string"></Sale:AssociateName>
     <Sale:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:CreatedDate>
     <Sale:CreatedBy xsi:type="xsd:string"></Sale:CreatedBy>
     <Sale:CreatedByFullName xsi:type="xsd:string"></Sale:CreatedByFullName>
     <Sale:CreatedByAssociateId xsi:type="xsd:int">0</Sale:CreatedByAssociateId>
    </Sale:Appointment>
    <Sale:Associate xsi:type="Sale:Associate">
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:Name xsi:type="xsd:string"></Sale:Name>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
     <Sale:Type xsi:type="Sale:UserType">Unknown</Sale:Type>
     <Sale:GroupIdx xsi:type="xsd:int">0</Sale:GroupIdx>
     <Sale:FullName xsi:type="xsd:string"></Sale:FullName>
     <Sale:FormalName xsi:type="xsd:string"></Sale:FormalName>
     <Sale:Deleted xsi:type="xsd:boolean">false</Sale:Deleted>
     <Sale:EjUserId xsi:type="xsd:int">0</Sale:EjUserId>
     <Sale:UserName xsi:type="xsd:string"></Sale:UserName>
    </Sale:Associate>
    <Sale:UpdatedBy xsi:type="Sale:Associate">
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:Name xsi:type="xsd:string"></Sale:Name>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
     <Sale:Type xsi:type="Sale:UserType">Unknown</Sale:Type>
     <Sale:GroupIdx xsi:type="xsd:int">0</Sale:GroupIdx>
     <Sale:FullName xsi:type="xsd:string"></Sale:FullName>
     <Sale:FormalName xsi:type="xsd:string"></Sale:FormalName>
     <Sale:Deleted xsi:type="xsd:boolean">false</Sale:Deleted>
     <Sale:EjUserId xsi:type="xsd:int">0</Sale:EjUserId>
     <Sale:UserName xsi:type="xsd:string"></Sale:UserName>
    </Sale:UpdatedBy>
    <Sale:CreatedBy xsi:type="Sale:Associate">
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:Name xsi:type="xsd:string"></Sale:Name>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
     <Sale:Type xsi:type="Sale:UserType">Unknown</Sale:Type>
     <Sale:GroupIdx xsi:type="xsd:int">0</Sale:GroupIdx>
     <Sale:FullName xsi:type="xsd:string"></Sale:FullName>
     <Sale:FormalName xsi:type="xsd:string"></Sale:FormalName>
     <Sale:Deleted xsi:type="xsd:boolean">false</Sale:Deleted>
     <Sale:EjUserId xsi:type="xsd:int">0</Sale:EjUserId>
     <Sale:UserName xsi:type="xsd:string"></Sale:UserName>
    </Sale:CreatedBy>
    <Sale:Contact xsi:type="Sale:Contact">
     <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
     <Sale:Name xsi:type="xsd:string"></Sale:Name>
     <Sale:OrgNr xsi:type="xsd:string"></Sale:OrgNr>
     <Sale:Department xsi:type="xsd:string"></Sale:Department>
     <Sale:URL xsi:type="xsd:string"></Sale:URL>
     <Sale:City xsi:type="xsd:string"></Sale:City>
     <Sale:DirectPhone xsi:type="xsd:string"></Sale:DirectPhone>
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:CountryId xsi:type="xsd:int">0</Sale:CountryId>
     <Sale:EmailAddress xsi:type="xsd:string"></Sale:EmailAddress>
     <Sale:Kananame xsi:type="xsd:string"></Sale:Kananame>
     <Sale:EmailAddressName xsi:type="xsd:string"></Sale:EmailAddressName>
     <Sale:URLName xsi:type="xsd:string"></Sale:URLName>
     <Sale:AssociateFullName xsi:type="xsd:string"></Sale:AssociateFullName>
     <Sale:BusinessName xsi:type="xsd:string"></Sale:BusinessName>
     <Sale:CategoryName xsi:type="xsd:string"></Sale:CategoryName>
     <Sale:CountryName xsi:type="xsd:string"></Sale:CountryName>
     <Sale:Address xsi:type="Sale:Address">
      <Sale:Wgs84Latitude xsi:type="xsd:double">0.0</Sale:Wgs84Latitude>
      <Sale:Wgs84Longitude xsi:type="xsd:double">0.0</Sale:Wgs84Longitude>
      <Sale:LocalizedAddress xsi:type="Sale:ArrayOfArrayOfLocalizedField">
       <Sale:ArrayOfLocalizedField xsi:type="Sale:ArrayOfLocalizedField">
        <Sale:LocalizedField xsi:type="Sale:LocalizedField">
         <Sale:Name xsi:type="xsd:string"></Sale:Name>
         <Sale:Value xsi:type="xsd:string"></Sale:Value>
         <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
         <Sale:Label xsi:type="xsd:string"></Sale:Label>
         <Sale:ValueLength xsi:type="xsd:int">0</Sale:ValueLength>
         <Sale:AddressType xsi:type="xsd:string"></Sale:AddressType>
        </Sale:LocalizedField>
       </Sale:ArrayOfLocalizedField>
      </Sale:LocalizedAddress>
      <Sale:Street xsi:type="Sale:StructuredAddress">
       <Sale:AtypeIdx xsi:type="Sale:AddressType">Unknown</Sale:AtypeIdx>
       <Sale:Address1 xsi:type="xsd:string"></Sale:Address1>
       <Sale:Address2 xsi:type="xsd:string"></Sale:Address2>
       <Sale:Address3 xsi:type="xsd:string"></Sale:Address3>
       <Sale:City xsi:type="xsd:string"></Sale:City>
       <Sale:County xsi:type="xsd:string"></Sale:County>
       <Sale:State xsi:type="xsd:string"></Sale:State>
       <Sale:Zipcode xsi:type="xsd:string"></Sale:Zipcode>
      </Sale:Street>
      <Sale:Postal xsi:type="Sale:StructuredAddress">
       <Sale:AtypeIdx xsi:type="Sale:AddressType">Unknown</Sale:AtypeIdx>
       <Sale:Address1 xsi:type="xsd:string"></Sale:Address1>
       <Sale:Address2 xsi:type="xsd:string"></Sale:Address2>
       <Sale:Address3 xsi:type="xsd:string"></Sale:Address3>
       <Sale:City xsi:type="xsd:string"></Sale:City>
       <Sale:County xsi:type="xsd:string"></Sale:County>
       <Sale:State xsi:type="xsd:string"></Sale:State>
       <Sale:Zipcode xsi:type="xsd:string"></Sale:Zipcode>
      </Sale:Postal>
     </Sale:Address>
     <Sale:FormattedAddress xsi:type="xsd:string"></Sale:FormattedAddress>
     <Sale:FullName xsi:type="xsd:string"></Sale:FullName>
     <Sale:IsOwnerContact xsi:type="xsd:boolean">false</Sale:IsOwnerContact>
     <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
    </Sale:Contact>
    <Sale:Project xsi:type="Sale:Project">
     <Sale:ProjectId xsi:type="xsd:int">0</Sale:ProjectId>
     <Sale:Name xsi:type="xsd:string"></Sale:Name>
     <Sale:Description xsi:type="xsd:string"></Sale:Description>
     <Sale:URL xsi:type="xsd:string"></Sale:URL>
     <Sale:Type xsi:type="xsd:string"></Sale:Type>
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:AssociateFullName xsi:type="xsd:string"></Sale:AssociateFullName>
     <Sale:TypeId xsi:type="xsd:int">0</Sale:TypeId>
     <Sale:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:Updated>
     <Sale:StatusId xsi:type="xsd:int">0</Sale:StatusId>
     <Sale:Status xsi:type="xsd:string"></Sale:Status>
     <Sale:TextId xsi:type="xsd:int">0</Sale:TextId>
     <Sale:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:PublishTo>
     <Sale:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:PublishFrom>
     <Sale:IsPublished xsi:type="xsd:boolean">false</Sale:IsPublished>
     <Sale:URLName xsi:type="xsd:string"></Sale:URLName>
     <Sale:ProjectNumber xsi:type="xsd:string"></Sale:ProjectNumber>
     <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
    </Sale:Project>
    <Sale:SaleText xsi:type="xsd:string"></Sale:SaleText>
    <Sale:Person xsi:type="Sale:Person">
     <Sale:Position xsi:type="xsd:string"></Sale:Position>
     <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
     <Sale:Mrmrs xsi:type="xsd:string"></Sale:Mrmrs>
     <Sale:Firstname xsi:type="xsd:string"></Sale:Firstname>
     <Sale:Lastname xsi:type="xsd:string"></Sale:Lastname>
     <Sale:MiddleName xsi:type="xsd:string"></Sale:MiddleName>
     <Sale:Title xsi:type="xsd:string"></Sale:Title>
     <Sale:Description xsi:type="xsd:string"></Sale:Description>
     <Sale:Email xsi:type="xsd:string"></Sale:Email>
     <Sale:FullName xsi:type="xsd:string"></Sale:FullName>
     <Sale:DirectPhone xsi:type="xsd:string"></Sale:DirectPhone>
     <Sale:FormalName xsi:type="xsd:string"></Sale:FormalName>
     <Sale:CountryId xsi:type="xsd:int">0</Sale:CountryId>
     <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
     <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
     <Sale:Retired xsi:type="xsd:short">0</Sale:Retired>
     <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
     <Sale:ActiveInterests xsi:type="xsd:short">0</Sale:ActiveInterests>
     <Sale:ContactDepartment xsi:type="xsd:string"></Sale:ContactDepartment>
     <Sale:ContactCountryId xsi:type="xsd:int">0</Sale:ContactCountryId>
     <Sale:ContactOrgNr xsi:type="xsd:string"></Sale:ContactOrgNr>
     <Sale:FaxPhone xsi:type="xsd:string"></Sale:FaxPhone>
     <Sale:MobilePhone xsi:type="xsd:string"></Sale:MobilePhone>
     <Sale:ContactPhone xsi:type="xsd:string"></Sale:ContactPhone>
     <Sale:AssociateName xsi:type="xsd:string"></Sale:AssociateName>
     <Sale:AssociateId xsi:type="xsd:int">0</Sale:AssociateId>
     <Sale:UsePersonAddress xsi:type="xsd:boolean">false</Sale:UsePersonAddress>
     <Sale:ContactFax xsi:type="xsd:string"></Sale:ContactFax>
     <Sale:Kanafname xsi:type="xsd:string"></Sale:Kanafname>
     <Sale:Kanalname xsi:type="xsd:string"></Sale:Kanalname>
     <Sale:Post1 xsi:type="xsd:string"></Sale:Post1>
     <Sale:Post2 xsi:type="xsd:string"></Sale:Post2>
     <Sale:Post3 xsi:type="xsd:string"></Sale:Post3>
     <Sale:EmailName xsi:type="xsd:string"></Sale:EmailName>
     <Sale:ContactFullName xsi:type="xsd:string"></Sale:ContactFullName>
     <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
     <Sale:TicketPriorityId xsi:type="xsd:int">0</Sale:TicketPriorityId>
     <Sale:SupportLanguageId xsi:type="xsd:int">0</Sale:SupportLanguageId>
     <Sale:SupportAssociateId xsi:type="xsd:int">0</Sale:SupportAssociateId>
    </Sale:Person>
    <Sale:Currency xsi:type="Sale:Currency">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Currency>
    <Sale:Competitor xsi:type="Sale:Competitor">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Competitor>
    <Sale:Credited xsi:type="Sale:Credited">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Credited>
    <Sale:Rating xsi:type="Sale:Rating">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Rating>
    <Sale:Reason xsi:type="Sale:Reason">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Reason>
    <Sale:Source xsi:type="Sale:Source">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:Source>
    <Sale:Status xsi:type="Sale:SaleStatus">Unknown</Sale:Status>
    <Sale:Saledate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:Saledate>
    <Sale:Amount xsi:type="xsd:double">0.0</Sale:Amount>
    <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
    <Sale:Earning xsi:type="xsd:double">0.0</Sale:Earning>
    <Sale:EarningPercent xsi:type="xsd:double">0.0</Sale:EarningPercent>
    <Sale:Heading xsi:type="xsd:string"></Sale:Heading>
    <Sale:Number xsi:type="xsd:string"></Sale:Number>
    <Sale:Probability xsi:type="xsd:short">0</Sale:Probability>
    <Sale:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:CreatedDate>
    <Sale:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:UpdatedDate>
    <Sale:Completed xsi:type="Sale:ActivityStatus">Unknown</Sale:Completed>
    <Sale:ActiveLinks xsi:type="xsd:int">0</Sale:ActiveLinks>
    <Sale:Links xsi:type="Sale:ArrayOfLink">
     <Sale:Link xsi:type="Sale:Link">
      <Sale:EntityName xsi:type="xsd:string"></Sale:EntityName>
      <Sale:Id xsi:type="xsd:int">0</Sale:Id>
      <Sale:Description xsi:type="xsd:string"></Sale:Description>
      <Sale:ExtraInfo xsi:type="xsd:string"></Sale:ExtraInfo>
      <Sale:LinkId xsi:type="xsd:int">0</Sale:LinkId>
     </Sale:Link>
    </Sale:Links>
    <Sale:NextDueDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:NextDueDate>
    <Sale:Postit xsi:type="xsd:string"></Sale:Postit>
    <Sale:SaleType xsi:type="Sale:SaleType">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:SaleType>
    <Sale:ReasonSold xsi:type="Sale:ReasonSold">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:ReasonSold>
    <Sale:ReasonStalled xsi:type="Sale:ReasonStalled">
     <Sale:Id xsi:type="xsd:int">0</Sale:Id>
     <Sale:Value xsi:type="xsd:string"></Sale:Value>
     <Sale:Tooltip xsi:type="xsd:string"></Sale:Tooltip>
    </Sale:ReasonStalled>
    <Sale:ReopenDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:ReopenDate>
    <Sale:SaleStakeholders xsi:type="Sale:ArrayOfSaleStakeholder">
     <Sale:SaleStakeholder xsi:type="Sale:SaleStakeholder">
      <Sale:StakeholderRoleName xsi:type="xsd:string"></Sale:StakeholderRoleName>
      <Sale:Comment xsi:type="xsd:string"></Sale:Comment>
      <Sale:StakeholderRoleId xsi:type="xsd:int">0</Sale:StakeholderRoleId>
      <Sale:CountryId xsi:type="xsd:int">0</Sale:CountryId>
      <Sale:PersonId xsi:type="xsd:int">0</Sale:PersonId>
      <Sale:EmailDescription xsi:type="xsd:string"></Sale:EmailDescription>
      <Sale:EmailId xsi:type="xsd:int">0</Sale:EmailId>
      <Sale:EmailAddress xsi:type="xsd:string"></Sale:EmailAddress>
      <Sale:PhoneId xsi:type="xsd:int">0</Sale:PhoneId>
      <Sale:ContactName xsi:type="xsd:string"></Sale:ContactName>
      <Sale:ContactId xsi:type="xsd:int">0</Sale:ContactId>
      <Sale:SaleId xsi:type="xsd:int">0</Sale:SaleId>
      <Sale:Mrmrs xsi:type="xsd:string"></Sale:Mrmrs>
      <Sale:Firstname xsi:type="xsd:string"></Sale:Firstname>
      <Sale:MiddleName xsi:type="xsd:string"></Sale:MiddleName>
      <Sale:Lastname xsi:type="xsd:string"></Sale:Lastname>
      <Sale:SaleStakeholderId xsi:type="xsd:int">0</Sale:SaleStakeholderId>
      <Sale:Rank xsi:type="xsd:short">0</Sale:Rank>
      <Sale:Phone xsi:type="xsd:string"></Sale:Phone>
     </Sale:SaleStakeholder>
    </Sale:SaleStakeholders>
    <Sale:ActiveErpLinks xsi:type="xsd:int">0</Sale:ActiveErpLinks>
    <Sale:UserDefinedFields xsi:type="Sale:StringDictionary">
     <Sale:StringKeyValuePair>
      <Sale:Key xsi:type="xsd:string"></Sale:Key>
      <Sale:Value xsi:type="xsd:string"></Sale:Value>
     </Sale:StringKeyValuePair>
    </Sale:UserDefinedFields>
    <Sale:ExtraFields xsi:type="Sale:StringDictionary">
     <Sale:StringKeyValuePair>
      <Sale:Key xsi:type="xsd:string"></Sale:Key>
      <Sale:Value xsi:type="xsd:string"></Sale:Value>
     </Sale:StringKeyValuePair>
    </Sale:ExtraFields>
    <Sale:PublishEventDate xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:PublishEventDate>
    <Sale:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:PublishTo>
    <Sale:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:36:21Z</Sale:PublishFrom>
    <Sale:IsPublished xsi:type="xsd:boolean">false</Sale:IsPublished>
    <Sale:VisibleFor xsi:type="Sale:ArrayOfVisibleFor">
     <Sale:VisibleFor xsi:type="Sale:VisibleFor">
      <Sale:VisibleId xsi:type="xsd:int">0</Sale:VisibleId>
      <Sale:Visibility xsi:type="Sale:Visibility">All</Sale:Visibility>
      <Sale:DisplayValue xsi:type="xsd:string"></Sale:DisplayValue>
     </Sale:VisibleFor>
    </Sale:VisibleFor>
   </Sale:Response>
  </Sale:GetSaleEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

