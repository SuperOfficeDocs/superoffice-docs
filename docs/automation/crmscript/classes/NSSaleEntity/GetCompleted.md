---
uid: crmscript_ref_NSSaleEntity_GetCompleted
title: Integer GetCompleted()
intellisense: NSSaleEntity.GetCompleted
keywords: NSSaleEntity, GetCompleted
so.topic: reference
---

The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSSaleEntity thing;
Integer completed  = thing.GetCompleted();
```


