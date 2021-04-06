---
uid: crmscript_ref_NSPriceList_SetValidFrom
title: SetValidFrom(DateTime validFrom)
intellisense: NSPriceList.SetValidFrom
keywords: NSPriceList, GetValidFrom
so.topic: reference
---

The date (inclusive) the pricelist start to be valid. This can be DateTime.MinValue to signal that it doesn't have a specific start date.

**Parameter:** 
 - **validFrom** DateTime

```crmscript
NSPriceList thing;
DateTime validFrom;
thing.SetValidFrom(validFrom);
```

