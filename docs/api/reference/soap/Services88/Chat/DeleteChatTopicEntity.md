---
title: Services88.ChatAgent.DeleteChatTopicEntity SOAP
generated: 1
uid: Services88-Chat-DeleteChatTopicEntity
---

# Services88 Chat DeleteChatTopicEntity

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.DeleteChatTopicEntity">SuperOffice.Services88.IChatAgent.DeleteChatTopicEntity</see> method.

## DeleteChatTopicEntity

Deletes the ChatTopicEntity

* **chatTopicEntityId:** The identity of the ChatTopicEntity



[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteChatTopicEntity Request

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
   <Chat:DeleteChatTopicEntity>
    <Chat:ChatTopicEntityId xsi:type="xsd:int">0</Chat:ChatTopicEntityId>
   </Chat:DeleteChatTopicEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteChatTopicEntity Response

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
  <Chat:DeleteChatTopicEntityResponse>
  </Chat:DeleteChatTopicEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

