---
uid: crmscript_ref_NSProduct_GetItemNumber
title: String GetItemNumber()
intellisense: NSProduct.GetItemNumber
keywords: NSProduct, GetItemNumber
so.topic: reference
---

Line item number, NOR: «Postnummer». Specific numbers from some hierarchy, for instance “1.4.3.2P”. Typically used to sort the items in the quote by some standard way.

**Returns:** String


```crmscript
NSProduct thing;
String itemNumber  = thing.GetItemNumber();
```


