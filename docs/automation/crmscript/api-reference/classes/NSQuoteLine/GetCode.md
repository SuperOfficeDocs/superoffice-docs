---
uid: crmscript_ref_NSQuoteLine_GetCode
title: String GetCode()
intellisense: NSQuoteLine.GetCode
keywords: NSQuoteLine, GetCode
so.topic: reference
---

# String GetCode()

A value the salesmen use to quickly find the correct product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String code  = thing.GetCode();
```

