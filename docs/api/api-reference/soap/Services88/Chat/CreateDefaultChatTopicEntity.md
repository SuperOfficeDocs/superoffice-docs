---
title: Services88.ChatAgent.CreateDefaultChatTopicEntity SOAP
generated: 1
uid: Services88-Chat-CreateDefaultChatTopicEntity
---

# Services88 Chat CreateDefaultChatTopicEntity

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.CreateDefaultChatTopicEntity">SuperOffice.Services88.IChatAgent.CreateDefaultChatTopicEntity</see> method.

## CreateDefaultChatTopicEntity

Loading default values into a new ChatTopicEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New ChatTopicEntity with default values


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultChatTopicEntity Request

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
   <Chat:CreateDefaultChatTopicEntity>
   </Chat:CreateDefaultChatTopicEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultChatTopicEntity Response

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
  <Chat:CreateDefaultChatTopicEntityResponse>
   <Chat:Response xsi:type="Chat:ChatTopicEntity">
    <Chat:ChatTopicId xsi:type="xsd:int">0</Chat:ChatTopicId>
    <Chat:Name xsi:type="xsd:string"></Chat:Name>
    <Chat:Description xsi:type="xsd:string"></Chat:Description>
    <Chat:WelcomeMessage xsi:type="xsd:string"></Chat:WelcomeMessage>
    <Chat:Language xsi:type="Chat:CustomerLanguage">
     <Chat:Id xsi:type="xsd:int">0</Chat:Id>
     <Chat:Value xsi:type="xsd:string"></Chat:Value>
     <Chat:Tooltip xsi:type="xsd:string"></Chat:Tooltip>
    </Chat:Language>
    <Chat:LastAccept xsi:type="xsd:dateTime">2021-11-30T13:23:34Z</Chat:LastAccept>
    <Chat:SecondsPrAccept xsi:type="xsd:int">0</Chat:SecondsPrAccept>
    <Chat:AlertRecipient xsi:type="xsd:string"></Chat:AlertRecipient>
    <Chat:AlertTemplate xsi:type="Chat:ReplyTemplate">
     <Chat:ReplyTemplateId xsi:type="xsd:int">0</Chat:ReplyTemplateId>
     <Chat:Name xsi:type="xsd:string"></Chat:Name>
     <Chat:Description xsi:type="xsd:string"></Chat:Description>
     <Chat:FolderId xsi:type="xsd:int">0</Chat:FolderId>
    </Chat:AlertTemplate>
    <Chat:CollectConsent xsi:type="xsd:boolean">false</Chat:CollectConsent>
    <Chat:BadgeHeader xsi:type="xsd:string"></Chat:BadgeHeader>
    <Chat:CustomQueueTextEnabled xsi:type="xsd:boolean">false</Chat:CustomQueueTextEnabled>
    <Chat:CustomQueueText xsi:type="xsd:string"></Chat:CustomQueueText>
    <Chat:WarnNewChatMinutes xsi:type="xsd:int">0</Chat:WarnNewChatMinutes>
    <Chat:WarnManagerNewChatMinutes xsi:type="xsd:int">0</Chat:WarnManagerNewChatMinutes>
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
         <Chat:TZOffset xsi:type="xsd:int">0</Chat:TZOffset>
         <Chat:StartRulePattern xsi:type="xsd:string"></Chat:StartRulePattern>
         <Chat:EndRulePattern xsi:type="xsd:string"></Chat:EndRulePattern>
         <Chat:StartDay xsi:type="xsd:int">0</Chat:StartDay>
         <Chat:StartMonth xsi:type="xsd:int">0</Chat:StartMonth>
         <Chat:EndDay xsi:type="xsd:int">0</Chat:EndDay>
         <Chat:EndMonth xsi:type="xsd:int">0</Chat:EndMonth>
        </Chat:Value>
       </Chat:TimeZoneRuleKeyValuePair>
      </Chat:TimeZoneSTDRules>
      <Chat:TimeZoneDSTRules xsi:type="Chat:TimeZoneRuleDictionary">
       <Chat:TimeZoneRuleKeyValuePair>
        <Chat:Key xsi:type="xsd:dateTime"></Chat:Key>
        <Chat:Value xsi:type="Chat:TimeZoneRule">
         <Chat:TZOffset xsi:type="xsd:int">0</Chat:TZOffset>
         <Chat:StartRulePattern xsi:type="xsd:string"></Chat:StartRulePattern>
         <Chat:EndRulePattern xsi:type="xsd:string"></Chat:EndRulePattern>
         <Chat:StartDay xsi:type="xsd:int">0</Chat:StartDay>
         <Chat:StartMonth xsi:type="xsd:int">0</Chat:StartMonth>
         <Chat:EndDay xsi:type="xsd:int">0</Chat:EndDay>
         <Chat:EndMonth xsi:type="xsd:int">0</Chat:EndMonth>
        </Chat:Value>
       </Chat:TimeZoneRuleKeyValuePair>
      </Chat:TimeZoneDSTRules>
     </Chat:TzLocation>
     <Chat:MonEnabled xsi:type="xsd:boolean">false</Chat:MonEnabled>
     <Chat:MonStart xsi:type="NetServerServices881:duration"></Chat:MonStart>
     <Chat:MonStop xsi:type="NetServerServices881:duration"></Chat:MonStop>
     <Chat:TueEnabled xsi:type="xsd:boolean">false</Chat:TueEnabled>
     <Chat:TueStart xsi:type="NetServerServices881:duration"></Chat:TueStart>
     <Chat:TueStop xsi:type="NetServerServices881:duration"></Chat:TueStop>
     <Chat:WedEnabled xsi:type="xsd:boolean">false</Chat:WedEnabled>
     <Chat:WedStart xsi:type="NetServerServices881:duration"></Chat:WedStart>
     <Chat:WedStop xsi:type="NetServerServices881:duration"></Chat:WedStop>
     <Chat:ThuEnabled xsi:type="xsd:boolean">false</Chat:ThuEnabled>
     <Chat:ThuStart xsi:type="NetServerServices881:duration"></Chat:ThuStart>
     <Chat:ThuStop xsi:type="NetServerServices881:duration"></Chat:ThuStop>
     <Chat:FriEnabled xsi:type="xsd:boolean">false</Chat:FriEnabled>
     <Chat:FriStart xsi:type="NetServerServices881:duration"></Chat:FriStart>
     <Chat:FriStop xsi:type="NetServerServices881:duration"></Chat:FriStop>
     <Chat:SatEnabled xsi:type="xsd:boolean">false</Chat:SatEnabled>
     <Chat:SatStart xsi:type="NetServerServices881:duration"></Chat:SatStart>
     <Chat:SatStop xsi:type="NetServerServices881:duration"></Chat:SatStop>
     <Chat:SunEnabled xsi:type="xsd:boolean">false</Chat:SunEnabled>
     <Chat:SunStart xsi:type="NetServerServices881:duration"></Chat:SunStart>
     <Chat:SunStop xsi:type="NetServerServices881:duration"></Chat:SunStop>
     <Chat:UseLunchHours xsi:type="xsd:boolean">false</Chat:UseLunchHours>
     <Chat:LunchStart xsi:type="NetServerServices881:duration"></Chat:LunchStart>
     <Chat:LunchStop xsi:type="NetServerServices881:duration"></Chat:LunchStop>
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
     <Chat:RequiredFields xsi:type="Chat:WidgetRequiredFields">Email</Chat:RequiredFields>
     <Chat:PostFormEnabled xsi:type="xsd:boolean">false</Chat:PostFormEnabled>
     <Chat:PostFormHeader xsi:type="xsd:string"></Chat:PostFormHeader>
     <Chat:PostFormMessage xsi:type="xsd:string"></Chat:PostFormMessage>
     <Chat:PostTranscriptEnabled xsi:type="xsd:boolean">false</Chat:PostTranscriptEnabled>
     <Chat:LanguageIsoCode xsi:type="xsd:string"></Chat:LanguageIsoCode>
     <Chat:Size xsi:type="Chat:ChatWidgetSize">Normal</Chat:Size>
     <Chat:Theme xsi:type="Chat:WidgetTheme">Classic</Chat:Theme>
     <Chat:Color xsi:type="xsd:string"></Chat:Color>
     <Chat:Font xsi:type="xsd:string"></Chat:Font>
     <Chat:LogoEnabled xsi:type="xsd:boolean">false</Chat:LogoEnabled>
     <Chat:LogoBlobId xsi:type="xsd:int">0</Chat:LogoBlobId>
     <Chat:LogoName xsi:type="xsd:string"></Chat:LogoName>
     <Chat:ShowAgentPhoto xsi:type="xsd:boolean">false</Chat:ShowAgentPhoto>
     <Chat:WelcomeTitle xsi:type="xsd:string"></Chat:WelcomeTitle>
     <Chat:WelcomeMessage xsi:type="xsd:string"></Chat:WelcomeMessage>
     <Chat:OfflineHeader xsi:type="xsd:string"></Chat:OfflineHeader>
     <Chat:OfflineMessage xsi:type="xsd:string"></Chat:OfflineMessage>
     <Chat:OfflineFields xsi:type="Chat:WidgetRequiredFields">Email</Chat:OfflineFields>
     <Chat:UseAgentFirstname xsi:type="xsd:boolean">false</Chat:UseAgentFirstname>
    </Chat:Widget>
    <Chat:BotEnabled xsi:type="xsd:boolean">false</Chat:BotEnabled>
    <Chat:BotSettings xsi:type="Chat:ChatBotSettings">
     <Chat:BotName xsi:type="xsd:string"></Chat:BotName>
     <Chat:BotRegisterScriptId xsi:type="xsd:int">0</Chat:BotRegisterScriptId>
     <Chat:BotSessionCreatedScriptId xsi:type="xsd:int">0</Chat:BotSessionCreatedScriptId>
     <Chat:BotSessionChangedScriptId xsi:type="xsd:int">0</Chat:BotSessionChangedScriptId>
     <Chat:BotMessageReceivedScriptId xsi:type="xsd:int">0</Chat:BotMessageReceivedScriptId>
    </Chat:BotSettings>
    <Chat:OfflineCollectConsent xsi:type="xsd:boolean">false</Chat:OfflineCollectConsent>
    <Chat:WarnChatMessageMinutes xsi:type="xsd:int">0</Chat:WarnChatMessageMinutes>
    <Chat:WarnManagerChatMessageMinutes xsi:type="xsd:int">0</Chat:WarnManagerChatMessageMinutes>
    <Chat:UseQueueOfflineForm xsi:type="xsd:boolean">false</Chat:UseQueueOfflineForm>
    <Chat:OfflineFormTimeLimit xsi:type="xsd:int">0</Chat:OfflineFormTimeLimit>
    <Chat:OfflineFormQueueLength xsi:type="xsd:int">0</Chat:OfflineFormQueueLength>
   </Chat:Response>
  </Chat:CreateDefaultChatTopicEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

