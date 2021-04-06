---
uid: crmscript_ref_NSTicketPriorityEntity_SetFlags
title: SetFlags(TicketPriorityFlags flags)
intellisense: NSTicketPriorityEntity.SetFlags
keywords: NSTicketPriorityEntity, GetFlags
so.topic: reference
---

A bitmask of flags.

**Parameter:** 
 - **flags** TicketPriorityFlags
     - Enum: 0 = Unknown 
     - Enum: 1 = External 
     - Enum: 2 = Default 
     - Enum: 4 = AlertSchedule 

```crmscript
NSTicketPriorityEntity thing;
TicketPriorityFlags flags;
thing.SetFlags(flags);
```

