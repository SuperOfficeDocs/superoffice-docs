---
uid: crmscript_ref_NSQuoteLine_GetItemNumber
title: String GetItemNumber()
intellisense: NSQuoteLine.GetItemNumber
keywords: NSQuoteLine, GetItemNumber
so.topic: reference
---

# String GetItemNumber()

Norwegian: «Postnummer». Specific numbers from some hierarchy, for instance '1.4.3.2'. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Returns:** String

```crmscript
NSQuoteLine thing;
String itemNumber  = thing.GetItemNumber();
```

