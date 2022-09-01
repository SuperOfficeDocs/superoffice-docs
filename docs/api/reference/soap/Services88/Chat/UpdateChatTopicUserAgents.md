---
title: Services88.ChatAgent.UpdateChatTopicUserAgents SOAP
generated: 1
uid: Services88-Chat-UpdateChatTopicUserAgents
---

# Services88 Chat UpdateChatTopicUserAgents

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.UpdateChatTopicUserAgents">SuperOffice.Services88.IChatAgent.UpdateChatTopicUserAgents</see> method.

## UpdateChatTopicUserAgents

Update users roles in a chat topic

* **chatTopicId:** Id of the chat topic
* **useragents:** Users new/updated roles within the chat topic. Replaces existing roles

**Returns:** The updated agents within the chat topic.


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateChatTopicUserAgents Request

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
   <Chat:UpdateChatTopicUserAgents>
    <Chat:ChatTopicId xsi:type="xsd:int">0</Chat:ChatTopicId>
    <Chat:Useragents xsi:type="Chat:ArrayOfChatTopicAgent">
     <Chat:ChatTopicAgent xsi:type="Chat:ChatTopicAgent">
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
     </Chat:ChatTopicAgent>
    </Chat:Useragents>
   </Chat:UpdateChatTopicUserAgents>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateChatTopicUserAgents Response

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
  <Chat:UpdateChatTopicUserAgentsResponse>
   <Chat:Response xsi:type="Chat:ArrayOfChatTopicAgent">
    <Chat:ChatTopicAgent xsi:type="Chat:ChatTopicAgent">
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
    </Chat:ChatTopicAgent>
   </Chat:Response>
  </Chat:UpdateChatTopicUserAgentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

