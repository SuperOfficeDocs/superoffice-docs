---
uid: crmscript_ref_NSTicket_SetReadStatus
title: SetReadStatus(Integer readStatus)
intellisense: NSTicket.SetReadStatus
keywords: NSTicket, GetReadStatus
so.topic: reference
---

# SetReadStatus(Integer readStatus)

Whether the owner has read the ticket or not (red, yellow, green).

**Parameter:** 
 - **readStatus** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 

```crmscript
NSTicket thing;
Integer readStatus;
thing.SetReadStatus(readStatus);
```

