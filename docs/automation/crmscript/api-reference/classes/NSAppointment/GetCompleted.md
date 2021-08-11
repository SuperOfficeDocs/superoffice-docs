---
uid: crmscript_ref_NSAppointment_GetCompleted
title: Integer GetCompleted()
intellisense: NSAppointment.GetCompleted
keywords: NSAppointment, GetCompleted
so.topic: reference
---

# Integer GetCompleted()

The Completed state. 

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = NotStarted 
     - Enum: 2 = Started 
     - Enum: 3 = Completed 

```crmscript
NSAppointment thing;
Integer completed  = thing.GetCompleted();
```

