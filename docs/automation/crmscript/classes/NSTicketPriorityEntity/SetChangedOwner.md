---
uid: crmscript_ref_NSTicketPriorityEntity_SetChangedOwner
title: SetChangedOwner(TicketPriorityEscalateEvent changedOwner)
intellisense: NSTicketPriorityEntity.SetChangedOwner
keywords: NSTicketPriorityEntity, GetChangedOwner
so.topic: reference
---

This field indicates what to do with the escalation chain when the request changes owner (manually)

**Parameter:** 
 - **changedOwner** TicketPriorityEscalateEvent
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
TicketPriorityEscalateEvent changedOwner;
thing.SetChangedOwner(changedOwner);
```

