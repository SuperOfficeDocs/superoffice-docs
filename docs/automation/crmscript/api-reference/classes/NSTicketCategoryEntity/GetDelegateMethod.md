---
uid: crmscript_ref_NSTicketCategoryEntity_GetDelegateMethod
title: Integer GetDelegateMethod()
intellisense: NSTicketCategoryEntity.GetDelegateMethod
keywords: NSTicketCategoryEntity, GetDelegateMethod
so.topic: reference
---

# Integer GetDelegateMethod()

An integer indicating the delegation method for this category.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Even 
     - Enum: 2 = Weighted 
     - Enum: 3 = Unfair 
     - Enum: 4 = Not 

```crmscript
NSTicketCategoryEntity thing;
Integer delegateMethod  = thing.GetDelegateMethod();
```

