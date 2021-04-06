---
uid: crmscript_ref_NSPersonEntity_GetCorrespondingAssociate
title: Associate GetCorrespondingAssociate()
intellisense: NSPersonEntity.GetCorrespondingAssociate
keywords: NSPersonEntity, GetCorrespondingAssociate
so.topic: reference
---

The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user).

**Returns:** Associate


```crmscript
NSPersonEntity thing;
Associate correspondingAssociate  = thing.GetCorrespondingAssociate();
```


