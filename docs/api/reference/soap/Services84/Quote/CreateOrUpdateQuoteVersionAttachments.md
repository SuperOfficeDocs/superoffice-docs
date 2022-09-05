---
title: Services84.QuoteAgent.CreateOrUpdateQuoteVersionAttachments SOAP
generated: 1
uid: Services84-Quote-CreateOrUpdateQuoteVersionAttachments
---

# Services84 Quote CreateOrUpdateQuoteVersionAttachments

SOAP request and response examples **Remote/Services84/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IQuoteAgent.CreateOrUpdateQuoteVersionAttachments">SuperOffice.Services84.IQuoteAgent.CreateOrUpdateQuoteVersionAttachments</see> method.

## CreateOrUpdateQuoteVersionAttachments

Look at the Quote version, related sale and sale type, and ensure that the correct QuoteVersionAttachment records exist. This method may create or delete records

* **quoteVersionId:** The ID of the quote version

**Returns:** The current attachments for the given Quote version, after all updates have been completed


[WSDL file for Services84/Quote](../Services84-Quote.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateOrUpdateQuoteVersionAttachments Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:CreateOrUpdateQuoteVersionAttachments>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
   </Quote:CreateOrUpdateQuoteVersionAttachments>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateOrUpdateQuoteVersionAttachments Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Quote:CreateOrUpdateQuoteVersionAttachmentsResponse>
   <Quote:Response xsi:type="Quote:ArrayOfQuoteVersionAttachment">
    <Quote:QuoteVersionAttachment xsi:type="Quote:QuoteVersionAttachment">
     <Quote:DocumentId xsi:type="xsd:int">0</Quote:DocumentId>
     <Quote:Included xsi:type="xsd:boolean">false</Quote:Included>
    </Quote:QuoteVersionAttachment>
   </Quote:Response>
  </Quote:CreateOrUpdateQuoteVersionAttachmentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

