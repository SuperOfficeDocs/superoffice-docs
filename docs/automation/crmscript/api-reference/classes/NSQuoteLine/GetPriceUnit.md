---
uid: crmscript_ref_NSQuoteLine_GetPriceUnit
title: String GetPriceUnit()
intellisense: NSQuoteLine.GetPriceUnit
keywords: NSQuoteLine, GetPriceUnit
so.topic: reference
---

# String GetPriceUnit()

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); read-only for lines that originate in defined products.

**Returns:** String

```crmscript
NSQuoteLine thing;
String priceUnit  = thing.GetPriceUnit();
```

