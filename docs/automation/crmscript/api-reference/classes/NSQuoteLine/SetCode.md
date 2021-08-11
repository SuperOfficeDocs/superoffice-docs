---
uid: crmscript_ref_NSQuoteLine_SetCode
title: SetCode(String code)
intellisense: NSQuoteLine.SetCode
keywords: NSQuoteLine, GetCode
so.topic: reference
---

# SetCode(String code)

A value the salesmen use to quickly find the correct product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Parameter:** 
 - **code** String

```crmscript
NSQuoteLine thing;
String code;
thing.SetCode(code);
```

