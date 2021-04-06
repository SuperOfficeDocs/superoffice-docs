---
uid: crmscript_ref_NSTicket_GetBaseStatus
title: TicketBaseStatus GetBaseStatus()
intellisense: NSTicket.GetBaseStatus
keywords: NSTicket, GetBaseStatus
so.topic: reference
---

The status of the ticket. I.e. active/closed/postponed/deleted

**Returns:** TicketBaseStatus

     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicket thing;
TicketBaseStatus baseStatus  = thing.GetBaseStatus();
```


