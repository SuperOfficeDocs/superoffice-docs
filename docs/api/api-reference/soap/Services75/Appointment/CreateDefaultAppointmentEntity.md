---
uid: services75-appointment-createdefaultappointmententity
title: Services75.AppointmentAgent.CreateDefaultAppointmentEntity SOAP
Generated: true
---

# Services75 Appointment CreateDefaultAppointmentEntity SOAP

SOAP request and response examples **Remote/Services75/Appointment.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IAppointmentAgent.CreateDefaultAppointmentEntity">SuperOffice.Services75.IAppointmentAgent.CreateDefaultAppointmentEntity</see> method.

## CreateDefaultAppointmentEntity

Loading default values into a new AppointmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New AppointmentEntity with default values


[WSDL file for Services75/Appointment](../Services75-Appointment.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultAppointmentEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Appointment:ApplicationToken>1234567-1234-9876</Appointment:ApplicationToken>
  <Appointment:Credentials>
    <Appointment:Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
  </Appointment:Credentials>
 <SOAP-ENV:Body>
   <Appointment:CreateDefaultAppointmentEntity>
   </Appointment:CreateDefaultAppointmentEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultAppointmentEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Appointment="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Appointment:CreateDefaultAppointmentEntityResponse>
   <Appointment:Response xsi:type="Appointment:AppointmentEntity">
    <Appointment:Associate xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:Associate>
    <Appointment:Contact xsi:type="Appointment:Contact">
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:OrgNr xsi:type="xsd:string"></Appointment:OrgNr>
     <Appointment:Department xsi:type="xsd:string"></Appointment:Department>
     <Appointment:URL xsi:type="xsd:string"></Appointment:URL>
     <Appointment:City xsi:type="xsd:string"></Appointment:City>
     <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
     <Appointment:EmailAddress xsi:type="xsd:string"></Appointment:EmailAddress>
     <Appointment:Kananame xsi:type="xsd:string"></Appointment:Kananame>
     <Appointment:EmailAddressName xsi:type="xsd:string"></Appointment:EmailAddressName>
     <Appointment:URLName xsi:type="xsd:string"></Appointment:URLName>
     <Appointment:AssociateFullName xsi:type="xsd:string"></Appointment:AssociateFullName>
     <Appointment:BusinessName xsi:type="xsd:string"></Appointment:BusinessName>
     <Appointment:CategoryName xsi:type="xsd:string"></Appointment:CategoryName>
     <Appointment:CountryName xsi:type="xsd:string"></Appointment:CountryName>
     <Appointment:Address xsi:type="Appointment:Address">
      <Appointment:Wgs84Latitude xsi:type="xsd:double">0.0</Appointment:Wgs84Latitude>
      <Appointment:Wgs84Longitude xsi:type="xsd:double">0.0</Appointment:Wgs84Longitude>
      <Appointment:LocalizedAddress xsi:type="Appointment:ArrayOfArrayOfLocalizedField">
       <Appointment:ArrayOfLocalizedField xsi:type="Appointment:ArrayOfLocalizedField">
        <Appointment:LocalizedField xsi:type="Appointment:LocalizedField">
         <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
         <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
         <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
         <Appointment:Label xsi:type="xsd:string"></Appointment:Label>
         <Appointment:ValueLength xsi:type="xsd:int">0</Appointment:ValueLength>
         <Appointment:AddressType xsi:type="xsd:string"></Appointment:AddressType>
        </Appointment:LocalizedField>
       </Appointment:ArrayOfLocalizedField>
      </Appointment:LocalizedAddress>
     </Appointment:Address>
     <Appointment:FormattedAddress xsi:type="xsd:string"></Appointment:FormattedAddress>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:IsOwnerContact xsi:type="xsd:boolean">false</Appointment:IsOwnerContact>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
    </Appointment:Contact>
    <Appointment:CreatedBy xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:CreatedBy>
    <Appointment:UpdatedBy xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:UpdatedBy>
    <Appointment:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:CreatedDate>
    <Appointment:AppointmentId xsi:type="xsd:int">0</Appointment:AppointmentId>
    <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
    <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:StartDate>
    <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:EndDate>
    <Appointment:InvitedPerson xsi:type="Appointment:Person">
     <Appointment:Position xsi:type="xsd:string"></Appointment:Position>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Mrmrs xsi:type="xsd:string"></Appointment:Mrmrs>
     <Appointment:Firstname xsi:type="xsd:string"></Appointment:Firstname>
     <Appointment:Lastname xsi:type="xsd:string"></Appointment:Lastname>
     <Appointment:MiddleName xsi:type="xsd:string"></Appointment:MiddleName>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:Email xsi:type="xsd:string"></Appointment:Email>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:Retired xsi:type="xsd:short">0</Appointment:Retired>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:ActiveInterests xsi:type="xsd:short">0</Appointment:ActiveInterests>
     <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
     <Appointment:ContactCountryId xsi:type="xsd:int">0</Appointment:ContactCountryId>
     <Appointment:ContactOrgNr xsi:type="xsd:string"></Appointment:ContactOrgNr>
     <Appointment:FaxPhone xsi:type="xsd:string"></Appointment:FaxPhone>
     <Appointment:MobilePhone xsi:type="xsd:string"></Appointment:MobilePhone>
     <Appointment:ContactPhone xsi:type="xsd:string"></Appointment:ContactPhone>
     <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:UsePersonAddress xsi:type="xsd:boolean">false</Appointment:UsePersonAddress>
     <Appointment:ContactFax xsi:type="xsd:string"></Appointment:ContactFax>
     <Appointment:Kanafname xsi:type="xsd:string"></Appointment:Kanafname>
     <Appointment:Kanalname xsi:type="xsd:string"></Appointment:Kanalname>
     <Appointment:Post1 xsi:type="xsd:string"></Appointment:Post1>
     <Appointment:Post2 xsi:type="xsd:string"></Appointment:Post2>
     <Appointment:Post3 xsi:type="xsd:string"></Appointment:Post3>
     <Appointment:EmailName xsi:type="xsd:string"></Appointment:EmailName>
     <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
    </Appointment:InvitedPerson>
    <Appointment:Person xsi:type="Appointment:Person">
     <Appointment:Position xsi:type="xsd:string"></Appointment:Position>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Mrmrs xsi:type="xsd:string"></Appointment:Mrmrs>
     <Appointment:Firstname xsi:type="xsd:string"></Appointment:Firstname>
     <Appointment:Lastname xsi:type="xsd:string"></Appointment:Lastname>
     <Appointment:MiddleName xsi:type="xsd:string"></Appointment:MiddleName>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:Email xsi:type="xsd:string"></Appointment:Email>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:DirectPhone xsi:type="xsd:string"></Appointment:DirectPhone>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:CountryId xsi:type="xsd:int">0</Appointment:CountryId>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:Retired xsi:type="xsd:short">0</Appointment:Retired>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:ActiveInterests xsi:type="xsd:short">0</Appointment:ActiveInterests>
     <Appointment:ContactDepartment xsi:type="xsd:string"></Appointment:ContactDepartment>
     <Appointment:ContactCountryId xsi:type="xsd:int">0</Appointment:ContactCountryId>
     <Appointment:ContactOrgNr xsi:type="xsd:string"></Appointment:ContactOrgNr>
     <Appointment:FaxPhone xsi:type="xsd:string"></Appointment:FaxPhone>
     <Appointment:MobilePhone xsi:type="xsd:string"></Appointment:MobilePhone>
     <Appointment:ContactPhone xsi:type="xsd:string"></Appointment:ContactPhone>
     <Appointment:AssociateName xsi:type="xsd:string"></Appointment:AssociateName>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:UsePersonAddress xsi:type="xsd:boolean">false</Appointment:UsePersonAddress>
     <Appointment:ContactFax xsi:type="xsd:string"></Appointment:ContactFax>
     <Appointment:Kanafname xsi:type="xsd:string"></Appointment:Kanafname>
     <Appointment:Kanalname xsi:type="xsd:string"></Appointment:Kanalname>
     <Appointment:Post1 xsi:type="xsd:string"></Appointment:Post1>
     <Appointment:Post2 xsi:type="xsd:string"></Appointment:Post2>
     <Appointment:Post3 xsi:type="xsd:string"></Appointment:Post3>
     <Appointment:EmailName xsi:type="xsd:string"></Appointment:EmailName>
     <Appointment:ContactFullName xsi:type="xsd:string"></Appointment:ContactFullName>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
    </Appointment:Person>
    <Appointment:MotherId xsi:type="xsd:int">0</Appointment:MotherId>
    <Appointment:Priority xsi:type="Appointment:Priority">
     <Appointment:Id xsi:type="xsd:int">0</Appointment:Id>
     <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
    </Appointment:Priority>
    <Appointment:Private xsi:type="Appointment:AppointmentPrivate">Public</Appointment:Private>
    <Appointment:Project xsi:type="Appointment:Project">
     <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:URL xsi:type="xsd:string"></Appointment:URL>
     <Appointment:Type xsi:type="xsd:string"></Appointment:Type>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:AssociateFullName xsi:type="xsd:string"></Appointment:AssociateFullName>
     <Appointment:TypeId xsi:type="xsd:int">0</Appointment:TypeId>
     <Appointment:Updated xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:Updated>
     <Appointment:StatusId xsi:type="xsd:int">0</Appointment:StatusId>
     <Appointment:Status xsi:type="xsd:string"></Appointment:Status>
     <Appointment:TextId xsi:type="xsd:int">0</Appointment:TextId>
     <Appointment:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:PublishTo>
     <Appointment:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:PublishFrom>
     <Appointment:IsPublished xsi:type="xsd:boolean">false</Appointment:IsPublished>
     <Appointment:URLName xsi:type="xsd:string"></Appointment:URLName>
     <Appointment:ProjectNumber xsi:type="xsd:string"></Appointment:ProjectNumber>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
    </Appointment:Project>
    <Appointment:Type xsi:type="Appointment:AppointmentType">Unknown</Appointment:Type>
    <Appointment:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:UpdatedDate>
    <Appointment:Completed xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Completed>
    <Appointment:ActiveLinks xsi:type="xsd:int">0</Appointment:ActiveLinks>
    <Appointment:Links xsi:type="Appointment:ArrayOfLink">
     <Appointment:Link xsi:type="Appointment:Link">
      <Appointment:EntityName xsi:type="xsd:string"></Appointment:EntityName>
      <Appointment:Id xsi:type="xsd:int">0</Appointment:Id>
      <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
      <Appointment:ExtraInfo xsi:type="xsd:string"></Appointment:ExtraInfo>
      <Appointment:LinkId xsi:type="xsd:int">0</Appointment:LinkId>
     </Appointment:Link>
    </Appointment:Links>
    <Appointment:AlarmLeadTime xsi:type="NetServerServices751:duration"></Appointment:AlarmLeadTime>
    <Appointment:HasAlarm xsi:type="xsd:boolean">false</Appointment:HasAlarm>
    <Appointment:ColorIndex xsi:type="xsd:short">0</Appointment:ColorIndex>
    <Appointment:IsFree xsi:type="xsd:boolean">false</Appointment:IsFree>
    <Appointment:IsAlldayEvent xsi:type="xsd:boolean">false</Appointment:IsAlldayEvent>
    <Appointment:LagTime xsi:type="NetServerServices751:duration"></Appointment:LagTime>
    <Appointment:LeadTime xsi:type="NetServerServices751:duration"></Appointment:LeadTime>
    <Appointment:Location xsi:type="xsd:string"></Appointment:Location>
    <Appointment:RejectCounter xsi:type="xsd:short">0</Appointment:RejectCounter>
    <Appointment:RejectReason xsi:type="xsd:string"></Appointment:RejectReason>
    <Appointment:Recurrence xsi:type="Appointment:RecurrenceInfo">
     <Appointment:RecurrenceId xsi:type="xsd:int">0</Appointment:RecurrenceId>
     <Appointment:StartDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:StartDate>
     <Appointment:EndDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:EndDate>
     <Appointment:RecurrenceEndType xsi:type="Appointment:RecurrenceEndType">Unknown</Appointment:RecurrenceEndType>
     <Appointment:Pattern xsi:type="Appointment:RecurrencePattern">Unknown</Appointment:Pattern>
     <Appointment:DayPattern xsi:type="Appointment:RecurrenceDayPattern">
      <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
      <Appointment:Pattern xsi:type="Appointment:RecurrenceDailyPattern">Unknown</Appointment:Pattern>
     </Appointment:DayPattern>
     <Appointment:WeekPattern xsi:type="Appointment:RecurrenceWeekPattern">
      <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
      <Appointment:Weekdays xsi:type="Appointment:Weekday">Monday</Appointment:Weekdays>
     </Appointment:WeekPattern>
     <Appointment:MonthPattern xsi:type="Appointment:RecurrenceMonthPattern">
      <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
      <Appointment:Day xsi:type="xsd:int">0</Appointment:Day>
      <Appointment:Weekday xsi:type="Appointment:Weekday">Monday</Appointment:Weekday>
      <Appointment:WeekOfMonth xsi:type="Appointment:WeekOfMonth">Unknown</Appointment:WeekOfMonth>
      <Appointment:Pattern xsi:type="Appointment:RecurrenceMonthlyPattern">Unknown</Appointment:Pattern>
     </Appointment:MonthPattern>
     <Appointment:YearPattern xsi:type="Appointment:RecurrenceYearPattern">
      <Appointment:Cycle xsi:type="xsd:int">0</Appointment:Cycle>
      <Appointment:Day xsi:type="xsd:int">0</Appointment:Day>
      <Appointment:Weekday xsi:type="Appointment:Weekday">Monday</Appointment:Weekday>
      <Appointment:WeekOfMonth xsi:type="Appointment:WeekOfMonth">Unknown</Appointment:WeekOfMonth>
      <Appointment:Pattern xsi:type="Appointment:RecurrenceYearlyPattern">Unknown</Appointment:Pattern>
     </Appointment:YearPattern>
     <Appointment:Dates xsi:type="Appointment:ArrayOfRecurrenceDate">
      <Appointment:RecurrenceDate xsi:type="Appointment:RecurrenceDate">
       <Appointment:Date xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:Date>
       <Appointment:IsConflict xsi:type="xsd:boolean">false</Appointment:IsConflict>
       <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
       <Appointment:DescriptionStyleHint xsi:type="xsd:string"></Appointment:DescriptionStyleHint>
       <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
      </Appointment:RecurrenceDate>
     </Appointment:Dates>
     <Appointment:RecurrenceCounter xsi:type="xsd:int">0</Appointment:RecurrenceCounter>
     <Appointment:IsRecurrence xsi:type="xsd:boolean">false</Appointment:IsRecurrence>
    </Appointment:Recurrence>
    <Appointment:Participants xsi:type="Appointment:ArrayOfParticipantInfo">
     <Appointment:ParticipantInfo xsi:type="Appointment:ParticipantInfo">
      <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
      <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
      <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
      <Appointment:EmailId xsi:type="xsd:int">0</Appointment:EmailId>
      <Appointment:SendEmail xsi:type="xsd:boolean">false</Appointment:SendEmail>
      <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
     </Appointment:ParticipantInfo>
    </Appointment:Participants>
    <Appointment:AssignmentStatus xsi:type="Appointment:AssignmentStatus">Unknown</Appointment:AssignmentStatus>
    <Appointment:InvitationStatus xsi:type="Appointment:InvitationStatus">Unknown</Appointment:InvitationStatus>
    <Appointment:BookingType xsi:type="Appointment:BookingType">Unknown</Appointment:BookingType>
    <Appointment:ActiveDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:ActiveDate>
    <Appointment:HasConflict xsi:type="xsd:boolean">false</Appointment:HasConflict>
    <Appointment:AssignedBy xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:AssignedBy>
    <Appointment:MotherAssociate xsi:type="Appointment:Associate">
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:Name xsi:type="xsd:string"></Appointment:Name>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Type xsi:type="Appointment:UserType">Unknown</Appointment:Type>
     <Appointment:GroupIdx xsi:type="xsd:int">0</Appointment:GroupIdx>
     <Appointment:FullName xsi:type="xsd:string"></Appointment:FullName>
     <Appointment:FormalName xsi:type="xsd:string"></Appointment:FormalName>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:EjUserId xsi:type="xsd:int">0</Appointment:EjUserId>
    </Appointment:MotherAssociate>
    <Appointment:Task xsi:type="Appointment:TaskListItem">
     <Appointment:TaskListItemId xsi:type="xsd:int">0</Appointment:TaskListItemId>
     <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
     <Appointment:Direction xsi:type="Appointment:TaskDirection">Unknown</Appointment:Direction>
     <Appointment:Type xsi:type="Appointment:TaskType">Unknown</Appointment:Type>
     <Appointment:Tooltip xsi:type="xsd:string"></Appointment:Tooltip>
     <Appointment:Deleted xsi:type="xsd:boolean">false</Appointment:Deleted>
     <Appointment:IntentId xsi:type="xsd:int">0</Appointment:IntentId>
     <Appointment:Rank xsi:type="xsd:short">0</Appointment:Rank>
     <Appointment:IsDefaultAlldayEvent xsi:type="xsd:boolean">false</Appointment:IsDefaultAlldayEvent>
     <Appointment:IsDefaultFree xsi:type="xsd:boolean">false</Appointment:IsDefaultFree>
     <Appointment:IsDefaultPublished xsi:type="xsd:boolean">false</Appointment:IsDefaultPublished>
     <Appointment:ColorIndex xsi:type="Appointment:ColorIndex">LightBlue</Appointment:ColorIndex>
    </Appointment:Task>
    <Appointment:PreferredTZLocation xsi:type="xsd:int">0</Appointment:PreferredTZLocation>
    <Appointment:Sale xsi:type="Appointment:Sale">
     <Appointment:ContactName xsi:type="xsd:string"></Appointment:ContactName>
     <Appointment:SaleDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:SaleDate>
     <Appointment:SaleId xsi:type="xsd:int">0</Appointment:SaleId>
     <Appointment:Probability xsi:type="xsd:short">0</Appointment:Probability>
     <Appointment:Title xsi:type="xsd:string"></Appointment:Title>
     <Appointment:Amount xsi:type="xsd:double">0.0</Appointment:Amount>
     <Appointment:Currency xsi:type="xsd:string"></Appointment:Currency>
     <Appointment:ProjectName xsi:type="xsd:string"></Appointment:ProjectName>
     <Appointment:AssociateFullName xsi:type="xsd:string"></Appointment:AssociateFullName>
     <Appointment:Description xsi:type="xsd:string"></Appointment:Description>
     <Appointment:Status xsi:type="Appointment:SaleStatus">Unknown</Appointment:Status>
     <Appointment:WeightedAmount xsi:type="xsd:double">0.0</Appointment:WeightedAmount>
     <Appointment:ProjectId xsi:type="xsd:int">0</Appointment:ProjectId>
     <Appointment:EarningPercent xsi:type="xsd:double">0.0</Appointment:EarningPercent>
     <Appointment:Earning xsi:type="xsd:double">0.0</Appointment:Earning>
     <Appointment:ContactId xsi:type="xsd:int">0</Appointment:ContactId>
     <Appointment:AssociateId xsi:type="xsd:int">0</Appointment:AssociateId>
     <Appointment:PersonId xsi:type="xsd:int">0</Appointment:PersonId>
     <Appointment:SaleTypeId xsi:type="xsd:int">0</Appointment:SaleTypeId>
     <Appointment:SaleTypeName xsi:type="xsd:string"></Appointment:SaleTypeName>
     <Appointment:PersonFullName xsi:type="xsd:string"></Appointment:PersonFullName>
     <Appointment:Completed xsi:type="Appointment:ActivityStatus">Unknown</Appointment:Completed>
     <Appointment:ActiveErpLinks xsi:type="xsd:int">0</Appointment:ActiveErpLinks>
    </Appointment:Sale>
    <Appointment:SuggestedAppointmentId xsi:type="xsd:int">0</Appointment:SuggestedAppointmentId>
    <Appointment:IsMileStone xsi:type="xsd:boolean">false</Appointment:IsMileStone>
    <Appointment:UserDefinedFields xsi:type="Appointment:StringDictionary">
     <Appointment:StringKeyValuePair>
      <Appointment:Key xsi:type="xsd:string"></Appointment:Key>
      <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
     </Appointment:StringKeyValuePair>
    </Appointment:UserDefinedFields>
    <Appointment:ExtraFields xsi:type="Appointment:StringDictionary">
     <Appointment:StringKeyValuePair>
      <Appointment:Key xsi:type="xsd:string"></Appointment:Key>
      <Appointment:Value xsi:type="xsd:string"></Appointment:Value>
     </Appointment:StringKeyValuePair>
    </Appointment:ExtraFields>
    <Appointment:PublishEventDate xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:PublishEventDate>
    <Appointment:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:PublishTo>
    <Appointment:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:32:17Z</Appointment:PublishFrom>
    <Appointment:IsPublished xsi:type="xsd:boolean">false</Appointment:IsPublished>
    <Appointment:VisibleFor xsi:type="Appointment:ArrayOfVisibleFor">
     <Appointment:VisibleFor xsi:type="Appointment:VisibleFor">
      <Appointment:VisibleId xsi:type="xsd:int">0</Appointment:VisibleId>
      <Appointment:Visibility xsi:type="Appointment:Visibility">All</Appointment:Visibility>
      <Appointment:DisplayValue xsi:type="xsd:string"></Appointment:DisplayValue>
     </Appointment:VisibleFor>
    </Appointment:VisibleFor>
   </Appointment:Response>
  </Appointment:CreateDefaultAppointmentEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

