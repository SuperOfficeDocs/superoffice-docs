---
uid: crmscript_ref_NSTicketStatusEntity_SetTimeCounter
title: SetTimeCounter(Integer timeCounter)
intellisense: NSTicketStatusEntity.SetTimeCounter
keywords: NSTicketStatusEntity, GetTimeCounter
so.topic: reference
---

# SetTimeCounter(Integer timeCounter)

Which field in ticket we count time spent on (queue, internal, external) 

**Parameter:** 
 - **timeCounter** Integer
     - Enum: 0 = None 
     - Enum: 1 = Internally 
     - Enum: 2 = Externally 
     - Enum: 3 = Queue 

```crmscript
NSTicketStatusEntity thing;
Integer timeCounter;
thing.SetTimeCounter(timeCounter);
```

