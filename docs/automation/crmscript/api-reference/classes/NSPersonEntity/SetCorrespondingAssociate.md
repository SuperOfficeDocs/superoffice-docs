---
uid: crmscript_ref_NSPersonEntity_SetCorrespondingAssociate
title: SetCorrespondingAssociate(NSAssociate correspondingAssociate)
intellisense: NSPersonEntity.SetCorrespondingAssociate
keywords: NSPersonEntity, GetCorrespondingAssociate
so.topic: reference
---

# SetCorrespondingAssociate(NSAssociate correspondingAssociate)

The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user).

**Parameter:** 
 - **correspondingAssociate** NSAssociate

```crmscript
NSPersonEntity thing;
NSAssociate correspondingAssociate;
thing.SetCorrespondingAssociate(correspondingAssociate);
```

