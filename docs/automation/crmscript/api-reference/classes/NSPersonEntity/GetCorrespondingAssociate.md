---
uid: crmscript_ref_NSPersonEntity_GetCorrespondingAssociate
title: NSAssociate GetCorrespondingAssociate()
intellisense: NSPersonEntity.GetCorrespondingAssociate
keywords: NSPersonEntity, GetCorrespondingAssociate
so.topic: reference
---

# NSAssociate GetCorrespondingAssociate()

The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user).

**Returns:** NSAssociate

```crmscript
NSPersonEntity thing;
NSAssociate correspondingAssociate  = thing.GetCorrespondingAssociate();
```

