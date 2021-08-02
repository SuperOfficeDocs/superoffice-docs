---
uid: crmscript_ref_NSTicketPriorityEntity_SetStatus
title: SetStatus(Integer status)
intellisense: NSTicketPriorityEntity.SetStatus
keywords: NSTicketPriorityEntity, GetStatus
so.topic: reference
---

The status (normal/deleted) of the priority.

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Normal 
     - Enum: 2 = Deleted 

```crmscript
NSTicketPriorityEntity thing;
Integer status;
thing.SetStatus(status);
```

