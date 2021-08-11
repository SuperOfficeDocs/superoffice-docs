---
uid: crmscript_ref_NSTicketStatusEntity_SetStatus
title: SetStatus(Integer status)
intellisense: NSTicketStatusEntity.SetStatus
keywords: NSTicketStatusEntity, GetStatus
so.topic: reference
---

# SetStatus(Integer status)

The &apos;classic&apos; ticket status. I.e. active/closed/postponed/deleted

**Parameter:** 
 - **status** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 
     - Enum: 4 = Deleted 
     - Enum: 5 = Merged 

```crmscript
NSTicketStatusEntity thing;
Integer status;
thing.SetStatus(status);
```

