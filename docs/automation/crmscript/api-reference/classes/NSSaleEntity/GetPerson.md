---
uid: crmscript_ref_NSSaleEntity_GetPerson
title: NSPerson GetPerson()
intellisense: NSSaleEntity.GetPerson
keywords: NSSaleEntity, GetPerson
so.topic: reference
---

# NSPerson GetPerson()

A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.

**Returns:** NSPerson

```crmscript
NSSaleEntity thing;
NSPerson person  = thing.GetPerson();
```

