---
uid: crmscript_ref_NSProjectEventEntity_GetPublishType
title: Integer GetPublishType()
intellisense: NSProjectEventEntity.GetPublishType
keywords: NSProjectEventEntity, GetPublishType
so.topic: reference
---

Type of publishing action, 0 = Unknown, 1 = to external persons

**Returns:** Integer

     - Enum: 0 = Undefined 
     - Enum: 1 = External 

```crmscript
NSProjectEventEntity thing;
Integer publishType  = thing.GetPublishType();
```


