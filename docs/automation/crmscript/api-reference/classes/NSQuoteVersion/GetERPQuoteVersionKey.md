---
uid: crmscript_ref_NSQuoteVersion_GetERPQuoteVersionKey
title: String GetERPQuoteVersionKey()
intellisense: NSQuoteVersion.GetERPQuoteVersionKey
keywords: NSQuoteVersion, GetERPQuoteVersionKey
so.topic: reference
---

# String GetERPQuoteVersionKey()

Key in the ERP system that uniquely identifies this Version within the ERP system (if available, the field may be empty).

**Returns:** String

```crmscript
NSQuoteVersion thing;
String eRPQuoteVersionKey  = thing.GetERPQuoteVersionKey();
```

