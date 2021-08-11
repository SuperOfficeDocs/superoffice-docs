---
uid: crmscript_ref_NSTicketPriorityEntity_GetTicketChangedPriority
title: Integer GetTicketChangedPriority()
intellisense: NSTicketPriorityEntity.GetTicketChangedPriority
keywords: NSTicketPriorityEntity, GetTicketChangedPriority
so.topic: reference
---

# Integer GetTicketChangedPriority()

This field indicates what to do with the escalation chain when the request is changed into this priority

**Returns:** Integer

     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketChangedPriority  = thing.GetTicketChangedPriority();
```

