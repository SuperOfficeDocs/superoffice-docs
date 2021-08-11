---
uid: crmscript_ref_NSUpsertRowStatus_GetAction
title: Integer GetAction()
intellisense: NSUpsertRowStatus.GetAction
keywords: NSUpsertRowStatus, GetAction
so.topic: reference
---

# Integer GetAction()

Actiona taken for row

**Returns:** Integer

     - Enum: 1 = Inserted 
     - Enum: 2 = Updated 
     - Enum: 3 = NoUpdateNeeded 
     - Enum: 4 = Deleted 
     - Enum: 5 = ColumnsZeroed 

```crmscript
NSUpsertRowStatus thing;
Integer action  = thing.GetAction();
```

