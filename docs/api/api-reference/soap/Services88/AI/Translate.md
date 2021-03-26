---
uid: services88-ai-translate
title: Services88.AIAgent.Translate SOAP
Generated: true
---

# Services88 AI Translate SOAP

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.Translate">SuperOffice.Services88.IAIAgent.Translate</see> method.

## Translate

Translate a text from one language to another. Language of the text is automatically detected.

* **text:** Text to be translated. Language of the text is automatically detected.
* **targetLanguage:** ISO Language code (such as FR) to translate the text into.

**Returns:** Translated text


[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Translate Request

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
   <AI:Translate>
    <AI:Text xsi:type="xsd:string"></AI:Text>
    <AI:TargetLanguage xsi:type="xsd:string"></AI:TargetLanguage>
   </AI:Translate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Translate Response

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
  <AI:TranslateResponse>
   <AI:Response xsi:type="xsd:string"></AI:Response>
  </AI:TranslateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

