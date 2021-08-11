---
uid: crmscript_ref_NSSaleEntity_SetPerson
title: SetPerson(NSPerson person)
intellisense: NSSaleEntity.SetPerson
keywords: NSSaleEntity, GetPerson
so.topic: reference
---

# SetPerson(NSPerson person)

A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.

**Parameter:** 
 - **person** NSPerson

```crmscript
NSSaleEntity thing;
NSPerson person;
thing.SetPerson(person);
```

