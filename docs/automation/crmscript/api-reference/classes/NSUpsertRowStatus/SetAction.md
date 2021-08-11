---
uid: crmscript_ref_NSUpsertRowStatus_SetAction
title: SetAction(Integer action)
intellisense: NSUpsertRowStatus.SetAction
keywords: NSUpsertRowStatus, GetAction
so.topic: reference
---

# SetAction(Integer action)

Actiona taken for row

**Parameter:** 
 - **action** Integer
     - Enum: 1 = Inserted 
     - Enum: 2 = Updated 
     - Enum: 3 = NoUpdateNeeded 
     - Enum: 4 = Deleted 
     - Enum: 5 = ColumnsZeroed 

```crmscript
NSUpsertRowStatus thing;
Integer action;
thing.SetAction(action);
```

