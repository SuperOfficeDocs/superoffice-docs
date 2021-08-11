---
uid: crmscript_ref_NSQuoteLine_GetProductFamilyKey
title: String GetProductFamilyKey()
intellisense: NSQuoteLine.GetProductFamilyKey
keywords: NSQuoteLine, GetProductFamilyKey
so.topic: reference
---

# String GetProductFamilyKey()

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String productFamilyKey  = thing.GetProductFamilyKey();
```

