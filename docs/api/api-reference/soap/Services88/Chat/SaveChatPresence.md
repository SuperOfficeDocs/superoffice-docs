---
uid: services88-chat-savechatpresence
title: Services88.ChatAgent.SaveChatPresence SOAP
Generated: true
---

# Services88 Chat SaveChatPresence SOAP

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.SaveChatPresence">SuperOffice.Services88.IChatAgent.SaveChatPresence</see> method.

## SaveChatPresence

Save the chat presence for specified users

* **chatPresence:** An array with ChatPresence objects. Only the UserId and Present information is used while saving

**Returns:** void


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveChatPresence Request

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
   <Chat:SaveChatPresence>
    <Chat:ChatPresence xsi:type="Chat:ArrayOfChatPresence">
     <Chat:ChatPresence xsi:type="Chat:ChatPresence">
      <Chat:UserId xsi:type="xsd:int">0</Chat:UserId>
      <Chat:DisplayName xsi:type="xsd:string"></Chat:DisplayName>
      <Chat:OngoingChats xsi:type="xsd:int">0</Chat:OngoingChats>
      <Chat:Present xsi:type="xsd:boolean">false</Chat:Present>
      <Chat:ChatTopics xsi:type="NetServerServices882:ArrayOfint">
       <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
      </Chat:ChatTopics>
     </Chat:ChatPresence>
    </Chat:ChatPresence>
   </Chat:SaveChatPresence>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveChatPresence Response

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
  <Chat:SaveChatPresenceResponse>
  </Chat:SaveChatPresenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

