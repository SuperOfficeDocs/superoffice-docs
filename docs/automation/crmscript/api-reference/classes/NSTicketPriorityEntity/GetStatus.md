---
uid: crmscript_ref_NSTicketPriorityEntity_GetStatus
title: Integer GetStatus()
intellisense: NSTicketPriorityEntity.GetStatus
keywords: NSTicketPriorityEntity, GetStatus
so.topic: reference
---

# Integer GetStatus()

The status (normal/deleted) of the priority.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Normal 
     - Enum: 2 = Deleted 

```crmscript
NSTicketPriorityEntity thing;
Integer status  = thing.GetStatus();
```

