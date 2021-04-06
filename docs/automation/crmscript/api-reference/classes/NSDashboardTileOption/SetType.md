---
uid: crmscript_ref_NSDashboardTileOption_SetType
title: SetType(Integer type)
intellisense: NSDashboardTileOption.SetType
keywords: NSDashboardTileOption, GetType
so.topic: reference
---

The type of option - integer, list, boolean (checkbox) etc.

**Parameter:** 
 - **type** Integer
     - Enum: 0 = None 
     - Enum: 1 = String 
     - Enum: 2 = Integer 
     - Enum: 3 = Boolean 
     - Enum: 4 = List 

```crmscript
NSDashboardTileOption thing;
Integer type;
thing.SetType(type);
```

