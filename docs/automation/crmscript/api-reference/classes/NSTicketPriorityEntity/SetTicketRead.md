---
uid: crmscript_ref_NSTicketPriorityEntity_SetTicketRead
title: SetTicketRead(Integer ticketRead)
intellisense: NSTicketPriorityEntity.SetTicketRead
keywords: NSTicketPriorityEntity, GetTicketRead
so.topic: reference
---

# SetTicketRead(Integer ticketRead)

This field indicates what to do with the escalation chain when the request is read

**Parameter:** 
 - **ticketRead** Integer
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketRead;
thing.SetTicketRead(ticketRead);
```

