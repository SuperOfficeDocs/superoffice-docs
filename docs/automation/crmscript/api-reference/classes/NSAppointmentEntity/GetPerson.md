---
uid: crmscript_ref_NSAppointmentEntity_GetPerson
title: NSPerson GetPerson()
intellisense: NSAppointmentEntity.GetPerson
keywords: NSAppointmentEntity, GetPerson
so.topic: reference
---

An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.

**Returns:** NSPerson


```crmscript
NSAppointmentEntity thing;
NSPerson person  = thing.GetPerson();
```


