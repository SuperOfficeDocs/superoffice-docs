---
uid: crmscript_ref_NSTicketPriorityEntity_GetTicketClosed
title: Integer GetTicketClosed()
intellisense: NSTicketPriorityEntity.GetTicketClosed
keywords: NSTicketPriorityEntity, GetTicketClosed
so.topic: reference
---

This field indicates what to do with the escalation chain when the request is closed

**Returns:** Integer

     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketClosed  = thing.GetTicketClosed();
```


