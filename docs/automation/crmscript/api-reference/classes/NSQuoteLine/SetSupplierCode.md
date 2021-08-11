---
uid: crmscript_ref_NSQuoteLine_SetSupplierCode
title: SetSupplierCode(String supplierCode)
intellisense: NSQuoteLine.SetSupplierCode
keywords: NSQuoteLine, GetSupplierCode
so.topic: reference
---

# SetSupplierCode(String supplierCode)

The suppliers' code or part number for this product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Parameter:** 
 - **supplierCode** String

```crmscript
NSQuoteLine thing;
String supplierCode;
thing.SetSupplierCode(supplierCode);
```

