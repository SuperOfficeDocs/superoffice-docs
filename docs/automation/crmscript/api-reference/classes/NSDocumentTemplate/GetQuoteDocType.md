---
uid: crmscript_ref_NSDocumentTemplate_GetQuoteDocType
title: NSDocTmplQuoteType GetQuoteDocType()
intellisense: NSDocumentTemplate.GetQuoteDocType
keywords: NSDocumentTemplate, GetQuoteDocType
so.topic: reference
---

What type of quote document is this.

**Returns:** NSDocTmplQuoteType

     - Enum: 0 = None 
     - Enum: 1 = MailBody 
     - Enum: 2 = MainDocument 
     - Enum: 3 = QuoteLines 
     - Enum: 4 = ConfirmationMailBody 
     - Enum: 5 = ConfirmationLines 

```crmscript
NSDocumentTemplate thing;
NSDocTmplQuoteType quoteDocType  = thing.GetQuoteDocType();
```


