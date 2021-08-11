---
uid: crmscript_ref_NSDashboardTileOption_GetType
title: Integer GetType()
intellisense: NSDashboardTileOption.GetType
keywords: NSDashboardTileOption, GetType
so.topic: reference
---

# Integer GetType()

The type of option - integer, list, boolean (checkbox) etc.

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = String 
     - Enum: 2 = Integer 
     - Enum: 3 = Boolean 
     - Enum: 4 = List 

```crmscript
NSDashboardTileOption thing;
Integer type  = thing.GetType();
```

