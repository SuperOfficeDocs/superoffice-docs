---
title: Services88.AIAgent.CreateTextForAppointment SOAP
generated: true
uid: Services88-AI-CreateTextForAppointment
content_type: reference
---

# Services88 AI CreateTextForAppointment

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.CreateTextForAppointment">SuperOffice.Services88.IAIAgent.CreateTextForAppointment</see> method.

## CreateTextForAppointment





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateTextForAppointment Request

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
   <AI:CreateTextForAppointment>
    <AI:Appointment xsi:type="AI:AppointmentEntity">
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
     <AI:CreatedDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:CreatedDate>
     <AI:AppointmentId xsi:type="xsd:int">0</AI:AppointmentId>
     <AI:Description xsi:type="xsd:string"></AI:Description>
     <AI:Title xsi:type="xsd:string"></AI:Title>
     <AI:Agenda xsi:type="xsd:string"></AI:Agenda>
     <AI:InternalNotes xsi:type="xsd:string"></AI:InternalNotes>
     <AI:StartDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:StartDate>
     <AI:EndDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:EndDate>
     <AI:InvitedPerson xsi:type="AI:Person">
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
     </AI:InvitedPerson>
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
     <AI:MotherId xsi:type="xsd:int">0</AI:MotherId>
     <AI:Priority xsi:type="AI:Priority">
      <AI:Id xsi:type="xsd:int">0</AI:Id>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
     </AI:Priority>
     <AI:Private xsi:type="AI:AppointmentPrivate">Public</AI:Private>
     <AI:Project xsi:type="AI:Project">
      <AI:ProjectId xsi:type="xsd:int">0</AI:ProjectId>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:Description xsi:type="xsd:string"></AI:Description>
      <AI:URL xsi:type="xsd:string"></AI:URL>
      <AI:Type xsi:type="xsd:string"></AI:Type>
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:AssociateFullName xsi:type="xsd:string"></AI:AssociateFullName>
      <AI:TypeId xsi:type="xsd:int">0</AI:TypeId>
      <AI:Updated xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:Updated>
      <AI:StatusId xsi:type="xsd:int">0</AI:StatusId>
      <AI:Status xsi:type="xsd:string"></AI:Status>
      <AI:TextId xsi:type="xsd:int">0</AI:TextId>
      <AI:PublishTo xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:PublishTo>
      <AI:PublishFrom xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:PublishFrom>
      <AI:IsPublished xsi:type="xsd:boolean">false</AI:IsPublished>
      <AI:URLName xsi:type="xsd:string"></AI:URLName>
      <AI:ProjectNumber xsi:type="xsd:string"></AI:ProjectNumber>
      <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
     </AI:Project>
     <AI:Type xsi:type="AI:AppointmentType">Unknown</AI:Type>
     <AI:UpdatedDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:UpdatedDate>
     <AI:Completed xsi:type="AI:ActivityStatus">Unknown</AI:Completed>
     <AI:ActiveLinks xsi:type="xsd:int">0</AI:ActiveLinks>
     <AI:Links xsi:type="AI:ArrayOfLink">
      <AI:Link xsi:type="AI:Link">
       <AI:EntityName xsi:type="xsd:string"></AI:EntityName>
       <AI:Id xsi:type="xsd:int">0</AI:Id>
       <AI:Description xsi:type="xsd:string"></AI:Description>
       <AI:ExtraInfo xsi:type="xsd:string"></AI:ExtraInfo>
       <AI:LinkId xsi:type="xsd:int">0</AI:LinkId>
      </AI:Link>
     </AI:Links>
     <AI:AlarmLeadTime xsi:type="NetServerServices881:duration"></AI:AlarmLeadTime>
     <AI:HasAlarm xsi:type="xsd:boolean">false</AI:HasAlarm>
     <AI:ColorIndex xsi:type="xsd:short">0</AI:ColorIndex>
     <AI:IsFree xsi:type="xsd:boolean">false</AI:IsFree>
     <AI:IsAlldayEvent xsi:type="xsd:boolean">false</AI:IsAlldayEvent>
     <AI:LagTime xsi:type="NetServerServices881:duration"></AI:LagTime>
     <AI:LeadTime xsi:type="NetServerServices881:duration"></AI:LeadTime>
     <AI:Location xsi:type="xsd:string"></AI:Location>
     <AI:RejectCounter xsi:type="xsd:short">0</AI:RejectCounter>
     <AI:RejectReason xsi:type="xsd:string"></AI:RejectReason>
     <AI:Recurrence xsi:type="AI:RecurrenceInfo">
      <AI:RecurrenceId xsi:type="xsd:int">0</AI:RecurrenceId>
      <AI:StartDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:StartDate>
      <AI:EndDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:EndDate>
      <AI:RecurrenceEndType xsi:type="AI:RecurrenceEndType">Unknown</AI:RecurrenceEndType>
      <AI:Pattern xsi:type="AI:RecurrencePattern">Unknown</AI:Pattern>
      <AI:DayPattern xsi:type="AI:RecurrenceDayPattern">
       <AI:Cycle xsi:type="xsd:int">0</AI:Cycle>
       <AI:Pattern xsi:type="AI:RecurrenceDailyPattern">Unknown</AI:Pattern>
      </AI:DayPattern>
      <AI:WeekPattern xsi:type="AI:RecurrenceWeekPattern">
       <AI:Cycle xsi:type="xsd:int">0</AI:Cycle>
       <AI:Weekdays xsi:type="AI:Weekday">Monday</AI:Weekdays>
      </AI:WeekPattern>
      <AI:MonthPattern xsi:type="AI:RecurrenceMonthPattern">
       <AI:Cycle xsi:type="xsd:int">0</AI:Cycle>
       <AI:Day xsi:type="xsd:int">0</AI:Day>
       <AI:Weekday xsi:type="AI:Weekday">Monday</AI:Weekday>
       <AI:WeekOfMonth xsi:type="AI:WeekOfMonth">Unknown</AI:WeekOfMonth>
       <AI:Pattern xsi:type="AI:RecurrenceMonthlyPattern">Unknown</AI:Pattern>
      </AI:MonthPattern>
      <AI:YearPattern xsi:type="AI:RecurrenceYearPattern">
       <AI:Cycle xsi:type="xsd:int">0</AI:Cycle>
       <AI:Day xsi:type="xsd:int">0</AI:Day>
       <AI:Weekday xsi:type="AI:Weekday">Monday</AI:Weekday>
       <AI:WeekOfMonth xsi:type="AI:WeekOfMonth">Unknown</AI:WeekOfMonth>
       <AI:Pattern xsi:type="AI:RecurrenceYearlyPattern">Unknown</AI:Pattern>
      </AI:YearPattern>
      <AI:Dates xsi:type="AI:ArrayOfRecurrenceDate">
       <AI:RecurrenceDate xsi:type="AI:RecurrenceDate">
        <AI:Date xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:Date>
        <AI:IsConflict xsi:type="xsd:boolean">false</AI:IsConflict>
        <AI:Description xsi:type="xsd:string"></AI:Description>
        <AI:DescriptionStyleHint xsi:type="xsd:string"></AI:DescriptionStyleHint>
        <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
       </AI:RecurrenceDate>
      </AI:Dates>
      <AI:RecurrenceCounter xsi:type="xsd:int">0</AI:RecurrenceCounter>
      <AI:IsRecurrence xsi:type="xsd:boolean">false</AI:IsRecurrence>
     </AI:Recurrence>
     <AI:Participants xsi:type="AI:ArrayOfParticipantInfo">
      <AI:ParticipantInfo xsi:type="AI:ParticipantInfo">
       <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
       <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
       <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
       <AI:EmailId xsi:type="xsd:int">0</AI:EmailId>
       <AI:SendEmail xsi:type="xsd:boolean">false</AI:SendEmail>
       <AI:InvitationStatus xsi:type="AI:InvitationStatus">Unknown</AI:InvitationStatus>
       <AI:EmailAddress xsi:type="xsd:string"></AI:EmailAddress>
       <AI:Description xsi:type="xsd:string"></AI:Description>
      </AI:ParticipantInfo>
     </AI:Participants>
     <AI:AssignmentStatus xsi:type="AI:AssignmentStatus">Unknown</AI:AssignmentStatus>
     <AI:InvitationStatus xsi:type="AI:InvitationStatus">Unknown</AI:InvitationStatus>
     <AI:BookingType xsi:type="AI:BookingType">Unknown</AI:BookingType>
     <AI:ActiveDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:ActiveDate>
     <AI:HasConflict xsi:type="xsd:boolean">false</AI:HasConflict>
     <AI:AssignedBy xsi:type="AI:Associate">
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
     </AI:AssignedBy>
     <AI:MotherAssociate xsi:type="AI:Associate">
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
     </AI:MotherAssociate>
     <AI:Task xsi:type="AI:TaskListItem">
      <AI:TaskListItemId xsi:type="xsd:int">0</AI:TaskListItemId>
      <AI:Value xsi:type="xsd:string"></AI:Value>
      <AI:Direction xsi:type="AI:TaskDirection">Unknown</AI:Direction>
      <AI:Type xsi:type="AI:TaskType">Unknown</AI:Type>
      <AI:Tooltip xsi:type="xsd:string"></AI:Tooltip>
      <AI:Deleted xsi:type="xsd:boolean">false</AI:Deleted>
      <AI:IntentId xsi:type="xsd:int">0</AI:IntentId>
      <AI:Rank xsi:type="xsd:short">0</AI:Rank>
      <AI:IsDefaultAlldayEvent xsi:type="xsd:boolean">false</AI:IsDefaultAlldayEvent>
      <AI:IsDefaultFree xsi:type="xsd:boolean">false</AI:IsDefaultFree>
      <AI:IsDefaultPublished xsi:type="xsd:boolean">false</AI:IsDefaultPublished>
      <AI:ColorIndex xsi:type="AI:ColorIndex">LightBlue</AI:ColorIndex>
      <AI:DefaultVideomeetingStatus xsi:type="AI:VideoMeetingStatus">NoChange</AI:DefaultVideomeetingStatus>
     </AI:Task>
     <AI:PreferredTZLocation xsi:type="xsd:int">0</AI:PreferredTZLocation>
     <AI:PreferredTZLocationData xsi:type="AI:TimeZoneData">
      <AI:TZLocationID xsi:type="xsd:int">0</AI:TZLocationID>
      <AI:Name xsi:type="xsd:string"></AI:Name>
      <AI:TZLocationCode xsi:type="xsd:string"></AI:TZLocationCode>
      <AI:TZLocationCities xsi:type="xsd:string"></AI:TZLocationCities>
      <AI:IsoNumber xsi:type="xsd:int">0</AI:IsoNumber>
      <AI:TimeZoneSTDRules xsi:type="AI:TimeZoneRuleDictionary">
       <AI:TimeZoneRuleKeyValuePair>
        <AI:Key xsi:type="xsd:dateTime"></AI:Key>
        <AI:Value xsi:type="AI:TimeZoneRule">
         <AI:TZOffset xsi:type="xsd:int">0</AI:TZOffset>
         <AI:StartRulePattern xsi:type="xsd:string"></AI:StartRulePattern>
         <AI:EndRulePattern xsi:type="xsd:string"></AI:EndRulePattern>
         <AI:StartDay xsi:type="xsd:int">0</AI:StartDay>
         <AI:StartMonth xsi:type="xsd:int">0</AI:StartMonth>
         <AI:EndDay xsi:type="xsd:int">0</AI:EndDay>
         <AI:EndMonth xsi:type="xsd:int">0</AI:EndMonth>
        </AI:Value>
       </AI:TimeZoneRuleKeyValuePair>
      </AI:TimeZoneSTDRules>
      <AI:TimeZoneDSTRules xsi:type="AI:TimeZoneRuleDictionary">
       <AI:TimeZoneRuleKeyValuePair>
        <AI:Key xsi:type="xsd:dateTime"></AI:Key>
        <AI:Value xsi:type="AI:TimeZoneRule">
         <AI:TZOffset xsi:type="xsd:int">0</AI:TZOffset>
         <AI:StartRulePattern xsi:type="xsd:string"></AI:StartRulePattern>
         <AI:EndRulePattern xsi:type="xsd:string"></AI:EndRulePattern>
         <AI:StartDay xsi:type="xsd:int">0</AI:StartDay>
         <AI:StartMonth xsi:type="xsd:int">0</AI:StartMonth>
         <AI:EndDay xsi:type="xsd:int">0</AI:EndDay>
         <AI:EndMonth xsi:type="xsd:int">0</AI:EndMonth>
        </AI:Value>
       </AI:TimeZoneRuleKeyValuePair>
      </AI:TimeZoneDSTRules>
     </AI:PreferredTZLocationData>
     <AI:Sale xsi:type="AI:Sale">
      <AI:ContactName xsi:type="xsd:string"></AI:ContactName>
      <AI:SaleDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:SaleDate>
      <AI:SaleId xsi:type="xsd:int">0</AI:SaleId>
      <AI:Probability xsi:type="xsd:short">0</AI:Probability>
      <AI:Title xsi:type="xsd:string"></AI:Title>
      <AI:Amount xsi:type="xsd:double">0.0</AI:Amount>
      <AI:Currency xsi:type="xsd:string"></AI:Currency>
      <AI:ProjectName xsi:type="xsd:string"></AI:ProjectName>
      <AI:AssociateFullName xsi:type="xsd:string"></AI:AssociateFullName>
      <AI:Description xsi:type="xsd:string"></AI:Description>
      <AI:Status xsi:type="AI:SaleStatus">Unknown</AI:Status>
      <AI:WeightedAmount xsi:type="xsd:double">0.0</AI:WeightedAmount>
      <AI:ProjectId xsi:type="xsd:int">0</AI:ProjectId>
      <AI:EarningPercent xsi:type="xsd:double">0.0</AI:EarningPercent>
      <AI:Earning xsi:type="xsd:double">0.0</AI:Earning>
      <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
      <AI:AssociateId xsi:type="xsd:int">0</AI:AssociateId>
      <AI:PersonId xsi:type="xsd:int">0</AI:PersonId>
      <AI:SaleTypeId xsi:type="xsd:int">0</AI:SaleTypeId>
      <AI:SaleTypeName xsi:type="xsd:string"></AI:SaleTypeName>
      <AI:PersonFullName xsi:type="xsd:string"></AI:PersonFullName>
      <AI:Completed xsi:type="AI:ActivityStatus">Unknown</AI:Completed>
      <AI:ActiveErpLinks xsi:type="xsd:int">0</AI:ActiveErpLinks>
      <AI:NextDueDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:NextDueDate>
      <AI:Number xsi:type="xsd:string"></AI:Number>
     </AI:Sale>
     <AI:SuggestedAppointmentId xsi:type="xsd:int">0</AI:SuggestedAppointmentId>
     <AI:IsMileStone xsi:type="xsd:boolean">false</AI:IsMileStone>
     <AI:CautionWarning xsi:type="AI:AppointmentCautionWarning">OK</AI:CautionWarning>
     <AI:OwnedExternally xsi:type="AI:AppointmentExternalOwner">None</AI:OwnedExternally>
     <AI:JoinVideomeetUrl xsi:type="xsd:string"></AI:JoinVideomeetUrl>
     <AI:CentralserviceVideomeetId xsi:type="xsd:string"></AI:CentralserviceVideomeetId>
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
     <AI:PublishEventDate xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:PublishEventDate>
     <AI:PublishTo xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:PublishTo>
     <AI:PublishFrom xsi:type="xsd:dateTime">2025-12-18T01:29:18Z</AI:PublishFrom>
     <AI:IsPublished xsi:type="xsd:boolean">false</AI:IsPublished>
     <AI:VisibleFor xsi:type="AI:ArrayOfVisibleFor">
      <AI:VisibleFor xsi:type="AI:VisibleFor">
       <AI:VisibleId xsi:type="xsd:int">0</AI:VisibleId>
       <AI:Visibility xsi:type="AI:Visibility">All</AI:Visibility>
       <AI:DisplayValue xsi:type="xsd:string"></AI:DisplayValue>
      </AI:VisibleFor>
     </AI:VisibleFor>
    </AI:Appointment>
    <AI:IsoLangCode xsi:type="xsd:string"></AI:IsoLangCode>
   </AI:CreateTextForAppointment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateTextForAppointment Response

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
  <AI:CreateTextForAppointmentResponse>
   <AI:Response xsi:type="xsd:string"></AI:Response>
  </AI:CreateTextForAppointmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

