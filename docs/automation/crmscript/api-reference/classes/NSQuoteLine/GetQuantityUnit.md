---
uid: crmscript_ref_NSQuoteLine_GetQuantityUnit
title: String GetQuantityUnit()
intellisense: NSQuoteLine.GetQuantityUnit
keywords: NSQuoteLine, GetQuantityUnit
so.topic: reference
---

# String GetQuantityUnit()

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); Connector handles conversion relative to PriceUnit if they are different.

**Returns:** String

```crmscript
NSQuoteLine thing;
String quantityUnit  = thing.GetQuantityUnit();
```

