---
uid: crmscript_ref_NSQuoteLine_GetSupplier
title: String GetSupplier()
intellisense: NSQuoteLine.GetSupplier
keywords: NSQuoteLine, GetSupplier
so.topic: reference
---

# String GetSupplier()

The name of the supplier. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String supplier  = thing.GetSupplier();
```

