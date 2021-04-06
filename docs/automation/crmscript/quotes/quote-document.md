---
uid: crmscript_quote_document
title: Quote document
author:
so.date:
keywords:
so.topic:
---

# Quote document

Quote documents will be saved as **activities on a sale**.
They're tied to a specific **quote version**.

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
* should the attachments specified (in the database) be included? (bool)
* subject line for the email, in the correct language (can contain template variables)

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

* [working with documents][1]
* [template variables][2]

<!-- Referenced links -->
[1]: ../documents/index.md
[2]: ../documents/doc-templates.md
