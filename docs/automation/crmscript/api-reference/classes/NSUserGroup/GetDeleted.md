---
uid: crmscript_ref_NSUserGroup_GetDeleted
title: Bool GetDeleted()
intellisense: NSUserGroup.GetDeleted
keywords: NSUserGroup, GetDeleted
so.topic: reference
---

# Bool GetDeleted()

Deleted equal to true means that this is a user group that no longer can be selected by the user.  It is not permitted to delete a UserGroup.

**Returns:** Bool

```crmscript
NSUserGroup thing;
Bool deleted  = thing.GetDeleted();
```

