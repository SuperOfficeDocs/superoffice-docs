---
uid: crmscript_ref_NSQuoteEntity_GetERPQuoteKey
title: String GetERPQuoteKey()
intellisense: NSQuoteEntity.GetERPQuoteKey
keywords: NSQuoteEntity, GetERPQuoteKey
so.topic: reference
---

# String GetERPQuoteKey()

Foreign key of quote (if available). The key in the ERP system that identifies this sale's Quote (as opposed to the later Order information)

**Returns:** String

```crmscript
NSQuoteEntity thing;
String eRPQuoteKey  = thing.GetERPQuoteKey();
```

