---
uid: crmscript_ref_NSSuggestedAppointmentEntity_SetDeleted
title: SetDeleted(Bool deleted)
intellisense: NSSuggestedAppointmentEntity.SetDeleted
keywords: NSSuggestedAppointmentEntity, GetDeleted
so.topic: reference
---

# SetDeleted(Bool deleted)

0 -> record is active 1 -> record is 'deleted' and should not be shown in lists

**Parameter:** 
 - **deleted** Bool

```crmscript
NSSuggestedAppointmentEntity thing;
Bool deleted;
thing.SetDeleted(deleted);
```

