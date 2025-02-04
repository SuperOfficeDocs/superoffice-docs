---
title: Services88.AIAgent.GetChatbotTurns SOAP
generated: true
uid: Services88-AI-GetChatbotTurns
---

# Services88 AI GetChatbotTurns

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetChatbotTurns">SuperOffice.Services88.IAIAgent.GetChatbotTurns</see> method.

## GetChatbotTurns





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetChatbotTurns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:GetChatbotTurns>
    <AI:ChatId xsi:type="xsd:string"></AI:ChatId>
   </AI:GetChatbotTurns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetChatbotTurns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:GetChatbotTurnsResponse>
   <AI:Response xsi:type="AI:ArrayOfChatbotTurn">
    <AI:ChatbotTurn xsi:type="AI:ChatbotTurn">
     <AI:Timestamp xsi:type="xsd:dateTime">2025-01-29T12:10:29Z</AI:Timestamp>
     <AI:UserPrompt xsi:type="xsd:string"></AI:UserPrompt>
     <AI:UserDisplayText xsi:type="xsd:string"></AI:UserDisplayText>
     <AI:BotResponse xsi:type="xsd:string"></AI:BotResponse>
     <AI:BotActions xsi:type="AI:StringDictionary">
      <AI:StringKeyValuePair>
       <AI:Key xsi:type="xsd:string"></AI:Key>
       <AI:Value xsi:type="xsd:string"></AI:Value>
      </AI:StringKeyValuePair>
     </AI:BotActions>
     <AI:Attachments xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </AI:Attachments>
    </AI:ChatbotTurn>
   </AI:Response>
  </AI:GetChatbotTurnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

