---
uid: crmscript_ref_NSDocumentTemplateEntity_GetQuoteDocType
title: NSDocTmplQuoteType GetQuoteDocType()
intellisense: NSDocumentTemplateEntity.GetQuoteDocType
keywords: NSDocumentTemplateEntity, GetQuoteDocType
so.topic: reference
---

The role this document plays in the Quote system, if any

**Returns:** NSDocTmplQuoteType

     - Enum: 0 = None 
     - Enum: 1 = MailBody 
     - Enum: 2 = MainDocument 
     - Enum: 3 = QuoteLines 
     - Enum: 4 = ConfirmationMailBody 
     - Enum: 5 = ConfirmationLines 

```crmscript
NSDocumentTemplateEntity thing;
NSDocTmplQuoteType quoteDocType  = thing.GetQuoteDocType();
```


