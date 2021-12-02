---
title: Services88.AIAgent.TrainCategoryGuesser SOAP
generated: 1
uid: Services88-AI-TrainCategoryGuesser
---

# Services88 AI TrainCategoryGuesser

SOAP request and response examples **Remote/Services88/AI.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IAIAgent.TrainCategoryGuesser">SuperOffice.Services88.IAIAgent.TrainCategoryGuesser</see> method.

## TrainCategoryGuesser

The category guesser training API will be called with an array of CategorizationTrainingItem during the (background, Batch) execution of this call

* **selectionId:** Id of selection of tickets, to retrieve training data from
* **maxItems:** Maximum number of tickets to retrieve data from
* **maxTextLength:** Maximum length of PlainTextBody or any other large text, truncated to nearest word boundary

**Returns:** Placeholder for result...  should this be a BatchTaskId?  maybe not useful?


[WSDL file for Services88/AI](../Services88-AI.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TrainCategoryGuesser Request

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
   <AI:TrainCategoryGuesser>
    <AI:SelectionId xsi:type="xsd:int">0</AI:SelectionId>
    <AI:MaxItems xsi:type="xsd:int">0</AI:MaxItems>
    <AI:MaxTextLength xsi:type="xsd:int">0</AI:MaxTextLength>
   </AI:TrainCategoryGuesser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TrainCategoryGuesser Response

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
  <AI:TrainCategoryGuesserResponse>
   <AI:Response xsi:type="xsd:string"></AI:Response>
  </AI:TrainCategoryGuesserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

