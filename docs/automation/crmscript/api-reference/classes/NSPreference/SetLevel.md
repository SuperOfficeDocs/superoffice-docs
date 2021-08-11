---
uid: crmscript_ref_NSPreference_SetLevel
title: SetLevel(Integer level)
intellisense: NSPreference.SetLevel
keywords: NSPreference, GetLevel
so.topic: reference
---

# SetLevel(Integer level)

NSPreference level, using the standard enumerated type. Undefined is returned for preferences that do not have a current setting.

**Parameter:** 
 - **level** Integer
     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

```crmscript
NSPreference thing;
Integer level;
thing.SetLevel(level);
```

