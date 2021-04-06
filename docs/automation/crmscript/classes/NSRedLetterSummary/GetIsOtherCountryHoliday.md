---
uid: crmscript_ref_NSRedLetterSummary_GetIsOtherCountryHoliday
title: Bool GetIsOtherCountryHoliday()
intellisense: NSRedLetterSummary.GetIsOtherCountryHoliday
keywords: NSRedLetterSummary, GetIsOtherCountryHoliday
so.topic: reference
---

If true, this day is a holiday in at least one of the countries that has defined associates in the system, but not in the country of the associate whose diary is being scanned.

**Returns:** Bool


```crmscript
NSRedLetterSummary thing;
Bool isOtherCountryHoliday  = thing.GetIsOtherCountryHoliday();
```


