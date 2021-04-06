---
uid: crmscript_ref_NSFreeText_GetMultiWordOperator
title: Integer GetMultiWordOperator()
intellisense: NSFreeText.GetMultiWordOperator
keywords: NSFreeText, GetMultiWordOperator
so.topic: reference
---

Starts with, contains or exact match

**Returns:** Integer

     - Enum: 1 = Contains 
     - Enum: 2 = StartsWith 
     - Enum: 3 = ExactMatch 

```crmscript
NSFreeText thing;
Integer multiWordOperator  = thing.GetMultiWordOperator();
```


