---
uid: crmscript_ref_NSPriceList_GetValidFrom
title: DateTime GetValidFrom()
intellisense: NSPriceList.GetValidFrom
keywords: NSPriceList, GetValidFrom
so.topic: reference
---

# DateTime GetValidFrom()

The date (inclusive) the pricelist start to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date.

**Returns:** DateTime

```crmscript
NSPriceList thing;
DateTime validFrom  = thing.GetValidFrom();
```

