---
uid: crmscript_ref_NSQuoteLine_SetERPProductKey
title: SetERPProductKey(String eRPProductKey)
intellisense: NSQuoteLine.SetERPProductKey
keywords: NSQuoteLine, GetERPProductKey
so.topic: reference
---

# SetERPProductKey(String eRPProductKey)

Foreign key of product+pricelist this line is based on. Can be blank since the QuoteLine doesn’t have to be connected to a product.

**Parameter:** 
 - **eRPProductKey** String

```crmscript
NSQuoteLine thing;
String eRPProductKey;
thing.SetERPProductKey(eRPProductKey);
```

