---
uid: crmscript_ref_NSTicketPriorityEntity_SetTicketClosed
title: SetTicketClosed(Integer ticketClosed)
intellisense: NSTicketPriorityEntity.SetTicketClosed
keywords: NSTicketPriorityEntity, GetTicketClosed
so.topic: reference
---

# SetTicketClosed(Integer ticketClosed)

This field indicates what to do with the escalation chain when the request is closed

**Parameter:** 
 - **ticketClosed** Integer
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketClosed;
thing.SetTicketClosed(ticketClosed);
```

