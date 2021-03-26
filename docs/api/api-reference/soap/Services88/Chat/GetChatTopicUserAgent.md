---
uid: services88-chat-getchattopicuseragent
title: Services88.ChatAgent.GetChatTopicUserAgent SOAP
Generated: true
---

# Services88 Chat GetChatTopicUserAgent SOAP

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.GetChatTopicUserAgent">SuperOffice.Services88.IChatAgent.GetChatTopicUserAgent</see> method.

## GetChatTopicUserAgent

Get a user assigned to a topic

* **chatTopicId:** Id of the chat topic
* **username:** Associate username or associate id to get.

**Returns:** The user's role within the chat topic.


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetChatTopicUserAgent Request

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
   <Chat:GetChatTopicUserAgent>
    <Chat:ChatTopicId xsi:type="xsd:int">0</Chat:ChatTopicId>
    <Chat:Username xsi:type="xsd:string"></Chat:Username>
   </Chat:GetChatTopicUserAgent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetChatTopicUserAgent Response

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
  <Chat:GetChatTopicUserAgentResponse>
   <Chat:Response xsi:type="Chat:ChatTopicAgent">
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
    <Chat:CanListen xsi:type="xsd:boolean">false</Chat:CanListen>
    <Chat:CanRespond xsi:type="xsd:boolean">false</Chat:CanRespond>
    <Chat:CanManage xsi:type="xsd:boolean">false</Chat:CanManage>
    <Chat:CanNotify xsi:type="xsd:boolean">false</Chat:CanNotify>
   </Chat:Response>
  </Chat:GetChatTopicUserAgentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

