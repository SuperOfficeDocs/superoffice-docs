---
uid: crmscript_ref_NSAppointment_GetRecurringPattern
title: Integer GetRecurringPattern()
intellisense: NSAppointment.GetRecurringPattern
keywords: NSAppointment, GetRecurringPattern
so.topic: reference
---



**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Daily 
     - Enum: 2 = Weekly 
     - Enum: 3 = Monthly 
     - Enum: 4 = Yearly 
     - Enum: 5 = Custom 

```crmscript
NSAppointment thing;
Integer recurringPattern  = thing.GetRecurringPattern();
```


