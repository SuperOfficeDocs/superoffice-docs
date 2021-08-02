---
uid: crmscript_ref_NSPreferenceDescription_SetSysMaxLevel
title: SetSysMaxLevel(Integer sysMaxLevel)
intellisense: NSPreferenceDescription.SetSysMaxLevel
keywords: NSPreferenceDescription, GetSysMaxLevel
so.topic: reference
---

Lowest allowed setting level, set by SuperOffice

**Parameter:** 
 - **sysMaxLevel** Integer
     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

```crmscript
NSPreferenceDescription thing;
Integer sysMaxLevel;
thing.SetSysMaxLevel(sysMaxLevel);
```

