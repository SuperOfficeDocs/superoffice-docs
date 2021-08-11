---
uid: crmscript_ref_NSQuoteLine_SetQuantityUnit
title: SetQuantityUnit(String quantityUnit)
intellisense: NSQuoteLine.SetQuantityUnit
keywords: NSQuoteLine, GetQuantityUnit
so.topic: reference
---

# SetQuantityUnit(String quantityUnit)

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); Connector handles conversion relative to PriceUnit if they are different.

**Parameter:** 
 - **quantityUnit** String

```crmscript
NSQuoteLine thing;
String quantityUnit;
thing.SetQuantityUnit(quantityUnit);
```

