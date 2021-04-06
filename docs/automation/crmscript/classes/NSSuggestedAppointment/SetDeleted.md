---
uid: crmscript_ref_NSSuggestedAppointment_SetDeleted
title: SetDeleted(Integer deleted)
intellisense: NSSuggestedAppointment.SetDeleted
keywords: NSSuggestedAppointment, GetDeleted
so.topic: reference
---

0 -> record is active 1 -> record is 'deleted' and should not be shown in lists

**Parameter:** 
 - **deleted** Integer

```crmscript
NSSuggestedAppointment thing;
Integer deleted;
thing.SetDeleted(deleted);
```

