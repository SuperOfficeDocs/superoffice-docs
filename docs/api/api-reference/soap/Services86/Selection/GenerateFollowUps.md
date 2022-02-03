---
title: Services86.SelectionAgent.GenerateFollowUps SOAP
generated: 1
uid: Services86-Selection-GenerateFollowUps
---

# Services86 Selection GenerateFollowUps

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.GenerateFollowUps">SuperOffice.Services86.ISelectionAgent.GenerateFollowUps</see> method.

## GenerateFollowUps

Generate follow-ups for members in the selection.

* **selectionId:** The id of the selection to generate the follow-ups for.
* **appointmentEntity:** The AppointmentEntity with information about the appointment.
* **associateId:** The associate to save the appointments on. If saveOnContactOwner is true, this id will be ignored. Appointments wil be saved on current user if associateId = 0.
* **saveOnContactOwner:** If true, the appointments will be saved on contact owner (Our contact). This parameter will override associateId if true.
* **uniqueContact:** If true, only one appointment will be created for each contact.



[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateFollowUps Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GenerateFollowUps>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:AppointmentEntity xsi:type="Selection:AppointmentEntity">
     <Selection:Associate xsi:type="Selection:Associate">
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
      <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
      <Selection:UserName xsi:type="xsd:string"></Selection:UserName>
     </Selection:Associate>
     <Selection:Contact xsi:type="Selection:Contact">
      <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:OrgNr xsi:type="xsd:string"></Selection:OrgNr>
      <Selection:Department xsi:type="xsd:string"></Selection:Department>
      <Selection:URL xsi:type="xsd:string"></Selection:URL>
      <Selection:City xsi:type="xsd:string"></Selection:City>
      <Selection:DirectPhone xsi:type="xsd:string"></Selection:DirectPhone>
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:CountryId xsi:type="xsd:int">0</Selection:CountryId>
      <Selection:EmailAddress xsi:type="xsd:string"></Selection:EmailAddress>
      <Selection:Kananame xsi:type="xsd:string"></Selection:Kananame>
      <Selection:EmailAddressName xsi:type="xsd:string"></Selection:EmailAddressName>
      <Selection:URLName xsi:type="xsd:string"></Selection:URLName>
      <Selection:AssociateFullName xsi:type="xsd:string"></Selection:AssociateFullName>
      <Selection:BusinessName xsi:type="xsd:string"></Selection:BusinessName>
      <Selection:CategoryName xsi:type="xsd:string"></Selection:CategoryName>
      <Selection:CountryName xsi:type="xsd:string"></Selection:CountryName>
      <Selection:Address xsi:type="Selection:Address">
       <Selection:Wgs84Latitude xsi:type="xsd:double">0.0</Selection:Wgs84Latitude>
       <Selection:Wgs84Longitude xsi:type="xsd:double">0.0</Selection:Wgs84Longitude>
       <Selection:LocalizedAddress xsi:type="Selection:ArrayOfArrayOfLocalizedField">
        <Selection:ArrayOfLocalizedField xsi:type="Selection:ArrayOfLocalizedField">
         <Selection:LocalizedField xsi:type="Selection:LocalizedField">
          <Selection:Name xsi:type="xsd:string"></Selection:Name>
          <Selection:Value xsi:type="xsd:string"></Selection:Value>
          <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
          <Selection:Label xsi:type="xsd:string"></Selection:Label>
          <Selection:ValueLength xsi:nil="true"></Selection:ValueLength>
          <Selection:AddressType xsi:type="xsd:string"></Selection:AddressType>
         </Selection:LocalizedField>
        </Selection:ArrayOfLocalizedField>
       </Selection:LocalizedAddress>
       <Selection:Street xsi:type="Selection:StructuredAddress">
        <Selection:AtypeIdx xsi:type="Selection:AddressType">Unknown</Selection:AtypeIdx>
        <Selection:Address1 xsi:type="xsd:string"></Selection:Address1>
        <Selection:Address2 xsi:type="xsd:string"></Selection:Address2>
        <Selection:Address3 xsi:type="xsd:string"></Selection:Address3>
        <Selection:City xsi:type="xsd:string"></Selection:City>
        <Selection:County xsi:type="xsd:string"></Selection:County>
        <Selection:State xsi:type="xsd:string"></Selection:State>
        <Selection:Zipcode xsi:type="xsd:string"></Selection:Zipcode>
       </Selection:Street>
       <Selection:Postal xsi:type="Selection:StructuredAddress">
        <Selection:AtypeIdx xsi:type="Selection:AddressType">Unknown</Selection:AtypeIdx>
        <Selection:Address1 xsi:type="xsd:string"></Selection:Address1>
        <Selection:Address2 xsi:type="xsd:string"></Selection:Address2>
        <Selection:Address3 xsi:type="xsd:string"></Selection:Address3>
        <Selection:City xsi:type="xsd:string"></Selection:City>
        <Selection:County xsi:type="xsd:string"></Selection:County>
        <Selection:State xsi:type="xsd:string"></Selection:State>
        <Selection:Zipcode xsi:type="xsd:string"></Selection:Zipcode>
       </Selection:Postal>
      </Selection:Address>
      <Selection:FormattedAddress xsi:type="xsd:string"></Selection:FormattedAddress>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:IsOwnerContact xsi:type="xsd:boolean">false</Selection:IsOwnerContact>
      <Selection:ActiveErpLinks xsi:type="xsd:int">0</Selection:ActiveErpLinks>
     </Selection:Contact>
     <Selection:CreatedBy xsi:type="Selection:Associate">
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
      <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
      <Selection:UserName xsi:type="xsd:string"></Selection:UserName>
     </Selection:CreatedBy>
     <Selection:UpdatedBy xsi:type="Selection:Associate">
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
      <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
      <Selection:UserName xsi:type="xsd:string"></Selection:UserName>
     </Selection:UpdatedBy>
     <Selection:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:CreatedDate>
     <Selection:AppointmentId xsi:type="xsd:int">0</Selection:AppointmentId>
     <Selection:Description xsi:type="xsd:string"></Selection:Description>
     <Selection:StartDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:StartDate>
     <Selection:EndDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:EndDate>
     <Selection:InvitedPerson xsi:type="Selection:Person">
      <Selection:Position xsi:type="xsd:string"></Selection:Position>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Mrmrs xsi:type="xsd:string"></Selection:Mrmrs>
      <Selection:Firstname xsi:type="xsd:string"></Selection:Firstname>
      <Selection:Lastname xsi:type="xsd:string"></Selection:Lastname>
      <Selection:MiddleName xsi:type="xsd:string"></Selection:MiddleName>
      <Selection:Title xsi:type="xsd:string"></Selection:Title>
      <Selection:Description xsi:type="xsd:string"></Selection:Description>
      <Selection:Email xsi:type="xsd:string"></Selection:Email>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:DirectPhone xsi:type="xsd:string"></Selection:DirectPhone>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:CountryId xsi:type="xsd:int">0</Selection:CountryId>
      <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
      <Selection:ContactName xsi:type="xsd:string"></Selection:ContactName>
      <Selection:Retired xsi:type="xsd:short">0</Selection:Retired>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:ActiveInterests xsi:type="xsd:short">0</Selection:ActiveInterests>
      <Selection:ContactDepartment xsi:type="xsd:string"></Selection:ContactDepartment>
      <Selection:ContactCountryId xsi:type="xsd:int">0</Selection:ContactCountryId>
      <Selection:ContactOrgNr xsi:type="xsd:string"></Selection:ContactOrgNr>
      <Selection:FaxPhone xsi:type="xsd:string"></Selection:FaxPhone>
      <Selection:MobilePhone xsi:type="xsd:string"></Selection:MobilePhone>
      <Selection:ContactPhone xsi:type="xsd:string"></Selection:ContactPhone>
      <Selection:AssociateName xsi:type="xsd:string"></Selection:AssociateName>
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:UsePersonAddress xsi:type="xsd:boolean">false</Selection:UsePersonAddress>
      <Selection:ContactFax xsi:type="xsd:string"></Selection:ContactFax>
      <Selection:Kanafname xsi:type="xsd:string"></Selection:Kanafname>
      <Selection:Kanalname xsi:type="xsd:string"></Selection:Kanalname>
      <Selection:Post1 xsi:type="xsd:string"></Selection:Post1>
      <Selection:Post2 xsi:type="xsd:string"></Selection:Post2>
      <Selection:Post3 xsi:type="xsd:string"></Selection:Post3>
      <Selection:EmailName xsi:type="xsd:string"></Selection:EmailName>
      <Selection:ContactFullName xsi:type="xsd:string"></Selection:ContactFullName>
      <Selection:ActiveErpLinks xsi:type="xsd:int">0</Selection:ActiveErpLinks>
      <Selection:TicketPriorityId xsi:type="xsd:int">0</Selection:TicketPriorityId>
      <Selection:SupportLanguageId xsi:type="xsd:int">0</Selection:SupportLanguageId>
      <Selection:SupportAssociateId xsi:type="xsd:int">0</Selection:SupportAssociateId>
     </Selection:InvitedPerson>
     <Selection:Person xsi:type="Selection:Person">
      <Selection:Position xsi:type="xsd:string"></Selection:Position>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Mrmrs xsi:type="xsd:string"></Selection:Mrmrs>
      <Selection:Firstname xsi:type="xsd:string"></Selection:Firstname>
      <Selection:Lastname xsi:type="xsd:string"></Selection:Lastname>
      <Selection:MiddleName xsi:type="xsd:string"></Selection:MiddleName>
      <Selection:Title xsi:type="xsd:string"></Selection:Title>
      <Selection:Description xsi:type="xsd:string"></Selection:Description>
      <Selection:Email xsi:type="xsd:string"></Selection:Email>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:DirectPhone xsi:type="xsd:string"></Selection:DirectPhone>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:CountryId xsi:type="xsd:int">0</Selection:CountryId>
      <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
      <Selection:ContactName xsi:type="xsd:string"></Selection:ContactName>
      <Selection:Retired xsi:type="xsd:short">0</Selection:Retired>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:ActiveInterests xsi:type="xsd:short">0</Selection:ActiveInterests>
      <Selection:ContactDepartment xsi:type="xsd:string"></Selection:ContactDepartment>
      <Selection:ContactCountryId xsi:type="xsd:int">0</Selection:ContactCountryId>
      <Selection:ContactOrgNr xsi:type="xsd:string"></Selection:ContactOrgNr>
      <Selection:FaxPhone xsi:type="xsd:string"></Selection:FaxPhone>
      <Selection:MobilePhone xsi:type="xsd:string"></Selection:MobilePhone>
      <Selection:ContactPhone xsi:type="xsd:string"></Selection:ContactPhone>
      <Selection:AssociateName xsi:type="xsd:string"></Selection:AssociateName>
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:UsePersonAddress xsi:type="xsd:boolean">false</Selection:UsePersonAddress>
      <Selection:ContactFax xsi:type="xsd:string"></Selection:ContactFax>
      <Selection:Kanafname xsi:type="xsd:string"></Selection:Kanafname>
      <Selection:Kanalname xsi:type="xsd:string"></Selection:Kanalname>
      <Selection:Post1 xsi:type="xsd:string"></Selection:Post1>
      <Selection:Post2 xsi:type="xsd:string"></Selection:Post2>
      <Selection:Post3 xsi:type="xsd:string"></Selection:Post3>
      <Selection:EmailName xsi:type="xsd:string"></Selection:EmailName>
      <Selection:ContactFullName xsi:type="xsd:string"></Selection:ContactFullName>
      <Selection:ActiveErpLinks xsi:type="xsd:int">0</Selection:ActiveErpLinks>
      <Selection:TicketPriorityId xsi:type="xsd:int">0</Selection:TicketPriorityId>
      <Selection:SupportLanguageId xsi:type="xsd:int">0</Selection:SupportLanguageId>
      <Selection:SupportAssociateId xsi:type="xsd:int">0</Selection:SupportAssociateId>
     </Selection:Person>
     <Selection:MotherId xsi:type="xsd:int">0</Selection:MotherId>
     <Selection:Priority xsi:type="Selection:Priority">
      <Selection:Id xsi:type="xsd:int">0</Selection:Id>
      <Selection:Value xsi:type="xsd:string"></Selection:Value>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
     </Selection:Priority>
     <Selection:Private xsi:type="Selection:AppointmentPrivate">Public</Selection:Private>
     <Selection:Project xsi:type="Selection:Project">
      <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:Description xsi:type="xsd:string"></Selection:Description>
      <Selection:URL xsi:type="xsd:string"></Selection:URL>
      <Selection:Type xsi:type="xsd:string"></Selection:Type>
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:AssociateFullName xsi:type="xsd:string"></Selection:AssociateFullName>
      <Selection:TypeId xsi:type="xsd:int">0</Selection:TypeId>
      <Selection:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:Updated>
      <Selection:StatusId xsi:type="xsd:int">0</Selection:StatusId>
      <Selection:Status xsi:type="xsd:string"></Selection:Status>
      <Selection:TextId xsi:type="xsd:int">0</Selection:TextId>
      <Selection:PublishTo xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:PublishTo>
      <Selection:PublishFrom xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:PublishFrom>
      <Selection:IsPublished xsi:type="xsd:boolean">false</Selection:IsPublished>
      <Selection:URLName xsi:type="xsd:string"></Selection:URLName>
      <Selection:ProjectNumber xsi:type="xsd:string"></Selection:ProjectNumber>
      <Selection:ActiveErpLinks xsi:type="xsd:int">0</Selection:ActiveErpLinks>
     </Selection:Project>
     <Selection:Type xsi:type="Selection:AppointmentType">Unknown</Selection:Type>
     <Selection:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:UpdatedDate>
     <Selection:Completed xsi:type="Selection:ActivityStatus">Unknown</Selection:Completed>
     <Selection:ActiveLinks xsi:type="xsd:int">0</Selection:ActiveLinks>
     <Selection:Links xsi:type="Selection:ArrayOfLink">
      <Selection:Link xsi:type="Selection:Link">
       <Selection:EntityName xsi:type="xsd:string"></Selection:EntityName>
       <Selection:Id xsi:type="xsd:int">0</Selection:Id>
       <Selection:Description xsi:type="xsd:string"></Selection:Description>
       <Selection:ExtraInfo xsi:type="xsd:string"></Selection:ExtraInfo>
       <Selection:LinkId xsi:type="xsd:int">0</Selection:LinkId>
      </Selection:Link>
     </Selection:Links>
     <Selection:AlarmLeadTime xsi:type="NetServerServices861:duration"></Selection:AlarmLeadTime>
     <Selection:HasAlarm xsi:type="xsd:boolean">false</Selection:HasAlarm>
     <Selection:ColorIndex xsi:type="xsd:short">0</Selection:ColorIndex>
     <Selection:IsFree xsi:type="xsd:boolean">false</Selection:IsFree>
     <Selection:IsAlldayEvent xsi:type="xsd:boolean">false</Selection:IsAlldayEvent>
     <Selection:LagTime xsi:type="NetServerServices861:duration"></Selection:LagTime>
     <Selection:LeadTime xsi:type="NetServerServices861:duration"></Selection:LeadTime>
     <Selection:Location xsi:type="xsd:string"></Selection:Location>
     <Selection:RejectCounter xsi:type="xsd:short">0</Selection:RejectCounter>
     <Selection:RejectReason xsi:type="xsd:string"></Selection:RejectReason>
     <Selection:Recurrence xsi:type="Selection:RecurrenceInfo">
      <Selection:RecurrenceId xsi:type="xsd:int">0</Selection:RecurrenceId>
      <Selection:StartDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:StartDate>
      <Selection:EndDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:EndDate>
      <Selection:RecurrenceEndType xsi:type="Selection:RecurrenceEndType">Unknown</Selection:RecurrenceEndType>
      <Selection:Pattern xsi:type="Selection:RecurrencePattern">Unknown</Selection:Pattern>
      <Selection:DayPattern xsi:type="Selection:RecurrenceDayPattern">
       <Selection:Cycle xsi:type="xsd:int">0</Selection:Cycle>
       <Selection:Pattern xsi:type="Selection:RecurrenceDailyPattern">Unknown</Selection:Pattern>
      </Selection:DayPattern>
      <Selection:WeekPattern xsi:type="Selection:RecurrenceWeekPattern">
       <Selection:Cycle xsi:type="xsd:int">0</Selection:Cycle>
       <Selection:Weekdays xsi:type="Selection:Weekday">Monday</Selection:Weekdays>
      </Selection:WeekPattern>
      <Selection:MonthPattern xsi:type="Selection:RecurrenceMonthPattern">
       <Selection:Cycle xsi:type="xsd:int">0</Selection:Cycle>
       <Selection:Day xsi:type="xsd:int">0</Selection:Day>
       <Selection:Weekday xsi:type="Selection:Weekday">Monday</Selection:Weekday>
       <Selection:WeekOfMonth xsi:type="Selection:WeekOfMonth">Unknown</Selection:WeekOfMonth>
       <Selection:Pattern xsi:type="Selection:RecurrenceMonthlyPattern">Unknown</Selection:Pattern>
      </Selection:MonthPattern>
      <Selection:YearPattern xsi:type="Selection:RecurrenceYearPattern">
       <Selection:Cycle xsi:type="xsd:int">0</Selection:Cycle>
       <Selection:Day xsi:type="xsd:int">0</Selection:Day>
       <Selection:Weekday xsi:type="Selection:Weekday">Monday</Selection:Weekday>
       <Selection:WeekOfMonth xsi:type="Selection:WeekOfMonth">Unknown</Selection:WeekOfMonth>
       <Selection:Pattern xsi:type="Selection:RecurrenceYearlyPattern">Unknown</Selection:Pattern>
      </Selection:YearPattern>
      <Selection:Dates xsi:type="Selection:ArrayOfRecurrenceDate">
       <Selection:RecurrenceDate xsi:type="Selection:RecurrenceDate">
        <Selection:Date xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:Date>
        <Selection:IsConflict xsi:type="xsd:boolean">false</Selection:IsConflict>
        <Selection:Description xsi:type="xsd:string"></Selection:Description>
        <Selection:DescriptionStyleHint xsi:type="xsd:string"></Selection:DescriptionStyleHint>
        <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
       </Selection:RecurrenceDate>
      </Selection:Dates>
      <Selection:RecurrenceCounter xsi:type="xsd:int">0</Selection:RecurrenceCounter>
      <Selection:IsRecurrence xsi:type="xsd:boolean">false</Selection:IsRecurrence>
     </Selection:Recurrence>
     <Selection:Participants xsi:type="Selection:ArrayOfParticipantInfo">
      <Selection:ParticipantInfo xsi:type="Selection:ParticipantInfo">
       <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
       <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
       <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
       <Selection:EmailId xsi:type="xsd:int">0</Selection:EmailId>
       <Selection:SendEmail xsi:type="xsd:boolean">false</Selection:SendEmail>
       <Selection:InvitationStatus xsi:type="Selection:InvitationStatus">Unknown</Selection:InvitationStatus>
      </Selection:ParticipantInfo>
     </Selection:Participants>
     <Selection:AssignmentStatus xsi:type="Selection:AssignmentStatus">Unknown</Selection:AssignmentStatus>
     <Selection:InvitationStatus xsi:type="Selection:InvitationStatus">Unknown</Selection:InvitationStatus>
     <Selection:BookingType xsi:type="Selection:BookingType">Unknown</Selection:BookingType>
     <Selection:ActiveDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:ActiveDate>
     <Selection:HasConflict xsi:type="xsd:boolean">false</Selection:HasConflict>
     <Selection:AssignedBy xsi:type="Selection:Associate">
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
      <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
      <Selection:UserName xsi:type="xsd:string"></Selection:UserName>
     </Selection:AssignedBy>
     <Selection:MotherAssociate xsi:type="Selection:Associate">
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Type xsi:type="Selection:UserType">Unknown</Selection:Type>
      <Selection:GroupIdx xsi:type="xsd:int">0</Selection:GroupIdx>
      <Selection:FullName xsi:type="xsd:string"></Selection:FullName>
      <Selection:FormalName xsi:type="xsd:string"></Selection:FormalName>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:EjUserId xsi:type="xsd:int">0</Selection:EjUserId>
      <Selection:UserName xsi:type="xsd:string"></Selection:UserName>
     </Selection:MotherAssociate>
     <Selection:Task xsi:type="Selection:TaskListItem">
      <Selection:TaskListItemId xsi:type="xsd:int">0</Selection:TaskListItemId>
      <Selection:Value xsi:type="xsd:string"></Selection:Value>
      <Selection:Direction xsi:type="Selection:TaskDirection">Unknown</Selection:Direction>
      <Selection:Type xsi:type="Selection:TaskType">Unknown</Selection:Type>
      <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
      <Selection:Deleted xsi:type="xsd:boolean">false</Selection:Deleted>
      <Selection:IntentId xsi:type="xsd:int">0</Selection:IntentId>
      <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
      <Selection:IsDefaultAlldayEvent xsi:type="xsd:boolean">false</Selection:IsDefaultAlldayEvent>
      <Selection:IsDefaultFree xsi:type="xsd:boolean">false</Selection:IsDefaultFree>
      <Selection:IsDefaultPublished xsi:type="xsd:boolean">false</Selection:IsDefaultPublished>
      <Selection:ColorIndex xsi:type="Selection:ColorIndex">LightBlue</Selection:ColorIndex>
     </Selection:Task>
     <Selection:PreferredTZLocation xsi:type="xsd:int">0</Selection:PreferredTZLocation>
     <Selection:Sale xsi:type="Selection:Sale">
      <Selection:ContactName xsi:type="xsd:string"></Selection:ContactName>
      <Selection:SaleDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:SaleDate>
      <Selection:SaleId xsi:type="xsd:int">0</Selection:SaleId>
      <Selection:Probability xsi:type="xsd:short">0</Selection:Probability>
      <Selection:Title xsi:type="xsd:string"></Selection:Title>
      <Selection:Amount xsi:type="xsd:double">0.0</Selection:Amount>
      <Selection:Currency xsi:type="xsd:string"></Selection:Currency>
      <Selection:ProjectName xsi:type="xsd:string"></Selection:ProjectName>
      <Selection:AssociateFullName xsi:type="xsd:string"></Selection:AssociateFullName>
      <Selection:Description xsi:type="xsd:string"></Selection:Description>
      <Selection:Status xsi:type="Selection:SaleStatus">Unknown</Selection:Status>
      <Selection:WeightedAmount xsi:type="xsd:double">0.0</Selection:WeightedAmount>
      <Selection:ProjectId xsi:type="xsd:int">0</Selection:ProjectId>
      <Selection:EarningPercent xsi:type="xsd:double">0.0</Selection:EarningPercent>
      <Selection:Earning xsi:type="xsd:double">0.0</Selection:Earning>
      <Selection:ContactId xsi:type="xsd:int">0</Selection:ContactId>
      <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
      <Selection:PersonId xsi:type="xsd:int">0</Selection:PersonId>
      <Selection:SaleTypeId xsi:type="xsd:int">0</Selection:SaleTypeId>
      <Selection:SaleTypeName xsi:type="xsd:string"></Selection:SaleTypeName>
      <Selection:PersonFullName xsi:type="xsd:string"></Selection:PersonFullName>
      <Selection:Completed xsi:type="Selection:ActivityStatus">Unknown</Selection:Completed>
      <Selection:ActiveErpLinks xsi:type="xsd:int">0</Selection:ActiveErpLinks>
      <Selection:NextDueDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:NextDueDate>
     </Selection:Sale>
     <Selection:SuggestedAppointmentId xsi:type="xsd:int">0</Selection:SuggestedAppointmentId>
     <Selection:IsMileStone xsi:type="xsd:boolean">false</Selection:IsMileStone>
     <Selection:UserDefinedFields xsi:type="Selection:StringDictionary">
      <Selection:StringKeyValuePair>
       <Selection:Key xsi:type="xsd:string"></Selection:Key>
       <Selection:Value xsi:type="xsd:string"></Selection:Value>
      </Selection:StringKeyValuePair>
     </Selection:UserDefinedFields>
     <Selection:ExtraFields xsi:type="Selection:StringDictionary">
      <Selection:StringKeyValuePair>
       <Selection:Key xsi:type="xsd:string"></Selection:Key>
       <Selection:Value xsi:type="xsd:string"></Selection:Value>
      </Selection:StringKeyValuePair>
     </Selection:ExtraFields>
     <Selection:PublishEventDate xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:PublishEventDate>
     <Selection:PublishTo xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:PublishTo>
     <Selection:PublishFrom xsi:type="xsd:dateTime">2021-11-30T13:23:04Z</Selection:PublishFrom>
     <Selection:IsPublished xsi:type="xsd:boolean">false</Selection:IsPublished>
     <Selection:VisibleFor xsi:type="Selection:ArrayOfVisibleFor">
      <Selection:VisibleFor xsi:type="Selection:VisibleFor">
       <Selection:VisibleId xsi:type="xsd:int">0</Selection:VisibleId>
       <Selection:Visibility xsi:type="Selection:Visibility">All</Selection:Visibility>
       <Selection:DisplayValue xsi:type="xsd:string"></Selection:DisplayValue>
      </Selection:VisibleFor>
     </Selection:VisibleFor>
    </Selection:AppointmentEntity>
    <Selection:AssociateId xsi:type="xsd:int">0</Selection:AssociateId>
    <Selection:SaveOnContactOwner xsi:type="xsd:boolean">false</Selection:SaveOnContactOwner>
    <Selection:UniqueContact xsi:type="xsd:boolean">false</Selection:UniqueContact>
   </Selection:GenerateFollowUps>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateFollowUps Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Selection:GenerateFollowUpsResponse>
  </Selection:GenerateFollowUpsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

