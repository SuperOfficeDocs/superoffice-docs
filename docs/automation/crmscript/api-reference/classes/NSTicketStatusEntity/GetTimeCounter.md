---
uid: crmscript_ref_NSTicketStatusEntity_GetTimeCounter
title: Integer GetTimeCounter()
intellisense: NSTicketStatusEntity.GetTimeCounter
keywords: NSTicketStatusEntity, GetTimeCounter
so.topic: reference
---

# Integer GetTimeCounter()

Which field in ticket we count time spent on (queue, internal, external) 

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Internally 
     - Enum: 2 = Externally 
     - Enum: 3 = Queue 

```crmscript
NSTicketStatusEntity thing;
Integer timeCounter  = thing.GetTimeCounter();
```

