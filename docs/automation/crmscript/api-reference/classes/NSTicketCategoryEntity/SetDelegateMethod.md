---
uid: crmscript_ref_NSTicketCategoryEntity_SetDelegateMethod
title: SetDelegateMethod(Integer delegateMethod)
intellisense: NSTicketCategoryEntity.SetDelegateMethod
keywords: NSTicketCategoryEntity, GetDelegateMethod
so.topic: reference
---

An integer indicating the delegation method for this category.

**Parameter:** 
 - **delegateMethod** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Even 
     - Enum: 2 = Weighted 
     - Enum: 3 = Unfair 
     - Enum: 4 = Not 

```crmscript
NSTicketCategoryEntity thing;
Integer delegateMethod;
thing.SetDelegateMethod(delegateMethod);
```

