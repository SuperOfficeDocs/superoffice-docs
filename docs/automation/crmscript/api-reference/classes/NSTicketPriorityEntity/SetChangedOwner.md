---
uid: crmscript_ref_NSTicketPriorityEntity_SetChangedOwner
title: SetChangedOwner(Integer changedOwner)
intellisense: NSTicketPriorityEntity.SetChangedOwner
keywords: NSTicketPriorityEntity, GetChangedOwner
so.topic: reference
---

# SetChangedOwner(Integer changedOwner)

This field indicates what to do with the escalation chain when the request changes owner (manually)

**Parameter:** 
 - **changedOwner** Integer
     - Enum: -1 = None 
     - Enum: 0 = Stop 
     - Enum: 1 = Continue 
     - Enum: 2 = Restart 

```crmscript
NSTicketPriorityEntity thing;
Integer changedOwner;
thing.SetChangedOwner(changedOwner);
```

