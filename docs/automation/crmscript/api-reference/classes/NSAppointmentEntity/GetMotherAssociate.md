---
uid: crmscript_ref_NSAppointmentEntity_GetMotherAssociate
title: Associate GetMotherAssociate()
intellisense: NSAppointmentEntity.GetMotherAssociate
keywords: NSAppointmentEntity, GetMotherAssociate
so.topic: reference
---

The owner of the mother appointment - the associate whose diary/checklist the mother appointment is in.  The mother appointment is the one identified by the mother_id. If the mother_id is 0 or the same as this appointment_id, then the master associate will be the same as the 'ordinary' associate.

**Returns:** Associate


```crmscript
NSAppointmentEntity thing;
Associate motherAssociate  = thing.GetMotherAssociate();
```


