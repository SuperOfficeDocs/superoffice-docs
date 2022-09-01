---
title: Services88.ChatAgent.DeleteChatTopicUserAgent SOAP
generated: 1
uid: Services88-Chat-DeleteChatTopicUserAgent
---

# Services88 Chat DeleteChatTopicUserAgent

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.DeleteChatTopicUserAgent">SuperOffice.Services88.IChatAgent.DeleteChatTopicUserAgent</see> method.

## DeleteChatTopicUserAgent

Remove a user from a topic

* **chatTopicId:** Id of the chat topic
* **username:** Associate username or associate id to delete.

**Returns:** This method has no return value


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteChatTopicUserAgent Request

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
   <Chat:DeleteChatTopicUserAgent>
    <Chat:ChatTopicId xsi:type="xsd:int">0</Chat:ChatTopicId>
    <Chat:Username xsi:type="xsd:string"></Chat:Username>
   </Chat:DeleteChatTopicUserAgent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteChatTopicUserAgent Response

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
  <Chat:DeleteChatTopicUserAgentResponse>
  </Chat:DeleteChatTopicUserAgentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

