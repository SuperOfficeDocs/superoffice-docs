---
title: Services88.ChatAgent.GetChatTranscript SOAP
generated: 1
uid: Services88-Chat-GetChatTranscript
---

# Services88 Chat GetChatTranscript

SOAP request and response examples **Remote/Services88/Chat.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IChatAgent.GetChatTranscript">SuperOffice.Services88.IChatAgent.GetChatTranscript</see> method.

## GetChatTranscript

Get the chat transcript, formatted as plain text or html

* **chatSessionId:** id of the chat session to get the transcript for
* **html:** Get transcript as HTML

**Returns:** The transcript in text or HTML


[WSDL file for Services88/Chat](../Services88-Chat.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetChatTranscript Request

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
   <Chat:GetChatTranscript>
    <Chat:ChatSessionId xsi:type="xsd:int">0</Chat:ChatSessionId>
    <Chat:Html xsi:type="xsd:boolean">false</Chat:Html>
   </Chat:GetChatTranscript>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetChatTranscript Response

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
  <Chat:GetChatTranscriptResponse>
   <Chat:Response xsi:type="xsd:string"></Chat:Response>
  </Chat:GetChatTranscriptResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

