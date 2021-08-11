---
uid: crmscript_ref_NSDocumentTemplate_SetQuoteDocType
title: SetQuoteDocType(NSDocTmplQuoteType quoteDocType)
intellisense: NSDocumentTemplate.SetQuoteDocType
keywords: NSDocumentTemplate, GetQuoteDocType
so.topic: reference
---

# SetQuoteDocType(NSDocTmplQuoteType quoteDocType)

What type of quote document is this.

**Parameter:** 
 - **quoteDocType** NSDocTmplQuoteType
     - Enum: 0 = None 
     - Enum: 1 = MailBody 
     - Enum: 2 = MainDocument 
     - Enum: 3 = QuoteLines 
     - Enum: 4 = ConfirmationMailBody 
     - Enum: 5 = ConfirmationLines 

```crmscript
NSDocumentTemplate thing;
NSDocTmplQuoteType quoteDocType;
thing.SetQuoteDocType(quoteDocType);
```

