---
title: Services88.ChatAgent.PickUpFirstChatSession SOAP
generated: 1
uid: Services88-Chat-PickUpFirstChatSession
---

# Services88 Chat PickUpFirstChatSession

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.PickUpFirstChatSession">SuperOffice.Services88.IChatAgent.PickUpFirstChatSession</see> method.

## PickUpFirstChatSession

'answer' the first available session from the queue: assign the session to the user. The welcome message is sent to the customer.


**Returns:** The picked-up chat session


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## PickUpFirstChatSession Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Chat="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Chat:ApplicationToken>1234567-1234-9876</Chat:ApplicationToken>
  <Chat:Credentials>
    <Chat:Ticket>7T:1234abcxyzExample==</Chat:Ticket>
  </Chat:Credentials>
 <SOAP-ENV:Body>
   <Chat:PickUpFirstChatSession>
   </Chat:PickUpFirstChatSession>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## PickUpFirstChatSession Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Chat="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Chat:PickUpFirstChatSessionResponse>
   <Chat:Response xsi:type="Chat:ChatSessionEntity">
    <Chat:ChatSessionId xsi:type="xsd:int">0</Chat:ChatSessionId>
    <Chat:TopicId xsi:type="xsd:int">0</Chat:TopicId>
    <Chat:User xsi:type="Chat:Associate">
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:PersonId xsi:type="xsd:int">0</Chat:PersonId>
     <Chat:Rank xsi:type="xsd:short">0</Chat:Rank>
     <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
     <Chat:Type xsi:type="Chat:UserType">Unknown</Chat:Type>
     <Chat:GroupIdx xsi:type="xsd:int">0</Chat:GroupIdx>
     <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
     <Chat:FormalName xsi:type="xsd:string"></Chat:FormalName>
     <Chat:Deleted xsi:type="xsd:boolean">false</Chat:Deleted>
     <Chat:EjUserId xsi:type="xsd:int">0</Chat:EjUserId>
     <Chat:UserName xsi:type="xsd:string"></Chat:UserName>
    </Chat:User>
    <Chat:Person xsi:type="Chat:Person">
     <Chat:Position xsi:type="xsd:string"></Chat:Position>
     <Chat:PersonId xsi:type="xsd:int">0</Chat:PersonId>
     <Chat:Mrmrs xsi:type="xsd:string"></Chat:Mrmrs>
     <Chat:Firstname xsi:type="xsd:string"></Chat:Firstname>
     <Chat:Lastname xsi:type="xsd:string"></Chat:Lastname>
     <Chat:MiddleName xsi:type="xsd:string"></Chat:MiddleName>
     <Chat:Title xsi:type="xsd:string"></Chat:Title>
     <Chat:Description xsi:type="xsd:string"></Chat:Description>
     <Chat:Email xsi:type="xsd:string"></Chat:Email>
     <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
     <Chat:DirectPhone xsi:type="xsd:string"></Chat:DirectPhone>
     <Chat:FormalName xsi:type="xsd:string"></Chat:FormalName>
     <Chat:CountryId xsi:type="xsd:int">0</Chat:CountryId>
     <Chat:ContactId xsi:type="xsd:int">0</Chat:ContactId>
     <Chat:ContactName xsi:type="xsd:string"></Chat:ContactName>
     <Chat:Retired xsi:type="xsd:short">0</Chat:Retired>
     <Chat:Rank xsi:type="xsd:short">0</Chat:Rank>
     <Chat:ActiveInterests xsi:type="xsd:short">0</Chat:ActiveInterests>
     <Chat:ContactDepartment xsi:type="xsd:string"></Chat:ContactDepartment>
     <Chat:ContactCountryId xsi:type="xsd:int">0</Chat:ContactCountryId>
     <Chat:ContactOrgNr xsi:type="xsd:string"></Chat:ContactOrgNr>
     <Chat:FaxPhone xsi:type="xsd:string"></Chat:FaxPhone>
     <Chat:MobilePhone xsi:type="xsd:string"></Chat:MobilePhone>
     <Chat:ContactPhone xsi:type="xsd:string"></Chat:ContactPhone>
     <Chat:AssociateName xsi:type="xsd:string"></Chat:AssociateName>
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:UsePersonAddress xsi:type="xsd:boolean">false</Chat:UsePersonAddress>
     <Chat:ContactFax xsi:type="xsd:string"></Chat:ContactFax>
     <Chat:Kanafname xsi:type="xsd:string"></Chat:Kanafname>
     <Chat:Kanalname xsi:type="xsd:string"></Chat:Kanalname>
     <Chat:Post1 xsi:type="xsd:string"></Chat:Post1>
     <Chat:Post2 xsi:type="xsd:string"></Chat:Post2>
     <Chat:Post3 xsi:type="xsd:string"></Chat:Post3>
     <Chat:EmailName xsi:type="xsd:string"></Chat:EmailName>
     <Chat:ContactFullName xsi:type="xsd:string"></Chat:ContactFullName>
     <Chat:ActiveErpLinks xsi:type="xsd:int">0</Chat:ActiveErpLinks>
     <Chat:TicketPriorityId xsi:type="xsd:int">0</Chat:TicketPriorityId>
     <Chat:SupportLanguageId xsi:type="xsd:int">0</Chat:SupportLanguageId>
     <Chat:SupportAssociateId xsi:type="xsd:int">0</Chat:SupportAssociateId>
     <Chat:CategoryName xsi:type="xsd:string"></Chat:CategoryName>
    </Chat:Person>
    <Chat:CustomerAlias xsi:type="xsd:string"></Chat:CustomerAlias>
    <Chat:CustomerHost xsi:type="xsd:string"></Chat:CustomerHost>
    <Chat:CustomerName xsi:type="xsd:string"></Chat:CustomerName>
    <Chat:CustomerEmail xsi:type="xsd:string"></Chat:CustomerEmail>
    <Chat:CustomerPhone xsi:type="xsd:string"></Chat:CustomerPhone>
    <Chat:CustomerConsented xsi:type="xsd:boolean">false</Chat:CustomerConsented>
    <Chat:CustomerCompanyName xsi:type="xsd:string"></Chat:CustomerCompanyName>
    <Chat:Status xsi:type="Chat:ChatSessionStatus">Invalid</Chat:Status>
    <Chat:FirstMessage xsi:type="xsd:string"></Chat:FirstMessage>
    <Chat:LastMessage xsi:type="xsd:string"></Chat:LastMessage>
    <Chat:WhenRequested xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:WhenRequested>
    <Chat:WhenStarted xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:WhenStarted>
    <Chat:WhenEnded xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:WhenEnded>
    <Chat:WhenIdle xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:WhenIdle>
    <Chat:WhenFetched xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:WhenFetched>
    <Chat:SessionKey xsi:type="xsd:string"></Chat:SessionKey>
    <Chat:InitialQueuePos xsi:type="xsd:int">0</Chat:InitialQueuePos>
    <Chat:AlertLevel xsi:type="xsd:int">0</Chat:AlertLevel>
    <Chat:Rank xsi:type="xsd:int">0</Chat:Rank>
    <Chat:Flags xsi:type="Chat:ChatSessionFlags">UserIsTyping</Chat:Flags>
    <Chat:Contact xsi:type="Chat:Contact">
     <Chat:ContactId xsi:type="xsd:int">0</Chat:ContactId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:OrgNr xsi:type="xsd:string"></Chat:OrgNr>
     <Chat:Department xsi:type="xsd:string"></Chat:Department>
     <Chat:URL xsi:type="xsd:string"></Chat:URL>
     <Chat:City xsi:type="xsd:string"></Chat:City>
     <Chat:DirectPhone xsi:type="xsd:string"></Chat:DirectPhone>
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:CountryId xsi:type="xsd:int">0</Chat:CountryId>
     <Chat:EmailAddress xsi:type="xsd:string"></Chat:EmailAddress>
     <Chat:Kananame xsi:type="xsd:string"></Chat:Kananame>
     <Chat:EmailAddressName xsi:type="xsd:string"></Chat:EmailAddressName>
     <Chat:URLName xsi:type="xsd:string"></Chat:URLName>
     <Chat:AssociateFullName xsi:type="xsd:string"></Chat:AssociateFullName>
     <Chat:BusinessName xsi:type="xsd:string"></Chat:BusinessName>
     <Chat:CategoryName xsi:type="xsd:string"></Chat:CategoryName>
     <Chat:CountryName xsi:type="xsd:string"></Chat:CountryName>
     <Chat:Address xsi:type="Chat:Address">
      <Chat:Wgs84Latitude xsi:type="xsd:double">0.0</Chat:Wgs84Latitude>
      <Chat:Wgs84Longitude xsi:type="xsd:double">0.0</Chat:Wgs84Longitude>
      <Chat:LocalizedAddress xsi:type="Chat:ArrayOfArrayOfLocalizedField">
       <Chat:ArrayOfLocalizedField xsi:type="Chat:ArrayOfLocalizedField">
        <Chat:LocalizedField xsi:type="Chat:LocalizedField">
         <Chat:Name xsi:type="xsd:string"></Chat:Name>
         <Chat:Value xsi:type="xsd:string"></Chat:Value>
         <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
         <Chat:Label xsi:type="xsd:string"></Chat:Label>
         <Chat:ValueLength xsi:type="xsd:int">0</Chat:ValueLength>
         <Chat:AddressType xsi:type="xsd:string"></Chat:AddressType>
        </Chat:LocalizedField>
       </Chat:ArrayOfLocalizedField>
      </Chat:LocalizedAddress>
      <Chat:Street xsi:type="Chat:StructuredAddress">
       <Chat:AtypeIdx xsi:type="Chat:AddressType">Unknown</Chat:AtypeIdx>
       <Chat:Address1 xsi:type="xsd:string"></Chat:Address1>
       <Chat:Address2 xsi:type="xsd:string"></Chat:Address2>
       <Chat:Address3 xsi:type="xsd:string"></Chat:Address3>
       <Chat:City xsi:type="xsd:string"></Chat:City>
       <Chat:County xsi:type="xsd:string"></Chat:County>
       <Chat:State xsi:type="xsd:string"></Chat:State>
       <Chat:Zipcode xsi:type="xsd:string"></Chat:Zipcode>
       <Chat:Formatted xsi:type="xsd:string"></Chat:Formatted>
      </Chat:Street>
      <Chat:Postal xsi:type="Chat:StructuredAddress">
       <Chat:AtypeIdx xsi:type="Chat:AddressType">Unknown</Chat:AtypeIdx>
       <Chat:Address1 xsi:type="xsd:string"></Chat:Address1>
       <Chat:Address2 xsi:type="xsd:string"></Chat:Address2>
       <Chat:Address3 xsi:type="xsd:string"></Chat:Address3>
       <Chat:City xsi:type="xsd:string"></Chat:City>
       <Chat:County xsi:type="xsd:string"></Chat:County>
       <Chat:State xsi:type="xsd:string"></Chat:State>
       <Chat:Zipcode xsi:type="xsd:string"></Chat:Zipcode>
       <Chat:Formatted xsi:type="xsd:string"></Chat:Formatted>
      </Chat:Postal>
      <Chat:Formatted xsi:type="xsd:string"></Chat:Formatted>
     </Chat:Address>
     <Chat:FormattedAddress xsi:type="xsd:string"></Chat:FormattedAddress>
     <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
     <Chat:IsOwnerContact xsi:type="xsd:boolean">false</Chat:IsOwnerContact>
     <Chat:ActiveErpLinks xsi:type="xsd:int">0</Chat:ActiveErpLinks>
    </Chat:Contact>
    <Chat:Project xsi:type="Chat:Project">
     <Chat:ProjectId xsi:type="xsd:int">0</Chat:ProjectId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:Description xsi:type="xsd:string"></Chat:Description>
     <Chat:URL xsi:type="xsd:string"></Chat:URL>
     <Chat:Type xsi:type="xsd:string"></Chat:Type>
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:AssociateFullName xsi:type="xsd:string"></Chat:AssociateFullName>
     <Chat:TypeId xsi:type="xsd:int">0</Chat:TypeId>
     <Chat:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:Updated>
     <Chat:StatusId xsi:type="xsd:int">0</Chat:StatusId>
     <Chat:Status xsi:type="xsd:string"></Chat:Status>
     <Chat:TextId xsi:type="xsd:int">0</Chat:TextId>
     <Chat:PublishTo xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:PublishTo>
     <Chat:PublishFrom xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:PublishFrom>
     <Chat:IsPublished xsi:type="xsd:boolean">false</Chat:IsPublished>
     <Chat:URLName xsi:type="xsd:string"></Chat:URLName>
     <Chat:ProjectNumber xsi:type="xsd:string"></Chat:ProjectNumber>
     <Chat:ActiveErpLinks xsi:type="xsd:int">0</Chat:ActiveErpLinks>
    </Chat:Project>
    <Chat:Sale xsi:type="Chat:Sale">
     <Chat:ContactName xsi:type="xsd:string"></Chat:ContactName>
     <Chat:SaleDate xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:SaleDate>
     <Chat:SaleId xsi:type="xsd:int">0</Chat:SaleId>
     <Chat:Probability xsi:type="xsd:short">0</Chat:Probability>
     <Chat:Title xsi:type="xsd:string"></Chat:Title>
     <Chat:Amount xsi:type="xsd:double">0.0</Chat:Amount>
     <Chat:Currency xsi:type="xsd:string"></Chat:Currency>
     <Chat:ProjectName xsi:type="xsd:string"></Chat:ProjectName>
     <Chat:AssociateFullName xsi:type="xsd:string"></Chat:AssociateFullName>
     <Chat:Description xsi:type="xsd:string"></Chat:Description>
     <Chat:Status xsi:type="Chat:SaleStatus">Unknown</Chat:Status>
     <Chat:WeightedAmount xsi:type="xsd:double">0.0</Chat:WeightedAmount>
     <Chat:ProjectId xsi:type="xsd:int">0</Chat:ProjectId>
     <Chat:EarningPercent xsi:type="xsd:double">0.0</Chat:EarningPercent>
     <Chat:Earning xsi:type="xsd:double">0.0</Chat:Earning>
     <Chat:ContactId xsi:type="xsd:int">0</Chat:ContactId>
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:PersonId xsi:type="xsd:int">0</Chat:PersonId>
     <Chat:SaleTypeId xsi:type="xsd:int">0</Chat:SaleTypeId>
     <Chat:SaleTypeName xsi:type="xsd:string"></Chat:SaleTypeName>
     <Chat:PersonFullName xsi:type="xsd:string"></Chat:PersonFullName>
     <Chat:Completed xsi:type="Chat:ActivityStatus">Unknown</Chat:Completed>
     <Chat:ActiveErpLinks xsi:type="xsd:int">0</Chat:ActiveErpLinks>
     <Chat:NextDueDate xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:NextDueDate>
     <Chat:Number xsi:type="xsd:string"></Chat:Number>
    </Chat:Sale>
    <Chat:Ticket xsi:type="Chat:Ticket">
     <Chat:TicketId xsi:type="xsd:int">0</Chat:TicketId>
     <Chat:Title xsi:type="xsd:string"></Chat:Title>
     <Chat:CreatedAt xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:CreatedAt>
     <Chat:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:LastChanged>
     <Chat:ReadByOwner xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:ReadByOwner>
     <Chat:ReadByCustomer xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:ReadByCustomer>
     <Chat:FirstReadByUser xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:FirstReadByUser>
     <Chat:Activate xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:Activate>
     <Chat:ClosedAt xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:ClosedAt>
     <Chat:RepliedAt xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:RepliedAt>
     <Chat:AlertTimeout xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:AlertTimeout>
     <Chat:Deadline xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:Deadline>
     <Chat:CreatedBy xsi:type="xsd:int">0</Chat:CreatedBy>
     <Chat:CreatedByName xsi:type="xsd:string"></Chat:CreatedByName>
     <Chat:Author xsi:type="xsd:string"></Chat:Author>
     <Chat:OwnedBy xsi:type="xsd:int">0</Chat:OwnedBy>
     <Chat:OwnedByName xsi:type="xsd:string"></Chat:OwnedByName>
     <Chat:Category xsi:type="xsd:int">0</Chat:Category>
     <Chat:CategoryName xsi:type="xsd:string"></Chat:CategoryName>
     <Chat:CategoryFullname xsi:type="xsd:string"></Chat:CategoryFullname>
     <Chat:Slevel xsi:type="Chat:TicketSecurityLevel">Unknown</Chat:Slevel>
     <Chat:Priority xsi:type="xsd:int">0</Chat:Priority>
     <Chat:PriorityName xsi:type="xsd:string"></Chat:PriorityName>
     <Chat:BaseStatus xsi:type="Chat:TicketBaseStatus">Unknown</Chat:BaseStatus>
     <Chat:TicketStatus xsi:type="xsd:int">0</Chat:TicketStatus>
     <Chat:TicketStatusDisplayValue xsi:type="xsd:string"></Chat:TicketStatusDisplayValue>
     <Chat:Origin xsi:type="Chat:TicketOrigin">Unknown</Chat:Origin>
     <Chat:CustId xsi:type="xsd:int">0</Chat:CustId>
     <Chat:PersonFirstname xsi:type="xsd:string"></Chat:PersonFirstname>
     <Chat:PersonMiddleName xsi:type="xsd:string"></Chat:PersonMiddleName>
     <Chat:PersonLastname xsi:type="xsd:string"></Chat:PersonLastname>
     <Chat:PersonFullname xsi:type="xsd:string"></Chat:PersonFullname>
     <Chat:AlertLevel xsi:type="xsd:short">0</Chat:AlertLevel>
     <Chat:ConnectId xsi:type="xsd:int">0</Chat:ConnectId>
     <Chat:ReadStatus xsi:type="Chat:TicketReadStatus">Unknown</Chat:ReadStatus>
     <Chat:TimeToReply xsi:type="xsd:int">0</Chat:TimeToReply>
     <Chat:RealTimeToReply xsi:type="xsd:int">0</Chat:RealTimeToReply>
     <Chat:TimeToClose xsi:type="xsd:int">0</Chat:TimeToClose>
     <Chat:RealTimeToClose xsi:type="xsd:int">0</Chat:RealTimeToClose>
     <Chat:TimeSpentInternally xsi:type="xsd:int">0</Chat:TimeSpentInternally>
     <Chat:TimeSpentExternally xsi:type="xsd:int">0</Chat:TimeSpentExternally>
     <Chat:TimeSpentQueue xsi:type="xsd:int">0</Chat:TimeSpentQueue>
     <Chat:RealTimeSpentInternally xsi:type="xsd:int">0</Chat:RealTimeSpentInternally>
     <Chat:RealTimeSpentExternally xsi:type="xsd:int">0</Chat:RealTimeSpentExternally>
     <Chat:RealTimeSpentQueue xsi:type="xsd:int">0</Chat:RealTimeSpentQueue>
     <Chat:HasAttachment xsi:type="xsd:boolean">false</Chat:HasAttachment>
     <Chat:NumReplies xsi:type="xsd:int">0</Chat:NumReplies>
     <Chat:NumMessages xsi:type="xsd:int">0</Chat:NumMessages>
     <Chat:FromAddress xsi:type="xsd:string"></Chat:FromAddress>
     <Chat:ContactId xsi:type="xsd:int">0</Chat:ContactId>
     <Chat:ContactName xsi:type="xsd:string"></Chat:ContactName>
     <Chat:OwnedByAssociateId xsi:type="xsd:int">0</Chat:OwnedByAssociateId>
    </Chat:Ticket>
    <Chat:TransferTo xsi:type="Chat:Associate">
     <Chat:AssociateId xsi:type="xsd:int">0</Chat:AssociateId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:PersonId xsi:type="xsd:int">0</Chat:PersonId>
     <Chat:Rank xsi:type="xsd:short">0</Chat:Rank>
     <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
     <Chat:Type xsi:type="Chat:UserType">Unknown</Chat:Type>
     <Chat:GroupIdx xsi:type="xsd:int">0</Chat:GroupIdx>
     <Chat:FullName xsi:type="xsd:string"></Chat:FullName>
     <Chat:FormalName xsi:type="xsd:string"></Chat:FormalName>
     <Chat:Deleted xsi:type="xsd:boolean">false</Chat:Deleted>
     <Chat:EjUserId xsi:type="xsd:int">0</Chat:EjUserId>
     <Chat:UserName xsi:type="xsd:string"></Chat:UserName>
    </Chat:TransferTo>
    <Chat:ChatbotIsActive xsi:type="xsd:boolean">false</Chat:ChatbotIsActive>
   </Chat:Response>
  </Chat:PickUpFirstChatSessionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

