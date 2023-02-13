---
title: Services86.QuoteAgent.GenerateQuoteDocuments SOAP
generated: 1
uid: Services86-Quote-GenerateQuoteDocuments
---

# Services86 Quote GenerateQuoteDocuments

SOAP request and response examples **Remote/Services86/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IQuoteAgent.GenerateQuoteDocuments">SuperOffice.Services86.IQuoteAgent.GenerateQuoteDocuments</see> method.

## GenerateQuoteDocuments





[WSDL file for Services86/Quote](../Services86-Quote.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateQuoteDocuments Request

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
   <Quote:GenerateQuoteDocuments>
    <Quote:QuoteVersionId xsi:type="xsd:int">0</Quote:QuoteVersionId>
    <Quote:EmailBodyTemplateId xsi:type="xsd:int">0</Quote:EmailBodyTemplateId>
    <Quote:AttachMainDocument xsi:type="xsd:boolean">false</Quote:AttachMainDocument>
    <Quote:QuotedProductsTemplateId xsi:type="xsd:int">0</Quote:QuotedProductsTemplateId>
    <Quote:IncludeAttachments xsi:type="xsd:boolean">false</Quote:IncludeAttachments>
    <Quote:RawMailSubject xsi:type="xsd:string"></Quote:RawMailSubject>
   </Quote:GenerateQuoteDocuments>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateQuoteDocuments Response

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
  <Quote:GenerateQuoteDocumentsResponse>
   <Quote:Response xsi:type="Quote:QuotePublishDocuments">
    <Quote:QuoteDocumentId xsi:type="xsd:int">0</Quote:QuoteDocumentId>
    <Quote:QuotedProductsId xsi:type="xsd:int">0</Quote:QuotedProductsId>
    <Quote:QuoteAttachmentIds xsi:type="NetServerServices862:ArrayOfint">
     <NetServerServices862:int xsi:type="xsd:int">0</NetServerServices862:int>
    </Quote:QuoteAttachmentIds>
    <Quote:MailBody xsi:type="xsd:string"></Quote:MailBody>
    <Quote:MailSubject xsi:type="xsd:string"></Quote:MailSubject>
    <Quote:ToEmail xsi:type="xsd:string"></Quote:ToEmail>
    <Quote:ToFullName xsi:type="xsd:string"></Quote:ToFullName>
    <Quote:ErrorMessage xsi:type="xsd:string"></Quote:ErrorMessage>
   </Quote:Response>
  </Quote:GenerateQuoteDocumentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

