---
uid: crmscript_ref_NSQuoteLine_GetSupplierCode
title: String GetSupplierCode()
intellisense: NSQuoteLine.GetSupplierCode
keywords: NSQuoteLine, GetSupplierCode
so.topic: reference
---

The suppliers' code or part number for this product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String


```crmscript
NSQuoteLine thing;
String supplierCode  = thing.GetSupplierCode();
```


