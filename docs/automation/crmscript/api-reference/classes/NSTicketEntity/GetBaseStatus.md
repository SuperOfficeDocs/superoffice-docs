---
uid: crmscript_ref_NSTicketEntity_GetBaseStatus
title: Integer GetBaseStatus()
intellisense: NSTicketEntity.GetBaseStatus
keywords: NSTicketEntity, GetBaseStatus
so.topic: reference
---

The status of the ticket. I.e. active/closed/postponed/deleted

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicketEntity thing;
Integer baseStatus  = thing.GetBaseStatus();
```


