---
uid: services88-ai-detectsentiment
title: Services88.AIAgent.DetectSentiment SOAP
Generated: true
---

# Services88 AI DetectSentiment SOAP

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.DetectSentiment">SuperOffice.Services88.IAIAgent.DetectSentiment</see> method.

## DetectSentiment

Detect the sentiment of a (reasonably short) text. Sentiment analysis may cause a translation to be made, since sentiment analysis only supports a limited set of languages

* **text:** Text to be analyzed

**Returns:** The sentiment information: score (-100 to +100) and confidence


[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DetectSentiment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <AI:ApplicationToken>1234567-1234-9876</AI:ApplicationToken>
  <AI:Credentials>
    <AI:Ticket>7T:1234abcxyzExample==</AI:Ticket>
  </AI:Credentials>
 <SOAP-ENV:Body>
   <AI:DetectSentiment>
    <AI:Text xsi:type="xsd:string"></AI:Text>
   </AI:DetectSentiment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DetectSentiment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:AI="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <AI:DetectSentimentResponse>
   <AI:Response xsi:type="AI:Sentiment">
    <AI:Score xsi:type="xsd:int">0</AI:Score>
    <AI:Confidence xsi:type="xsd:int">0</AI:Confidence>
   </AI:Response>
  </AI:DetectSentimentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

