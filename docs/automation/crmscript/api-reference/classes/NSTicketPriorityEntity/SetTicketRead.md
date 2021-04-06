---
uid: crmscript_ref_NSTicketPriorityEntity_SetTicketRead
title: SetTicketRead(TicketPriorityEscalateEvent ticketRead)
intellisense: NSTicketPriorityEntity.SetTicketRead
keywords: NSTicketPriorityEntity, GetTicketRead
so.topic: reference
---

This field indicates what to do with the escalation chain when the request is read

**Parameter:** 
 - **ticketRead** TicketPriorityEscalateEvent
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
TicketPriorityEscalateEvent ticketRead;
thing.SetTicketRead(ticketRead);
```

