---
uid: crmscript_ref_NSDocumentTemplateEntity_SetQuoteDocType
title: SetQuoteDocType(DocTmplQuoteType quoteDocType)
intellisense: NSDocumentTemplateEntity.SetQuoteDocType
keywords: NSDocumentTemplateEntity, GetQuoteDocType
so.topic: reference
---

The role this document plays in the Quote system, if any

**Parameter:** 
 - **quoteDocType** DocTmplQuoteType
     - Enum: 0 = None 
     - Enum: 1 = MailBody 
     - Enum: 2 = MainDocument 
     - Enum: 3 = QuoteLines 
     - Enum: 4 = ConfirmationMailBody 
     - Enum: 5 = ConfirmationLines 

```crmscript
NSDocumentTemplateEntity thing;
DocTmplQuoteType quoteDocType;
thing.SetQuoteDocType(quoteDocType);
```

