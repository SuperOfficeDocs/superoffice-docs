---
uid: crmscript_ref_NSSelectionEntity_GetLastMembershipChangeByAssociate
title: NSAssociate GetLastMembershipChangeByAssociate()
intellisense: NSSelectionEntity.GetLastMembershipChangeByAssociate
keywords: NSSelectionEntity, GetLastMembershipChangeByAssociate
so.topic: reference
---

# NSAssociate GetLastMembershipChangeByAssociate()

Associate that last changed the selection membership (static members, dynamic criteria, combined parameters); only date (not time) is valid

**Returns:** NSAssociate

```crmscript
NSSelectionEntity thing;
NSAssociate lastMembershipChangeByAssociate  = thing.GetLastMembershipChangeByAssociate();
```

