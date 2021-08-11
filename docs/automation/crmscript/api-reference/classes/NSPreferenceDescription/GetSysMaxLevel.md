---
uid: crmscript_ref_NSPreferenceDescription_GetSysMaxLevel
title: Integer GetSysMaxLevel()
intellisense: NSPreferenceDescription.GetSysMaxLevel
keywords: NSPreferenceDescription, GetSysMaxLevel
so.topic: reference
---

# Integer GetSysMaxLevel()

Lowest allowed setting level, set by SuperOffice

**Returns:** Integer

     - Enum: 0 = Undefined 
     - Enum: 1 = HardDefault 
     - Enum: 2 = SystemWide 
     - Enum: 3 = Database 
     - Enum: 4 = Group 
     - Enum: 5 = Individual 
     - Enum: 6 = PC 

```crmscript
NSPreferenceDescription thing;
Integer sysMaxLevel  = thing.GetSysMaxLevel();
```

