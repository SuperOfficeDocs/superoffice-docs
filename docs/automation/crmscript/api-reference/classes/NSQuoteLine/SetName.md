---
uid: crmscript_ref_NSQuoteLine_SetName
title: SetName(String name)
intellisense: NSQuoteLine.SetName
keywords: NSQuoteLine, GetName
so.topic: reference
---

# SetName(String name)

The name of the product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Parameter:** 
 - **name** String

```crmscript
NSQuoteLine thing;
String name;
thing.SetName(name);
```

