---
uid: crmscript_ref_NSTicketEntity_SetBaseStatus
title: SetBaseStatus(TicketBaseStatus baseStatus)
intellisense: NSTicketEntity.SetBaseStatus
keywords: NSTicketEntity, GetBaseStatus
so.topic: reference
---

The status of the ticket. I.e. active/closed/postponed/deleted

**Parameter:** 
 - **baseStatus** TicketBaseStatus
     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicketEntity thing;
TicketBaseStatus baseStatus;
thing.SetBaseStatus(baseStatus);
```

