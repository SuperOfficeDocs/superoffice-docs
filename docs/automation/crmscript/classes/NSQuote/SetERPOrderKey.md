---
uid: crmscript_ref_NSQuote_SetERPOrderKey
title: SetERPOrderKey(String eRPOrderKey)
intellisense: NSQuote.SetERPOrderKey
keywords: NSQuote, GetERPOrderKey
so.topic: reference
---

The key in the ERP system that identifies this sale's Order, as transferred and possibly later edited in the ERP system.  Only filled out if there exists a corresponding order representation of the quote in the ERP system.

**Parameter:** 
 - **eRPOrderKey** String

```crmscript
NSQuote thing;
String eRPOrderKey;
thing.SetERPOrderKey(eRPOrderKey);
```

