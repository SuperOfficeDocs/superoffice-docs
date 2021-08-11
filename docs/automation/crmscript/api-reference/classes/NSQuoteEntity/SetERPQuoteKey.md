---
uid: crmscript_ref_NSQuoteEntity_SetERPQuoteKey
title: SetERPQuoteKey(String eRPQuoteKey)
intellisense: NSQuoteEntity.SetERPQuoteKey
keywords: NSQuoteEntity, GetERPQuoteKey
so.topic: reference
---

# SetERPQuoteKey(String eRPQuoteKey)

Foreign key of quote (if available). The key in the ERP system that identifies this sale's Quote (as opposed to the later Order information)

**Parameter:** 
 - **eRPQuoteKey** String

```crmscript
NSQuoteEntity thing;
String eRPQuoteKey;
thing.SetERPQuoteKey(eRPQuoteKey);
```

