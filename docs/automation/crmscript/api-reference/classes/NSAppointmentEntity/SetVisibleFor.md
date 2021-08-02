---
uid: crmscript_ref_NSAppointmentEntity_SetVisibleFor
title: SetVisibleFor(NSVisibleFor[] visibleFor)
intellisense: NSAppointmentEntity.SetVisibleFor
keywords: NSAppointmentEntity, SetVisibleFor
so.topic: reference
---

Set the usergroups and/or users the NSAppointmentEntity item is visible for.

**Parameter:** 
 - **visibleFor** NSVisibleFor[] of one or more users + usergroups.

```crmscript
NSAppointmentEntity thing;
NSVisibleFor[] visibleFor = thing.GetVisibleFor();
visibleFor[0].SetVisiblity(1);  // usergroup
visibleFor[0].SetVisibleId(123); // usergroup id
thing.SetVisibleFor(visibleFor);
```

