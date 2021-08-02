---
uid: crmscript_ref_NSTicketPriorityEntity_SetTicketNew
title: SetTicketNew(Integer ticketNew)
intellisense: NSTicketPriorityEntity.SetTicketNew
keywords: NSTicketPriorityEntity, GetTicketNew
so.topic: reference
---

This field indicates what to do with the escalation chain when a new request is registered

**Parameter:** 
 - **ticketNew** Integer
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketNew;
thing.SetTicketNew(ticketNew);
```

