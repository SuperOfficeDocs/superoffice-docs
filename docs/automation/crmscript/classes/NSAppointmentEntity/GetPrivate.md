---
uid: crmscript_ref_NSAppointmentEntity_GetPrivate
title: Integer GetPrivate()
intellisense: NSAppointmentEntity.GetPrivate
keywords: NSAppointmentEntity, GetPrivate
so.topic: reference
---

The confidentiality of appointments is shown as different types of “private” on the appointment. For an updated list of “private” types, see the database manual.

**Returns:** Integer

     - Enum: 0 = Public 
     - Enum: 1 = PrivateUser 
     - Enum: 2 = PrivateGroup 

```crmscript
NSAppointmentEntity thing;
Integer private  = thing.GetPrivate();
```


