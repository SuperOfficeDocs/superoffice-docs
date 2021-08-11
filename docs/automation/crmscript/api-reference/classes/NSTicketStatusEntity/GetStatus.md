---
uid: crmscript_ref_NSTicketStatusEntity_GetStatus
title: Integer GetStatus()
intellisense: NSTicketStatusEntity.GetStatus
keywords: NSTicketStatusEntity, GetStatus
so.topic: reference
---

# Integer GetStatus()

The &apos;classic&apos; ticket status. I.e. active/closed/postponed/deleted

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicketStatusEntity thing;
Integer status  = thing.GetStatus();
```

