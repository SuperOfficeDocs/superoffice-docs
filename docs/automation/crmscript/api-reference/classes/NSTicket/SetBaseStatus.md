---
uid: crmscript_ref_NSTicket_SetBaseStatus
title: SetBaseStatus(Integer baseStatus)
intellisense: NSTicket.SetBaseStatus
keywords: NSTicket, GetBaseStatus
so.topic: reference
---

The status of the ticket. I.e. active/closed/postponed/deleted

**Parameter:** 
 - **baseStatus** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicket thing;
Integer baseStatus;
thing.SetBaseStatus(baseStatus);
```

