---
uid: services86-ticket-createdefaultticketentity
title: Services86.TicketAgent.CreateDefaultTicketEntity SOAP
Generated: true
---

# Services86 Ticket CreateDefaultTicketEntity SOAP

SOAP request and response examples **Remote/Services86/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ITicketAgent.CreateDefaultTicketEntity">SuperOffice.Services86.ITicketAgent.CreateDefaultTicketEntity</see> method.

## CreateDefaultTicketEntity

Loading default values into a new TicketEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New TicketEntity with default values


[WSDL file for Services86/Ticket](../Services86-Ticket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultTicketEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:CreateDefaultTicketEntity>
   </Ticket:CreateDefaultTicketEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultTicketEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Ticket:CreateDefaultTicketEntityResponse>
   <Ticket:Response xsi:type="Ticket:TicketEntity">
    <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
    <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:CreatedAt>
    <Ticket:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:LastChanged>
    <Ticket:ReadByOwner xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:ReadByOwner>
    <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:ReadByCustomer>
    <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:FirstReadByUser>
    <Ticket:Activate xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:Activate>
    <Ticket:ClosedAt xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:ClosedAt>
    <Ticket:RepliedAt xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:RepliedAt>
    <Ticket:AlertTimeout xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:AlertTimeout>
    <Ticket:Deadline xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:Deadline>
    <Ticket:CreatedBy xsi:type="Ticket:Associate">
     <Ticket:AssociateId xsi:type="xsd:int">0</Ticket:AssociateId>
     <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
     <Ticket:PersonId xsi:type="xsd:int">0</Ticket:PersonId>
     <Ticket:Rank xsi:type="xsd:short">0</Ticket:Rank>
     <Ticket:Tooltip xsi:type="xsd:string"></Ticket:Tooltip>
     <Ticket:Type xsi:type="Ticket:UserType">Unknown</Ticket:Type>
     <Ticket:GroupIdx xsi:type="xsd:int">0</Ticket:GroupIdx>
     <Ticket:FullName xsi:type="xsd:string"></Ticket:FullName>
     <Ticket:FormalName xsi:type="xsd:string"></Ticket:FormalName>
     <Ticket:Deleted xsi:type="xsd:boolean">false</Ticket:Deleted>
     <Ticket:EjUserId xsi:type="xsd:int">0</Ticket:EjUserId>
     <Ticket:UserName xsi:type="xsd:string"></Ticket:UserName>
    </Ticket:CreatedBy>
    <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
    <Ticket:OwnedBy xsi:type="Ticket:Associate">
     <Ticket:AssociateId xsi:type="xsd:int">0</Ticket:AssociateId>
     <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
     <Ticket:PersonId xsi:type="xsd:int">0</Ticket:PersonId>
     <Ticket:Rank xsi:type="xsd:short">0</Ticket:Rank>
     <Ticket:Tooltip xsi:type="xsd:string"></Ticket:Tooltip>
     <Ticket:Type xsi:type="Ticket:UserType">Unknown</Ticket:Type>
     <Ticket:GroupIdx xsi:type="xsd:int">0</Ticket:GroupIdx>
     <Ticket:FullName xsi:type="xsd:string"></Ticket:FullName>
     <Ticket:FormalName xsi:type="xsd:string"></Ticket:FormalName>
     <Ticket:Deleted xsi:type="xsd:boolean">false</Ticket:Deleted>
     <Ticket:EjUserId xsi:type="xsd:int">0</Ticket:EjUserId>
     <Ticket:UserName xsi:type="xsd:string"></Ticket:UserName>
    </Ticket:OwnedBy>
    <Ticket:Category xsi:type="Ticket:TicketCategoryEntity">
     <Ticket:TicketCategoryId xsi:type="xsd:int">0</Ticket:TicketCategoryId>
     <Ticket:ParentId xsi:type="xsd:int">0</Ticket:ParentId>
     <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
     <Ticket:Fullname xsi:type="xsd:string"></Ticket:Fullname>
     <Ticket:CategoryMaster xsi:type="xsd:int">0</Ticket:CategoryMaster>
     <Ticket:Flags xsi:type="Ticket:TicketCategoryFlags">Internal</Ticket:Flags>
     <Ticket:DelegateMethod xsi:type="Ticket:TicketCategoryDelegateMethod">Unknown</Ticket:DelegateMethod>
     <Ticket:ExternalName xsi:type="xsd:string"></Ticket:ExternalName>
     <Ticket:ClosingStatus xsi:type="Ticket:TicketCategoryClosingStatus">UserDefined</Ticket:ClosingStatus>
     <Ticket:MsgClosingStatus xsi:type="Ticket:TicketCategoryClosingStatus">UserDefined</Ticket:MsgClosingStatus>
     <Ticket:AssignmentLag xsi:type="xsd:int">0</Ticket:AssignmentLag>
     <Ticket:ReplyTemplate xsi:type="xsd:int">0</Ticket:ReplyTemplate>
     <Ticket:NotificationEmail xsi:type="xsd:string"></Ticket:NotificationEmail>
     <Ticket:ExtraFields xsi:type="Ticket:StringDictionary">
      <Ticket:StringKeyValuePair>
       <Ticket:Key xsi:type="xsd:string"></Ticket:Key>
       <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
      </Ticket:StringKeyValuePair>
     </Ticket:ExtraFields>
    </Ticket:Category>
    <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
    <Ticket:Priority xsi:type="Ticket:TicketPriorityEntity">
     <Ticket:TicketPriorityId xsi:type="xsd:int">0</Ticket:TicketPriorityId>
     <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
     <Ticket:Status xsi:type="Ticket:TicketPriorityStatus">Unknown</Ticket:Status>
     <Ticket:Flags xsi:type="Ticket:TicketPriorityFlags">External</Ticket:Flags>
     <Ticket:SortOrder xsi:type="xsd:int">0</Ticket:SortOrder>
     <Ticket:TicketRead xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:TicketRead>
     <Ticket:ChangedOwner xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:ChangedOwner>
     <Ticket:TicketNewinfo xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:TicketNewinfo>
     <Ticket:TicketClosed xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:TicketClosed>
     <Ticket:TicketChangedPriority xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:TicketChangedPriority>
     <Ticket:TicketNew xsi:type="Ticket:TicketPriorityEscalateEvent">None</Ticket:TicketNew>
     <Ticket:Deadline xsi:type="xsd:int">0</Ticket:Deadline>
     <Ticket:MonStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:MonStart>
     <Ticket:MonStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:MonStop>
     <Ticket:TueStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:TueStart>
     <Ticket:TueStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:TueStop>
     <Ticket:WedStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:WedStart>
     <Ticket:WedStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:WedStop>
     <Ticket:ThuStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:ThuStart>
     <Ticket:ThuStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:ThuStop>
     <Ticket:FriStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:FriStart>
     <Ticket:FriStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:FriStop>
     <Ticket:SatStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:SatStart>
     <Ticket:SatStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:SatStop>
     <Ticket:SunStart xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:SunStart>
     <Ticket:SunStop xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:SunStop>
     <Ticket:NonDates xsi:type="NetServerServices862:ArrayOfdateTime">
      <NetServerServices862:dateTime xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</NetServerServices862:dateTime>
     </Ticket:NonDates>
    </Ticket:Priority>
    <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
    <Ticket:Status xsi:type="Ticket:TicketStatusEntity">
     <Ticket:TicketStatusId xsi:type="xsd:int">0</Ticket:TicketStatusId>
     <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
     <Ticket:Status xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:Status>
     <Ticket:TimeCounter xsi:type="Ticket:TicketStatusTimeCounter">None</Ticket:TimeCounter>
     <Ticket:NoEmailReopen xsi:type="xsd:boolean">false</Ticket:NoEmailReopen>
    </Ticket:Status>
    <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
    <Ticket:Person xsi:type="Ticket:Person">
     <Ticket:Position xsi:type="xsd:string"></Ticket:Position>
     <Ticket:PersonId xsi:type="xsd:int">0</Ticket:PersonId>
     <Ticket:Mrmrs xsi:type="xsd:string"></Ticket:Mrmrs>
     <Ticket:Firstname xsi:type="xsd:string"></Ticket:Firstname>
     <Ticket:Lastname xsi:type="xsd:string"></Ticket:Lastname>
     <Ticket:MiddleName xsi:type="xsd:string"></Ticket:MiddleName>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:Description xsi:type="xsd:string"></Ticket:Description>
     <Ticket:Email xsi:type="xsd:string"></Ticket:Email>
     <Ticket:FullName xsi:type="xsd:string"></Ticket:FullName>
     <Ticket:DirectPhone xsi:type="xsd:string"></Ticket:DirectPhone>
     <Ticket:FormalName xsi:type="xsd:string"></Ticket:FormalName>
     <Ticket:CountryId xsi:type="xsd:int">0</Ticket:CountryId>
     <Ticket:ContactId xsi:type="xsd:int">0</Ticket:ContactId>
     <Ticket:ContactName xsi:type="xsd:string"></Ticket:ContactName>
     <Ticket:Retired xsi:type="xsd:short">0</Ticket:Retired>
     <Ticket:Rank xsi:type="xsd:short">0</Ticket:Rank>
     <Ticket:ActiveInterests xsi:type="xsd:short">0</Ticket:ActiveInterests>
     <Ticket:ContactDepartment xsi:type="xsd:string"></Ticket:ContactDepartment>
     <Ticket:ContactCountryId xsi:type="xsd:int">0</Ticket:ContactCountryId>
     <Ticket:ContactOrgNr xsi:type="xsd:string"></Ticket:ContactOrgNr>
     <Ticket:FaxPhone xsi:type="xsd:string"></Ticket:FaxPhone>
     <Ticket:MobilePhone xsi:type="xsd:string"></Ticket:MobilePhone>
     <Ticket:ContactPhone xsi:type="xsd:string"></Ticket:ContactPhone>
     <Ticket:AssociateName xsi:type="xsd:string"></Ticket:AssociateName>
     <Ticket:AssociateId xsi:type="xsd:int">0</Ticket:AssociateId>
     <Ticket:UsePersonAddress xsi:type="xsd:boolean">false</Ticket:UsePersonAddress>
     <Ticket:ContactFax xsi:type="xsd:string"></Ticket:ContactFax>
     <Ticket:Kanafname xsi:type="xsd:string"></Ticket:Kanafname>
     <Ticket:Kanalname xsi:type="xsd:string"></Ticket:Kanalname>
     <Ticket:Post1 xsi:type="xsd:string"></Ticket:Post1>
     <Ticket:Post2 xsi:type="xsd:string"></Ticket:Post2>
     <Ticket:Post3 xsi:type="xsd:string"></Ticket:Post3>
     <Ticket:EmailName xsi:type="xsd:string"></Ticket:EmailName>
     <Ticket:ContactFullName xsi:type="xsd:string"></Ticket:ContactFullName>
     <Ticket:ActiveErpLinks xsi:type="xsd:int">0</Ticket:ActiveErpLinks>
     <Ticket:TicketPriorityId xsi:type="xsd:int">0</Ticket:TicketPriorityId>
     <Ticket:SupportLanguageId xsi:type="xsd:int">0</Ticket:SupportLanguageId>
     <Ticket:SupportAssociateId xsi:type="xsd:int">0</Ticket:SupportAssociateId>
    </Ticket:Person>
    <Ticket:AlertLevel xsi:type="xsd:short">0</Ticket:AlertLevel>
    <Ticket:ConnectId xsi:type="xsd:int">0</Ticket:ConnectId>
    <Ticket:ReadStatus xsi:type="Ticket:TicketReadStatus">Unknown</Ticket:ReadStatus>
    <Ticket:TimeToReply xsi:type="xsd:int">0</Ticket:TimeToReply>
    <Ticket:RealTimeToReply xsi:type="xsd:int">0</Ticket:RealTimeToReply>
    <Ticket:TimeToClose xsi:type="xsd:int">0</Ticket:TimeToClose>
    <Ticket:RealTimeToClose xsi:type="xsd:int">0</Ticket:RealTimeToClose>
    <Ticket:TimeSpentInternally xsi:type="xsd:int">0</Ticket:TimeSpentInternally>
    <Ticket:TimeSpentExternally xsi:type="xsd:int">0</Ticket:TimeSpentExternally>
    <Ticket:TimeSpentQueue xsi:type="xsd:int">0</Ticket:TimeSpentQueue>
    <Ticket:RealTimeSpentInternally xsi:type="xsd:int">0</Ticket:RealTimeSpentInternally>
    <Ticket:RealTimeSpentExternally xsi:type="xsd:int">0</Ticket:RealTimeSpentExternally>
    <Ticket:RealTimeSpentQueue xsi:type="xsd:int">0</Ticket:RealTimeSpentQueue>
    <Ticket:HasAttachment xsi:type="xsd:boolean">false</Ticket:HasAttachment>
    <Ticket:NumReplies xsi:type="xsd:int">0</Ticket:NumReplies>
    <Ticket:NumMessages xsi:type="xsd:int">0</Ticket:NumMessages>
    <Ticket:FromAddress xsi:type="xsd:string"></Ticket:FromAddress>
    <Ticket:Messages xsi:type="Ticket:ArrayOfTicketMessage">
     <Ticket:TicketMessage xsi:type="Ticket:TicketMessage">
      <Ticket:TicketMessageId xsi:type="xsd:int">0</Ticket:TicketMessageId>
      <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-03-25T21:36:22Z</Ticket:CreatedAt>
      <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
      <Ticket:Important xsi:type="xsd:boolean">false</Ticket:Important>
     </Ticket:TicketMessage>
    </Ticket:Messages>
    <Ticket:ExtraFields xsi:type="Ticket:StringDictionary">
     <Ticket:StringKeyValuePair>
      <Ticket:Key xsi:type="xsd:string"></Ticket:Key>
      <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
     </Ticket:StringKeyValuePair>
    </Ticket:ExtraFields>
   </Ticket:Response>
  </Ticket:CreateDefaultTicketEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

