---
uid: crmscript_ref_NSQuoteLine_SetProductFamilyKey
title: SetProductFamilyKey(String productFamilyKey)
intellisense: NSQuoteLine.SetProductFamilyKey
keywords: NSQuoteLine, GetProductFamilyKey
so.topic: reference
---

# SetProductFamilyKey(String productFamilyKey)

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Parameter:** 
 - **productFamilyKey** String

```crmscript
NSQuoteLine thing;
String productFamilyKey;
thing.SetProductFamilyKey(productFamilyKey);
```

