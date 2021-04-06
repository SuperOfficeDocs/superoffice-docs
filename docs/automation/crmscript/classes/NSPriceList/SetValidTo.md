---
uid: crmscript_ref_NSPriceList_SetValidTo
title: SetValidTo(DateTime validTo)
intellisense: NSPriceList.SetValidTo
keywords: NSPriceList, GetValidTo
so.topic: reference
---

The date (inclusive) the pricelist ends to be valid. This can be DateTime.MaxValue to signal that it doesn't have a specific end date.

**Parameter:** 
 - **validTo** DateTime

```crmscript
NSPriceList thing;
DateTime validTo;
thing.SetValidTo(validTo);
```

