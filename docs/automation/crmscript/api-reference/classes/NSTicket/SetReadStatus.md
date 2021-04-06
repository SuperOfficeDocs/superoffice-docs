---
uid: crmscript_ref_NSTicket_SetReadStatus
title: SetReadStatus(TicketReadStatus readStatus)
intellisense: NSTicket.SetReadStatus
keywords: NSTicket, GetReadStatus
so.topic: reference
---

Whether the owner has read the ticket or not (red, yellow, green).

**Parameter:** 
 - **readStatus** TicketReadStatus
     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 

```crmscript
NSTicket thing;
TicketReadStatus readStatus;
thing.SetReadStatus(readStatus);
```

