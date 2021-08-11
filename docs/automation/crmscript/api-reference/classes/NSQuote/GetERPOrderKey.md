---
uid: crmscript_ref_NSQuote_GetERPOrderKey
title: String GetERPOrderKey()
intellisense: NSQuote.GetERPOrderKey
keywords: NSQuote, GetERPOrderKey
so.topic: reference
---

# String GetERPOrderKey()

The key in the ERP system that identifies this sale's Order, as transferred and possibly later edited in the ERP system.  Only filled out if there exists a corresponding order representation of the quote in the ERP system.

**Returns:** String

```crmscript
NSQuote thing;
String eRPOrderKey  = thing.GetERPOrderKey();
```

