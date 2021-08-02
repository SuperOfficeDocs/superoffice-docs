---
uid: crmscript_ref_NSTicketPriorityEntity_GetTicketRead
title: Integer GetTicketRead()
intellisense: NSTicketPriorityEntity.GetTicketRead
keywords: NSTicketPriorityEntity, GetTicketRead
so.topic: reference
---

This field indicates what to do with the escalation chain when the request is read

**Returns:** Integer

     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer ticketRead  = thing.GetTicketRead();
```


