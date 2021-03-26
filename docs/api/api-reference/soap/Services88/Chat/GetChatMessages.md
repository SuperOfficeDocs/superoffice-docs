---
uid: services88-chat-getchatmessages
title: Services88.ChatAgent.GetChatMessages SOAP
Generated: true
---

# Services88 Chat GetChatMessages SOAP

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.GetChatMessages">SuperOffice.Services88.IChatAgent.GetChatMessages</see> method.

## GetChatMessages

Get all or some of the messages in a chat session

* **chatSessionId:** id of the chat session to reset
* **after:** Return messages after this message id

**Returns:** Array of chat messages in the session


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetChatMessages Request

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
   <Chat:GetChatMessages>
    <Chat:ChatSessionId xsi:type="xsd:int">0</Chat:ChatSessionId>
    <Chat:After xsi:type="xsd:int">0</Chat:After>
   </Chat:GetChatMessages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetChatMessages Response

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
  <Chat:GetChatMessagesResponse>
   <Chat:Response xsi:type="Chat:ArrayOfChatMessage">
    <Chat:ChatMessage xsi:type="Chat:ChatMessage">
     <Chat:ChatMessageId xsi:type="xsd:int">0</Chat:ChatMessageId>
     <Chat:ChatSessionId xsi:type="xsd:int">0</Chat:ChatSessionId>
     <Chat:Type xsi:type="Chat:ChatMessageType">Invalid</Chat:Type>
     <Chat:Message xsi:type="xsd:string"></Chat:Message>
     <Chat:Author xsi:type="xsd:string"></Chat:Author>
     <Chat:ReadByCustomer xsi:type="xsd:short">0</Chat:ReadByCustomer>
     <Chat:SpecialType xsi:type="Chat:ChatMessageSpecialType">None</Chat:SpecialType>
     <Chat:SpecialParam xsi:type="xsd:string"></Chat:SpecialParam>
     <Chat:WhenPosted xsi:type="xsd:dateTime">2021-03-25T21:36:53Z</Chat:WhenPosted>
    </Chat:ChatMessage>
   </Chat:Response>
  </Chat:GetChatMessagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

