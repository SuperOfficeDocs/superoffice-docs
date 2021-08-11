---
uid: crmscript_ref_NSAppointmentEntity_SetPerson
title: SetPerson(NSPerson person)
intellisense: NSAppointmentEntity.SetPerson
keywords: NSAppointmentEntity, GetPerson
so.topic: reference
---

# SetPerson(NSPerson person)

An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.

**Parameter:** 
 - **person** NSPerson

```crmscript
NSAppointmentEntity thing;
NSPerson person;
thing.SetPerson(person);
```

