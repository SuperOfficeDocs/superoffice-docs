---
uid: crmscript-quote-document
title: Quote document
description: How to work with quote documents in CRMScript.
keywords: quote, sale, document
author: Bergfrid Dias
date: 06.12.2023
version: 10
topic: howto
---

# Quote document

## Locate quote document

```crmscript!
NSQuoteAgent qa;
NSQuoteEntity quote = qa.GetQuoteEntity(1);

Integer docId = quote.GetDocumentId();

printLine("The main document is " + docId.toString());
```

## Generate quote document

`GenerateQuoteDocuments()` will generate all the documents required to send the quote as an email to the prospect.

```crmscript!
NSQuoteAgent qa;
NSQuotePublishDocuments docs = qa.GenerateQuoteDocuments(2,1,true,0,false,"Super proposal");

Integer docId = docs.GetQuoteDocumentId();

NSDocumentAgent docAgent;
NSDocumentEntity doc = docAgent.GetDocumentEntity(docId);
printLine(doc.GetContact().GetName());
```

### Parameters

* ID of the version
* ID of the template for the email body
* should the main quote document be attached to the email? (bool)
* ID of the template for the quote lines (can be 0)
* Should the attachments specified (in the database) be included? (bool)
* Subject line for the email, in the correct language (can contain template variables)

## Check when a document was sent

```crmscript
NSQuoteAgent qa;
NSQuoteVersion version = qa.GetQuoteVersion(1);

Integer state = version.GetState();

if (state == 6 || state == 8 || state == 9) {
  printLine("Proposal was sent " + GetSentDate().toString());
}
```

## See also

* [Working with documents][1]
* [Template variables][2]

<!-- Referenced links -->
[1]: ../document/index.md
[2]: ../document/templates.md
