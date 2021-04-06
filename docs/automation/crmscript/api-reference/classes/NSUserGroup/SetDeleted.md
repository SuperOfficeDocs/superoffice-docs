---
uid: crmscript_ref_NSUserGroup_SetDeleted
title: SetDeleted(Bool deleted)
intellisense: NSUserGroup.SetDeleted
keywords: NSUserGroup, GetDeleted
so.topic: reference
---

Deleted equal to true means that this is a user group that no longer can be selected by the user.  It is not permitted to delete a UserGroup.

**Parameter:** 
 - **deleted** Bool

```crmscript
NSUserGroup thing;
Bool deleted;
thing.SetDeleted(deleted);
```

