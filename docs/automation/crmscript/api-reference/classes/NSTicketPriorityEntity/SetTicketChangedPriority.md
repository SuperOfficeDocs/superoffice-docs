---
uid: crmscript_ref_NSTicketPriorityEntity_SetTicketChangedPriority
title: SetTicketChangedPriority(Integer ticketChangedPriority)
intellisense: NSTicketPriorityEntity.SetTicketChangedPriority
keywords: NSTicketPriorityEntity, GetTicketChangedPriority
so.topic: reference
---

This field indicates what to do with the escalation chain when the request is changed into this priority

**Parameter:** 
 - **ticketChangedPriority** Integer
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketChangedPriority;
thing.SetTicketChangedPriority(ticketChangedPriority);
```

