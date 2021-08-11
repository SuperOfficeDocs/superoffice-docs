---
uid: crmscript_ref_NSQuoteVersion_SetQuoteId
title: SetQuoteId(Integer quoteId)
intellisense: NSQuoteVersion.SetQuoteId
keywords: NSQuoteVersion, GetQuoteId
so.topic: reference
---

# SetQuoteId(Integer quoteId)

Foreign key to CRM quote (the conceptual parent). Owning Quote of this Quote Version.

**Parameter:** 
 - **quoteId** Integer

```crmscript
NSQuoteVersion thing;
Integer quoteId;
thing.SetQuoteId(quoteId);
```

