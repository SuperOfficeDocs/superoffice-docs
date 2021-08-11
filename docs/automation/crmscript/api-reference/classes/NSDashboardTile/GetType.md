---
uid: crmscript_ref_NSDashboardTile_GetType
title: Integer GetType()
intellisense: NSDashboardTile.GetType
keywords: NSDashboardTile, GetType
so.topic: reference
---

# Integer GetType()

The tile type, what kind of tile this is

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Chart 
     - Enum: 2 = Web 
     - Enum: 3 = List 
     - Enum: 4 = Bignum 

```crmscript
NSDashboardTile thing;
Integer type  = thing.GetType();
```

