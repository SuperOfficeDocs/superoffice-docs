---
uid: crmscript_ref_NSTicketEntity_SetReadStatus
title: SetReadStatus(TicketReadStatus readStatus)
intellisense: NSTicketEntity.SetReadStatus
keywords: NSTicketEntity, GetReadStatus
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
NSTicketEntity thing;
TicketReadStatus readStatus;
thing.SetReadStatus(readStatus);
```

