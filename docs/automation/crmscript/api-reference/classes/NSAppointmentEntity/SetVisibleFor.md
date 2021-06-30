---
uid: crmscript_ref_NSAppointmentEntity_SetVisibleFor
title: SetVisibleFor(VisibleFor[] visibleFor)
intellisense: NSAppointmentEntity.SetVisibleFor
keywords: NSAppointmentEntity, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the AppointmentEntity item is visible for.

**Parameter:** 
 - **visibleFor** VisibleFor[] of one or more users + usergroups.

```crmscript
NSAppointmentEntity thing;
VisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

