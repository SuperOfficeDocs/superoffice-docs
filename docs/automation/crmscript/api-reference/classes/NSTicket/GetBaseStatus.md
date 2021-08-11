---
uid: crmscript_ref_NSTicket_GetBaseStatus
title: Integer GetBaseStatus()
intellisense: NSTicket.GetBaseStatus
keywords: NSTicket, GetBaseStatus
so.topic: reference
---

# Integer GetBaseStatus()

The status of the ticket. I.e. active/closed/postponed/deleted

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicket thing;
Integer baseStatus  = thing.GetBaseStatus();
```

