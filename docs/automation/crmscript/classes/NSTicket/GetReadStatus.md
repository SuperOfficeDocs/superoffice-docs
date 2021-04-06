---
uid: crmscript_ref_NSTicket_GetReadStatus
title: TicketReadStatus GetReadStatus()
intellisense: NSTicket.GetReadStatus
keywords: NSTicket, GetReadStatus
so.topic: reference
---

Whether the owner has read the ticket or not (red, yellow, green).

**Returns:** TicketReadStatus

     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 

```crmscript
NSTicket thing;
TicketReadStatus readStatus  = thing.GetReadStatus();
```


