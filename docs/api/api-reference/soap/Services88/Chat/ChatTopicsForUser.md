---
uid: services88-chat-chattopicsforuser
title: Services88.ChatAgent.ChatTopicsForUser SOAP
Generated: true
---

# Services88 Chat ChatTopicsForUser SOAP

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.ChatTopicsForUser">SuperOffice.Services88.IChatAgent.ChatTopicsForUser</see> method.

## ChatTopicsForUser

Get all chat topics which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat topics the current user can access


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChatTopicsForUser Request

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
   <Chat:ChatTopicsForUser>
   </Chat:ChatTopicsForUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChatTopicsForUser Response

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
  <Chat:ChatTopicsForUserResponse>
   <Chat:Response xsi:type="Chat:ArrayOfChatTopicEntity">
    <Chat:ChatTopicEntity xsi:type="Chat:ChatTopicEntity">
     <Chat:ChatTopicId xsi:type="xsd:int">0</Chat:ChatTopicId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:Description xsi:type="xsd:string"></Chat:Description>
     <Chat:WelcomeMessage xsi:type="xsd:string"></Chat:WelcomeMessage>
     <Chat:Language xsi:type="Chat:CustomerLanguage">
      <Chat:Id xsi:type="xsd:int">0</Chat:Id>
      <Chat:Value xsi:type="xsd:string"></Chat:Value>
      <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
     </Chat:Language>
     <Chat:LastAccept xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:LastAccept>
     <Chat:SecondsPrAccept xsi:type="xsd:int">0</Chat:SecondsPrAccept>
     <Chat:AlertRecipient xsi:type="xsd:string"></Chat:AlertRecipient>
     <Chat:AlertTemplate xsi:type="Chat:ReplyTemplate">
      <Chat:ReplyTemplateId xsi:type="xsd:int">0</Chat:ReplyTemplateId>
      <Chat:Name xsi:type="xsd:string"></Chat:Name>
      <Chat:Description xsi:type="xsd:string"></Chat:Description>
      <Chat:FolderId xsi:type="xsd:int">0</Chat:FolderId>
     </Chat:AlertTemplate>
     <Chat:Flags xsi:type="Chat:ChatTopicFlag">PopupAlert</Chat:Flags>
     <Chat:BadgeHeader xsi:type="xsd:string"></Chat:BadgeHeader>
     <Chat:CustomQueueText xsi:type="xsd:string"></Chat:CustomQueueText>
     <Chat:WarnNewChatSeconds xsi:type="xsd:int">0</Chat:WarnNewChatSeconds>
     <Chat:WarnManagerNewChatSeconds xsi:type="xsd:int">0</Chat:WarnManagerNewChatSeconds>
     <Chat:TicketEnabled xsi:type="xsd:boolean">false</Chat:TicketEnabled>
     <Chat:TicketCategory xsi:type="Chat:TicketCategory">
      <Chat:Id xsi:type="xsd:int">0</Chat:Id>
      <Chat:Value xsi:type="xsd:string"></Chat:Value>
      <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
     </Chat:TicketCategory>
     <Chat:TicketPriority xsi:type="Chat:TicketPriority">
      <Chat:Id xsi:type="xsd:int">0</Chat:Id>
      <Chat:Value xsi:type="xsd:string"></Chat:Value>
      <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
     </Chat:TicketPriority>
     <Chat:OpeningHoursEnabled xsi:type="xsd:boolean">false</Chat:OpeningHoursEnabled>
     <Chat:OpeningHours xsi:type="Chat:ChatOpeningHours">
      <Chat:TzLocation xsi:type="Chat:TimeZoneData">
       <Chat:TZLocationID xsi:type="xsd:int">0</Chat:TZLocationID>
       <Chat:Name xsi:type="xsd:string"></Chat:Name>
       <Chat:TZLocationCode xsi:type="xsd:string"></Chat:TZLocationCode>
       <Chat:TZLocationCities xsi:type="xsd:string"></Chat:TZLocationCities>
       <Chat:IsoNumber xsi:type="xsd:int">0</Chat:IsoNumber>
       <Chat:TimeZoneSTDRules xsi:type="Chat:TimeZoneRuleDictionary">
        <Chat:TimeZoneRuleKeyValuePair>
         <Chat:Key xsi:type="xsd:dateTime"></Chat:Key>
         <Chat:Value xsi:type="Chat:TimeZoneRule">
          <Chat:TZOffset xsi:nil="true"></Chat:TZOffset>
          <Chat:StartRulePattern xsi:type="xsd:string"></Chat:StartRulePattern>
          <Chat:EndRulePattern xsi:type="xsd:string"></Chat:EndRulePattern>
          <Chat:StartDay xsi:nil="true"></Chat:StartDay>
          <Chat:StartMonth xsi:nil="true"></Chat:StartMonth>
          <Chat:EndDay xsi:nil="true"></Chat:EndDay>
          <Chat:EndMonth xsi:nil="true"></Chat:EndMonth>
         </Chat:Value>
        </Chat:TimeZoneRuleKeyValuePair>
       </Chat:TimeZoneSTDRules>
       <Chat:TimeZoneDSTRules xsi:type="Chat:TimeZoneRuleDictionary">
        <Chat:TimeZoneRuleKeyValuePair>
         <Chat:Key xsi:type="xsd:dateTime"></Chat:Key>
         <Chat:Value xsi:type="Chat:TimeZoneRule">
          <Chat:TZOffset xsi:nil="true"></Chat:TZOffset>
          <Chat:StartRulePattern xsi:type="xsd:string"></Chat:StartRulePattern>
          <Chat:EndRulePattern xsi:type="xsd:string"></Chat:EndRulePattern>
          <Chat:StartDay xsi:nil="true"></Chat:StartDay>
          <Chat:StartMonth xsi:nil="true"></Chat:StartMonth>
          <Chat:EndDay xsi:nil="true"></Chat:EndDay>
          <Chat:EndMonth xsi:nil="true"></Chat:EndMonth>
         </Chat:Value>
        </Chat:TimeZoneRuleKeyValuePair>
       </Chat:TimeZoneDSTRules>
      </Chat:TzLocation>
      <Chat:MonEnabled xsi:type="xsd:boolean">false</Chat:MonEnabled>
      <Chat:MonStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:MonStart>
      <Chat:MonStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:MonStop>
      <Chat:TueEnabled xsi:type="xsd:boolean">false</Chat:TueEnabled>
      <Chat:TueStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:TueStart>
      <Chat:TueStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:TueStop>
      <Chat:WedEnabled xsi:type="xsd:boolean">false</Chat:WedEnabled>
      <Chat:WedStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:WedStart>
      <Chat:WedStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:WedStop>
      <Chat:ThuEnabled xsi:type="xsd:boolean">false</Chat:ThuEnabled>
      <Chat:ThuStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:ThuStart>
      <Chat:ThuStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:ThuStop>
      <Chat:FriEnabled xsi:type="xsd:boolean">false</Chat:FriEnabled>
      <Chat:FriStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:FriStart>
      <Chat:FriStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:FriStop>
      <Chat:SatEnabled xsi:type="xsd:boolean">false</Chat:SatEnabled>
      <Chat:SatStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:SatStart>
      <Chat:SatStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:SatStop>
      <Chat:SunEnabled xsi:type="xsd:boolean">false</Chat:SunEnabled>
      <Chat:SunStart xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:SunStart>
      <Chat:SunStop xsi:type="xsd:dateTime">2021-03-25T21:36:52Z</Chat:SunStop>
     </Chat:OpeningHours>
     <Chat:Widget xsi:type="Chat:ChatWidgetSettings">
      <Chat:AutoFaqEnabled xsi:type="xsd:boolean">false</Chat:AutoFaqEnabled>
      <Chat:AutoFaqCategory xsi:type="Chat:KbCategory">
       <Chat:KbCategoryId xsi:type="xsd:int">0</Chat:KbCategoryId>
       <Chat:Name xsi:type="xsd:string"></Chat:Name>
       <Chat:Description xsi:type="xsd:string"></Chat:Description>
       <Chat:Fullname xsi:type="xsd:string"></Chat:Fullname>
       <Chat:ParentId xsi:type="xsd:int">0</Chat:ParentId>
       <Chat:SortOrder xsi:type="xsd:int">0</Chat:SortOrder>
      </Chat:AutoFaqCategory>
      <Chat:PreFormEnabled xsi:type="xsd:boolean">false</Chat:PreFormEnabled>
      <Chat:PreFormMessage xsi:type="xsd:string"></Chat:PreFormMessage>
      <Chat:RequiredFields xsi:type="Chat:WidgetRequiredFields">Name</Chat:RequiredFields>
      <Chat:PostFormEnabled xsi:type="xsd:boolean">false</Chat:PostFormEnabled>
      <Chat:PostFormHeader xsi:type="xsd:string"></Chat:PostFormHeader>
      <Chat:PostFormMessage xsi:type="xsd:string"></Chat:PostFormMessage>
      <Chat:PostTranscriptEnabled xsi:type="xsd:boolean">false</Chat:PostTranscriptEnabled>
      <Chat:LanguageIsoCode xsi:type="xsd:string"></Chat:LanguageIsoCode>
      <Chat:Theme xsi:type="Chat:WidgetTheme">Classic</Chat:Theme>
      <Chat:Color xsi:type="xsd:string"></Chat:Color>
      <Chat:Font xsi:type="xsd:string"></Chat:Font>
      <Chat:ShowLogo xsi:type="xsd:boolean">false</Chat:ShowLogo>
      <Chat:ShowAgentPhoto xsi:type="xsd:boolean">false</Chat:ShowAgentPhoto>
      <Chat:WelcomeTitle xsi:type="xsd:string"></Chat:WelcomeTitle>
      <Chat:WelcomeMessage xsi:type="xsd:string"></Chat:WelcomeMessage>
      <Chat:OfflineHeader xsi:type="xsd:string"></Chat:OfflineHeader>
      <Chat:OfflineMessage xsi:type="xsd:string"></Chat:OfflineMessage>
      <Chat:OfflineFields xsi:type="Chat:WidgetRequiredFields">Name</Chat:OfflineFields>
     </Chat:Widget>
    </Chat:ChatTopicEntity>
   </Chat:Response>
  </Chat:ChatTopicsForUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

