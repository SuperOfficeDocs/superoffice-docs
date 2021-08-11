---
uid: crmscript_ref_NSFreeText_SetMultiWordOperator
title: SetMultiWordOperator(Integer multiWordOperator)
intellisense: NSFreeText.SetMultiWordOperator
keywords: NSFreeText, GetMultiWordOperator
so.topic: reference
---

# SetMultiWordOperator(Integer multiWordOperator)

Starts with, contains or exact match

**Parameter:** 
 - **multiWordOperator** Integer
     - Enum: 1 = Contains 
     - Enum: 2 = StartsWith 
     - Enum: 3 = ExactMatch 

```crmscript
NSFreeText thing;
Integer multiWordOperator;
thing.SetMultiWordOperator(multiWordOperator);
```

