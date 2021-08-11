---
uid: crmscript_ref_NSAmountClassEntity_SetCurrencyId
title: SetCurrencyId(Integer currencyId)
intellisense: NSAmountClassEntity.SetCurrencyId
keywords: NSAmountClassEntity, GetCurrencyId
so.topic: reference
---

# SetCurrencyId(Integer currencyId)

Currency the limits in this amount class refer to. Mixing currencies between classes can give rise to overlapping intervals and thus unpredictable classifications.

**Parameter:** 
 - **currencyId** Integer

```crmscript
NSAmountClassEntity thing;
Integer currencyId;
thing.SetCurrencyId(currencyId);
```

