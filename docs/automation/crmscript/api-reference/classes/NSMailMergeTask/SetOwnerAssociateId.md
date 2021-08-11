---
uid: crmscript_ref_NSMailMergeTask_SetOwnerAssociateId
title: SetOwnerAssociateId(Integer ownerAssociateId)
intellisense: NSMailMergeTask.SetOwnerAssociateId
keywords: NSMailMergeTask, GetOwnerAssociateId
so.topic: reference
---

# SetOwnerAssociateId(Integer ownerAssociateId)

Associate identity of who should be set as owner of the task.  If value is 0, the recipient owner(our contact) will be used.

**Parameter:** 
 - **ownerAssociateId** Integer

```crmscript
NSMailMergeTask thing;
Integer ownerAssociateId;
thing.SetOwnerAssociateId(ownerAssociateId);
```

