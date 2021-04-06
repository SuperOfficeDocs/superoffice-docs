---
uid: crmscript_ref_NSMailMergeTask_GetOwnerAssociateId
title: Integer GetOwnerAssociateId()
intellisense: NSMailMergeTask.GetOwnerAssociateId
keywords: NSMailMergeTask, GetOwnerAssociateId
so.topic: reference
---

Associate identity of who should be set as owner of the task.  If value is 0, the recipient owner(our contact) will be used.

**Returns:** Integer


```crmscript
NSMailMergeTask thing;
Integer ownerAssociateId  = thing.GetOwnerAssociateId();
```


