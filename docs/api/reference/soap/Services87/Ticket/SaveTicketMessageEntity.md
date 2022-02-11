---
title: Services87.TicketAgent.SaveTicketMessageEntity SOAP
generated: 1
uid: Services87-Ticket-SaveTicketMessageEntity
---

# Services87 Ticket SaveTicketMessageEntity

SOAP request and response examples **Remote/Services87/Ticket.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ITicketAgent.SaveTicketMessageEntity">SuperOffice.Services87.ITicketAgent.SaveTicketMessageEntity</see> method.

## SaveTicketMessageEntity

Updates the existing TicketMessageEntity or creates a new TicketMessageEntity if the id parameter is 0.

* **ticketMessageEntity:** The TicketMessageEntity that is saved.

**Returns:** New or updated TicketMessageEntity


[WSDL file for Services87/Ticket](../Services87-Ticket.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTicketMessageEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Ticket:ApplicationToken>1234567-1234-9876</Ticket:ApplicationToken>
  <Ticket:Credentials>
    <Ticket:Ticket>7T:1234abcxyzExample==</Ticket:Ticket>
  </Ticket:Credentials>
 <SOAP-ENV:Body>
   <Ticket:SaveTicketMessageEntity>
    <Ticket:TicketMessageEntity xsi:type="Ticket:TicketMessageEntity">
     <Ticket:EjMessageId xsi:type="xsd:int">0</Ticket:EjMessageId>
     <Ticket:Ticket xsi:type="Ticket:Ticket">
      <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
      <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
      <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:CreatedAt>
      <Ticket:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:LastChanged>
      <Ticket:ReadByOwner xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ReadByOwner>
      <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ReadByCustomer>
      <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:FirstReadByUser>
      <Ticket:Activate xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:Activate>
      <Ticket:ClosedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ClosedAt>
      <Ticket:RepliedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:RepliedAt>
      <Ticket:AlertTimeout xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:AlertTimeout>
      <Ticket:Deadline xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:Deadline>
      <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
      <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
      <Ticket:OwnedBy xsi:type="xsd:int">0</Ticket:OwnedBy>
      <Ticket:Category xsi:type="xsd:int">0</Ticket:Category>
      <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
      <Ticket:Priority xsi:type="xsd:int">0</Ticket:Priority>
      <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
      <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
      <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
      <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
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
     </Ticket:Ticket>
     <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:CreatedAt>
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
     </Ticket:Person>
     <Ticket:SearchTitle xsi:type="xsd:string"></Ticket:SearchTitle>
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
    </Ticket:TicketMessageEntity>
   </Ticket:SaveTicketMessageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTicketMessageEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Ticket="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Ticket:SaveTicketMessageEntityResponse>
   <Ticket:Response xsi:type="Ticket:TicketMessageEntity">
    <Ticket:EjMessageId xsi:type="xsd:int">0</Ticket:EjMessageId>
    <Ticket:Ticket xsi:type="Ticket:Ticket">
     <Ticket:TicketId xsi:type="xsd:int">0</Ticket:TicketId>
     <Ticket:Title xsi:type="xsd:string"></Ticket:Title>
     <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:CreatedAt>
     <Ticket:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:LastChanged>
     <Ticket:ReadByOwner xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ReadByOwner>
     <Ticket:ReadByCustomer xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ReadByCustomer>
     <Ticket:FirstReadByUser xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:FirstReadByUser>
     <Ticket:Activate xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:Activate>
     <Ticket:ClosedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:ClosedAt>
     <Ticket:RepliedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:RepliedAt>
     <Ticket:AlertTimeout xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:AlertTimeout>
     <Ticket:Deadline xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:Deadline>
     <Ticket:CreatedBy xsi:type="xsd:int">0</Ticket:CreatedBy>
     <Ticket:Author xsi:type="xsd:string"></Ticket:Author>
     <Ticket:OwnedBy xsi:type="xsd:int">0</Ticket:OwnedBy>
     <Ticket:Category xsi:type="xsd:int">0</Ticket:Category>
     <Ticket:Slevel xsi:type="Ticket:TicketSecurityLevel">Unknown</Ticket:Slevel>
     <Ticket:Priority xsi:type="xsd:int">0</Ticket:Priority>
     <Ticket:BaseStatus xsi:type="Ticket:TicketBaseStatus">Unknown</Ticket:BaseStatus>
     <Ticket:TicketStatus xsi:type="xsd:int">0</Ticket:TicketStatus>
     <Ticket:Origin xsi:type="Ticket:TicketOrigin">Unknown</Ticket:Origin>
     <Ticket:CustId xsi:type="xsd:int">0</Ticket:CustId>
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
    </Ticket:Ticket>
    <Ticket:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:28Z</Ticket:CreatedAt>
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
    </Ticket:Person>
    <Ticket:SearchTitle xsi:type="xsd:string"></Ticket:SearchTitle>
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
  </Ticket:SaveTicketMessageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

