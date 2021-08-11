---
uid: crmscript_ref_NSPreference_GetLevel
title: Integer GetLevel()
intellisense: NSPreference.GetLevel
keywords: NSPreference, GetLevel
so.topic: reference
---

# Integer GetLevel()

NSPreference level, using the standard enumerated type. Undefined is returned for preferences that do not have a current setting.

**Returns:** Integer

     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

```crmscript
NSPreference thing;
Integer level  = thing.GetLevel();
```

