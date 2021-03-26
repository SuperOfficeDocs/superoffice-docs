---
uid: services88-chat-deletechatsessionentity
title: Services88.ChatAgent.DeleteChatSessionEntity SOAP
Generated: true
---

# Services88 Chat DeleteChatSessionEntity SOAP

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.DeleteChatSessionEntity">SuperOffice.Services88.IChatAgent.DeleteChatSessionEntity</see> method.

## DeleteChatSessionEntity

Deletes the ChatSessionEntity

* **chatSessionEntityId:** The identity of the ChatSessionEntity



[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteChatSessionEntity Request

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
   <Chat:DeleteChatSessionEntity>
    <Chat:ChatSessionEntityId xsi:type="xsd:int">0</Chat:ChatSessionEntityId>
   </Chat:DeleteChatSessionEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteChatSessionEntity Response

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
  <Chat:DeleteChatSessionEntityResponse>
  </Chat:DeleteChatSessionEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

