---
uid: services80-quote-generatequotedocuments
title: Services80.QuoteAgent.GenerateQuoteDocuments SOAP
Generated: true
---

# Services80 Quote GenerateQuoteDocuments SOAP

SOAP request and response examples **Remote/Services80/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IQuoteAgent.GenerateQuoteDocuments">SuperOffice.Services80.IQuoteAgent.GenerateQuoteDocuments</see> method.

## GenerateQuoteDocuments

Generate all the documents required to send the Quote as an email to the prospect - or an Order Confirmation; it just depends on the template id's for the lines doc and mail body. Quote version status is not changed by this method.

* **quoteVersionId:** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
* **emailBodyTemplateId:** Id of the template for the email body, must be nonzero and refer to either a Quote mail body or Order Confirmation mail body, with html content
* **attachMainDocument:** Should the main quote document be attached to the email; generally false for Order Confirmations
* **quotedProductsTemplateId:** Id of the template for the quote- or order confirmation-lines; zero if no document should be produced
* **includeAttachments:** If true, then the currently specified (in the database) attachments will be included
* **rawMailSubject:** Subject line for email, in the correct language, sent in here to have any template variables substituted

**Returns:** Carrier specifying the document id's of all the documents, as well as other results


[WSDL file for Services80/Quote](../Services80-Quote.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateQuoteDocuments Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Quote:GenerateQuoteDocumentsResponse>
   <Quote:Response xsi:type="Quote:QuotePublishDocuments">
    <Quote:QuoteDocumentId xsi:type="xsd:int">0</Quote:QuoteDocumentId>
    <Quote:QuotedProductsId xsi:type="xsd:int">0</Quote:QuotedProductsId>
    <Quote:QuoteAttachmentIds xsi:type="NetServerServices802:ArrayOfint">
     <NetServerServices802:int xsi:type="xsd:int">0</NetServerServices802:int>
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

