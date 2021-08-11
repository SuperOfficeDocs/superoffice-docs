---
uid: crmscript_ref_NSQuoteLine_GetUrl
title: String GetUrl()
intellisense: NSQuoteLine.GetUrl
keywords: NSQuoteLine, GetUrl
so.topic: reference
---

# String GetUrl()

A url to the product info. Can be empty. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String url  = thing.GetUrl();
```

