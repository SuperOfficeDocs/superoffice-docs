---
uid: crmscript_ref_NSTicket_GetReadStatus
title: Integer GetReadStatus()
intellisense: NSTicket.GetReadStatus
keywords: NSTicket, GetReadStatus
so.topic: reference
---

# Integer GetReadStatus()

Whether the owner has read the ticket or not (red, yellow, green).

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Green 
     - Enum: 2 = Yellow 
     - Enum: 3 = Red 

```crmscript
NSTicket thing;
Integer readStatus  = thing.GetReadStatus();
```

