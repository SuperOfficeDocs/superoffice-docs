---
title: Services88.TicketAgent.CreateDefaultTicketMessageEntity SOAP
generated: true
uid: Services88-Ticket-CreateDefaultTicketMessageEntity
---

# Services88 Ticket CreateDefaultTicketMessageEntity

SOAP request and response examples **Remote/Services88/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITicketAgent.CreateDefaultTicketMessageEntity">SuperOffice.Services88.ITicketAgent.CreateDefaultTicketMessageEntity</see> method.

## CreateDefaultTicketMessageEntity





[WSDL file for Services88/Ticket](../Services88-Ticket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultTicketMessageEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:CreateDefaultTicketMessageEntity>
   </Ticket:CreateDefaultTicketMessageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultTicketMessageEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Ticket:CreateDefaultTicketMessageEntityResponse>
   <Ticket:Response xsi:type="Ticket:TicketMessageEntity">
    <Ticket:EjMessageId xsi:type="xsd:int">0</Ticket:EjMessageId>
    <Ticket:Ticket xsi:type="Ticket:Ticket">
     <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:CreatedAt xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:CreatedAt>
     <Ticket:LastChanged xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:LastChanged>
     <Ticket:ReadByOwner xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:ReadByOwner>
     <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:ReadByCustomer>
     <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:FirstReadByUser>
     <Ticket:Activate xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:Activate>
     <Ticket:ClosedAt xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:ClosedAt>
     <Ticket:RepliedAt xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:RepliedAt>
     <Ticket:AlertTimeout xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:AlertTimeout>
     <Ticket:Deadline xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:Deadline>
     <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
     <Ticket:CreatedByName xsi:type="xsd:string"></Ticket:CreatedByName>
     <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
     <Ticket:OwnedBy xsi:type="xsd:int">0</Ticket:OwnedBy>
     <Ticket:OwnedByName xsi:type="xsd:string"></Ticket:OwnedByName>
     <Ticket:Category xsi:type="xsd:int">0</Ticket:Category>
     <Ticket:CategoryName xsi:type="xsd:string"></Ticket:CategoryName>
     <Ticket:CategoryFullname xsi:type="xsd:string"></Ticket:CategoryFullname>
     <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
     <Ticket:Priority xsi:type="xsd:int">0</Ticket:Priority>
     <Ticket:PriorityName xsi:type="xsd:string"></Ticket:PriorityName>
     <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
     <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
     <Ticket:TicketStatusDisplayValue xsi:type="xsd:string"></Ticket:TicketStatusDisplayValue>
     <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
     <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
     <Ticket:PersonFirstname xsi:type="xsd:string"></Ticket:PersonFirstname>
     <Ticket:PersonMiddleName xsi:type="xsd:string"></Ticket:PersonMiddleName>
     <Ticket:PersonLastname xsi:type="xsd:string"></Ticket:PersonLastname>
     <Ticket:PersonFullname xsi:type="xsd:string"></Ticket:PersonFullname>
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
     <Ticket:TimeSpent xsi:type="xsd:int">0</Ticket:TimeSpent>
     <Ticket:HasAttachment xsi:type="xsd:boolean">false</Ticket:HasAttachment>
     <Ticket:NumReplies xsi:type="xsd:int">0</Ticket:NumReplies>
     <Ticket:NumMessages xsi:type="xsd:int">0</Ticket:NumMessages>
     <Ticket:FromAddress xsi:type="xsd:string"></Ticket:FromAddress>
     <Ticket:ContactId xsi:type="xsd:int">0</Ticket:ContactId>
     <Ticket:ContactName xsi:type="xsd:string"></Ticket:ContactName>
     <Ticket:OwnedByAssociateId xsi:type="xsd:int">0</Ticket:OwnedByAssociateId>
     <Ticket:Language xsi:type="xsd:string"></Ticket:Language>
     <Ticket:Sentiment xsi:type="xsd:int">0</Ticket:Sentiment>
     <Ticket:SentimentConfidence xsi:type="xsd:int">0</Ticket:SentimentConfidence>
     <Ticket:SaleId xsi:type="xsd:int">0</Ticket:SaleId>
     <Ticket:ProjectId xsi:type="xsd:int">0</Ticket:ProjectId>
     <Ticket:SaleHeading xsi:type="xsd:string"></Ticket:SaleHeading>
     <Ticket:ProjectName xsi:type="xsd:string"></Ticket:ProjectName>
     <Ticket:FormSubmissionId xsi:type="xsd:int">0</Ticket:FormSubmissionId>
     <Ticket:TicketTypeId xsi:type="xsd:int">0</Ticket:TicketTypeId>
     <Ticket:TicketTypeName xsi:type="xsd:string"></Ticket:TicketTypeName>
    </Ticket:Ticket>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2025-06-26T01:44:56Z</Ticket:CreatedAt>
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
    <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
    <Ticket:Type xsi:type="Ticket:TicketMessageType">Unknown</Ticket:Type>
    <Ticket:MessageId xsi:type="xsd:string"></Ticket:MessageId>
    <Ticket:TimeSpent xsi:type="xsd:int">0</Ticket:TimeSpent>
    <Ticket:Body xsi:type="xsd:string"></Ticket:Body>
    <Ticket:HtmlBody xsi:type="xsd:string"></Ticket:HtmlBody>
    <Ticket:EmailHeader xsi:type="xsd:string"></Ticket:EmailHeader>
    <Ticket:DebugInfo xsi:type="xsd:string"></Ticket:DebugInfo>
    <Ticket:MailSorter xsi:type="xsd:string"></Ticket:MailSorter>
    <Ticket:MessageCategory xsi:type="Ticket:TicketMessageCategory">Message</Ticket:MessageCategory>
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
     <Ticket:CategoryName xsi:type="xsd:string"></Ticket:CategoryName>
     <Ticket:PersonNumber xsi:type="xsd:string"></Ticket:PersonNumber>
    </Ticket:Person>
    <Ticket:SearchTitle xsi:type="xsd:string"></Ticket:SearchTitle>
    <Ticket:MessageHeaders xsi:type="Ticket:ArrayOfTicketMessageHeader">
     <Ticket:TicketMessageHeader xsi:type="Ticket:TicketMessageHeader">
      <Ticket:Id xsi:type="xsd:int">0</Ticket:Id>
      <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
      <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
      <Ticket:StdItem xsi:type="Ticket:MessageHeaderStdItem">None</Ticket:StdItem>
      <Ticket:StdItemCol xsi:type="Ticket:MessageHeaderStdItemCol">None</Ticket:StdItemCol>
     </Ticket:TicketMessageHeader>
    </Ticket:MessageHeaders>
    <Ticket:Important xsi:type="xsd:boolean">false</Ticket:Important>
    <Ticket:Language xsi:type="xsd:string"></Ticket:Language>
    <Ticket:Sentiment xsi:type="xsd:int">0</Ticket:Sentiment>
    <Ticket:SentimentConfidence xsi:type="xsd:int">0</Ticket:SentimentConfidence>
    <Ticket:Badge xsi:type="Ticket:BadgeType">Unknown</Ticket:Badge>
    <Ticket:AttachmentsInfo xsi:type="Ticket:ArrayOfAttachmentEntity">
     <Ticket:AttachmentEntity xsi:type="Ticket:AttachmentEntity">
      <Ticket:AttachmentId xsi:type="xsd:int">0</Ticket:AttachmentId>
      <Ticket:Name xsi:type="xsd:string"></Ticket:Name>
      <Ticket:ContentType xsi:type="xsd:string"></Ticket:ContentType>
      <Ticket:AttSize xsi:type="xsd:int">0</Ticket:AttSize>
      <Ticket:InlineImage xsi:type="xsd:boolean">false</Ticket:InlineImage>
      <Ticket:ContentId xsi:type="xsd:string"></Ticket:ContentId>
      <Ticket:AuthKey xsi:type="xsd:string"></Ticket:AuthKey>
      <Ticket:IsSafeFileExtension xsi:type="xsd:boolean">false</Ticket:IsSafeFileExtension>
     </Ticket:AttachmentEntity>
    </Ticket:AttachmentsInfo>
    <Ticket:ExtraFields xsi:type="Ticket:StringDictionary">
     <Ticket:StringKeyValuePair>
      <Ticket:Key xsi:type="xsd:string"></Ticket:Key>
      <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
     </Ticket:StringKeyValuePair>
    </Ticket:ExtraFields>
    <Ticket:CustomFields xsi:type="Ticket:StringDictionary">
     <Ticket:StringKeyValuePair>
      <Ticket:Key xsi:type="xsd:string"></Ticket:Key>
      <Ticket:Value xsi:type="xsd:string"></Ticket:Value>
     </Ticket:StringKeyValuePair>
    </Ticket:CustomFields>
   </Ticket:Response>
  </Ticket:CreateDefaultTicketMessageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

