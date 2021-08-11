---
uid: crmscript_ref_NSQuote_SetERPQuoteKey
title: SetERPQuoteKey(String eRPQuoteKey)
intellisense: NSQuote.SetERPQuoteKey
keywords: NSQuote, GetERPQuoteKey
so.topic: reference
---

# SetERPQuoteKey(String eRPQuoteKey)

Foreign key of quote (if available). The key in the ERP system that identifies this sale's Quote (as opposed to the later Order information)

**Parameter:** 
 - **eRPQuoteKey** String

```crmscript
NSQuote thing;
String eRPQuoteKey;
thing.SetERPQuoteKey(eRPQuoteKey);
```

