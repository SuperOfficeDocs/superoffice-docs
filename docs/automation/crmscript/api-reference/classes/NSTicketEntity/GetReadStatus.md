---
uid: crmscript_ref_NSTicketEntity_GetReadStatus
title: Integer GetReadStatus()
intellisense: NSTicketEntity.GetReadStatus
keywords: NSTicketEntity, GetReadStatus
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
NSTicketEntity thing;
Integer readStatus  = thing.GetReadStatus();
```

