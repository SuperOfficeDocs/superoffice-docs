---
uid: crmscript_ref_NSQuoteLine_SetItemNumber
title: SetItemNumber(String itemNumber)
intellisense: NSQuoteLine.SetItemNumber
keywords: NSQuoteLine, GetItemNumber
so.topic: reference
---

Norwegian: «Postnummer». Specific numbers from some hierarchy, for instance '1.4.3.2'. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

**Parameter:** 
 - **itemNumber** String

```crmscript
NSQuoteLine thing;
String itemNumber;
thing.SetItemNumber(itemNumber);
```

