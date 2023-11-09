---
title: Services88.AIAgent.GetSummarizeContactPrompt SOAP
generated: true
uid: Services88-AI-GetSummarizeContactPrompt
---

# Services88 AI GetSummarizeContactPrompt

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.GetSummarizeContactPrompt">SuperOffice.Services88.IAIAgent.GetSummarizeContactPrompt</see> method.

## GetSummarizeContactPrompt





[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSummarizeContactPrompt Request

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
   <AI:GetSummarizeContactPrompt>
    <AI:ContactId xsi:type="xsd:int">0</AI:ContactId>
    <AI:NumSentences xsi:type="xsd:int">0</AI:NumSentences>
    <AI:Summary xsi:type="xsd:string"></AI:Summary>
    <AI:IsoLangCode xsi:type="xsd:string"></AI:IsoLangCode>
   </AI:GetSummarizeContactPrompt>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSummarizeContactPrompt Response

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
  <AI:GetSummarizeContactPromptResponse>
   <AI:Response xsi:type="AI:ChatbotTurn">
    <AI:Timestamp xsi:type="xsd:dateTime">2023-10-31T10:03:38Z</AI:Timestamp>
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
   </AI:Response>
  </AI:GetSummarizeContactPromptResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

