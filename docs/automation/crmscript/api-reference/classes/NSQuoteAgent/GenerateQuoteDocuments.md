---
uid: crmscript_ref_NSQuoteAgent_GenerateQuoteDocuments
title: NSQuotePublishDocuments GenerateQuoteDocuments(Integer quoteVersionId, Integer emailBodyTemplateId, Bool attachMainDocument, Integer quotedProductsTemplateId, Bool includeAttachments, String rawMailSubject)
intellisense: NSQuoteAgent.GenerateQuoteDocuments
keywords: NSQuoteAgent, GenerateQuoteDocuments
so.topic: reference
---

# NSQuotePublishDocuments GenerateQuoteDocuments(Integer quoteVersionId, Integer emailBodyTemplateId, Bool attachMainDocument, Integer quotedProductsTemplateId, Bool includeAttachments, String rawMailSubject)

Generate all the documents required to send the Quote as an email to the prospect - or an Order Confirmation; it just depends on the template id's for the lines doc and mail body. Quote version status is not changed by this method.

**Parameters:**
 - **quoteVersionId** VersionId of the quote to be sent; the status of the version will not be changed by calling this method
 - **emailBodyTemplateId** Id of the template for the email body, must be nonzero and refer to either a Quote mail body or Order Confirmation mail body, with html content
 - **attachMainDocument** Should the main quote document be attached to the email; generally false for Order Confirmations
 - **quotedProductsTemplateId** Id of the template for the quote- or order confirmation-lines; zero if no document should be produced
 - **includeAttachments** If true, then the currently specified (in the database) attachments will be included
 - **rawMailSubject** Subject line for email, in the correct language, sent in here to have any template variables substituted

**Returns:** NSQuotePublishDocuments

```crmscript
NSQuoteAgent agent;
Integer quoteVersionId;
Integer emailBodyTemplateId;
Bool attachMainDocument;
Integer quotedProductsTemplateId;
Bool includeAttachments;
String rawMailSubject;
NSQuotePublishDocuments res = agent.GenerateQuoteDocuments(quoteVersionId, emailBodyTemplateId, attachMainDocument, quotedProductsTemplateId, includeAttachments, rawMailSubject);
```

