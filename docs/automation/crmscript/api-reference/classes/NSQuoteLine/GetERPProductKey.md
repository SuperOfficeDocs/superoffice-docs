---
uid: crmscript_ref_NSQuoteLine_GetERPProductKey
title: String GetERPProductKey()
intellisense: NSQuoteLine.GetERPProductKey
keywords: NSQuoteLine, GetERPProductKey
so.topic: reference
---

# String GetERPProductKey()

Foreign key of product+pricelist this line is based on. Can be blank since the QuoteLine doesn’t have to be connected to a product.

**Returns:** String

```crmscript
NSQuoteLine thing;
String eRPProductKey  = thing.GetERPProductKey();
```

