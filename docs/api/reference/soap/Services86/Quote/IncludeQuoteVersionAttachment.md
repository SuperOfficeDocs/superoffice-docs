---
title: Services86.QuoteAgent.IncludeQuoteVersionAttachment SOAP
generated: 1
uid: Services86-Quote-IncludeQuoteVersionAttachment
---

# Services86 Quote IncludeQuoteVersionAttachment

SOAP request and response examples **Remote/Services86/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IQuoteAgent.IncludeQuoteVersionAttachment">SuperOffice.Services86.IQuoteAgent.IncludeQuoteVersionAttachment</see> method.

## IncludeQuoteVersionAttachment

Toggle the 'included' state of a quote version attachment; will throw exceptions if called on locked versions

* **quoteVersionId:** The ID of the Quote version
* **documentId:** The ID of the document
* **include:** Desired state

**Returns:** The new state


[WSDL file for Services86/Quote](../Services86-Quote.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IncludeQuoteVersionAttachment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:IncludeQuoteVersionAttachment>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:DocumentId xsi:type="xsd:int">0</Quote:DocumentId>
    <Quote:Include xsi:type="xsd:boolean">false</Quote:Include>
   </Quote:IncludeQuoteVersionAttachment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## IncludeQuoteVersionAttachment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Quote:IncludeQuoteVersionAttachmentResponse>
   <Quote:Response xsi:type="xsd:boolean">false</Quote:Response>
  </Quote:IncludeQuoteVersionAttachmentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

