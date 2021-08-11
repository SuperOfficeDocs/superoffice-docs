---
uid: crmscript_ref_NSQuoteLine_GetProductTypeKey
title: String GetProductTypeKey()
intellisense: NSQuoteLine.GetProductTypeKey
keywords: NSQuoteLine, GetProductTypeKey
so.topic: reference
---

# String GetProductTypeKey()

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String productTypeKey  = thing.GetProductTypeKey();
```

