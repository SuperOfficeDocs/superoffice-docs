---
uid: crmscript_ref_NSTicketPriorityEntity_GetTicketRead
title: TicketPriorityEscalateEvent GetTicketRead()
intellisense: NSTicketPriorityEntity.GetTicketRead
keywords: NSTicketPriorityEntity, GetTicketRead
so.topic: reference
---

This field indicates what to do with the escalation chain when the request is read

**Returns:** TicketPriorityEscalateEvent

     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
TicketPriorityEscalateEvent ticketRead  = thing.GetTicketRead();
```


