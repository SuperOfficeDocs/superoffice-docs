---
uid: crmscript_ref_NSAmountClassEntity_GetCurrencyId
title: Integer GetCurrencyId()
intellisense: NSAmountClassEntity.GetCurrencyId
keywords: NSAmountClassEntity, GetCurrencyId
so.topic: reference
---

Currency the limits in this amount class refer to. Mixing currencies between classes can give rise to overlapping intervals and thus unpredictable classifications.

**Returns:** Integer


```crmscript
NSAmountClassEntity thing;
Integer currencyId  = thing.GetCurrencyId();
```


