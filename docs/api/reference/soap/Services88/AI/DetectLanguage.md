---
title: Services88.AIAgent.DetectLanguage SOAP
generated: 1
uid: Services88-AI-DetectLanguage
---

# Services88 AI DetectLanguage

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.DetectLanguage">SuperOffice.Services88.IAIAgent.DetectLanguage</see> method.

## DetectLanguage

Given a (reasonably short) text, detect the language it is written in

* **text:** Text to be analyzed; there may be a cost-per-character so do not send a book here

**Returns:** ISO Language code, such as NO, US, ES, FR


[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DetectLanguage Request

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
   <AI:DetectLanguage>
    <AI:Text xsi:type="xsd:string"></AI:Text>
   </AI:DetectLanguage>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DetectLanguage Response

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
  <AI:DetectLanguageResponse>
   <AI:Response xsi:type="xsd:string"></AI:Response>
  </AI:DetectLanguageResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

