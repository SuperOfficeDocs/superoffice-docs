---
uid: crmscript_ref_NSPreferenceDescription_SetMaxLevel
title: SetMaxLevel(Integer maxLevel)
intellisense: NSPreferenceDescription.SetMaxLevel
keywords: NSPreferenceDescription, GetMaxLevel
so.topic: reference
---

# SetMaxLevel(Integer maxLevel)

Lowest allowed setting level, set by user, but not lower than sysMaxLevel

**Parameter:** 
 - **maxLevel** Integer
     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

```crmscript
NSPreferenceDescription thing;
Integer maxLevel;
thing.SetMaxLevel(maxLevel);
```

