---
uid: crmscript_ref_NSSaleTypeEntity_GetDurationUnit
title: Integer GetDurationUnit()
intellisense: NSSaleTypeEntity.GetDurationUnit
keywords: NSSaleTypeEntity, GetDurationUnit
so.topic: reference
---

# Integer GetDurationUnit()

Units for the duration (day, week, whatever)

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Second 
     - Enum: 2 = Minute 
     - Enum: 3 = Hour 
     - Enum: 4 = Day 
     - Enum: 5 = Week 
     - Enum: 6 = Month 
     - Enum: 7 = Quarter 
     - Enum: 8 = HalfYear 
     - Enum: 9 = Year 
     - Enum: 10 = Decade 
     - Enum: 11 = Century 
     - Enum: 12 = Millenium 

```crmscript
NSSaleTypeEntity thing;
Integer durationUnit  = thing.GetDurationUnit();
```

