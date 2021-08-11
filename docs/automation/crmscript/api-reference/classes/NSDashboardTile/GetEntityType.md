---
uid: crmscript_ref_NSDashboardTile_GetEntityType
title: Integer GetEntityType()
intellisense: NSDashboardTile.GetEntityType
keywords: NSDashboardTile, GetEntityType
so.topic: reference
---

# Integer GetEntityType()

The tile entity type

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = Company 
     - Enum: 2 = Project 
     - Enum: 3 = Sale 
     - Enum: 4 = Product 
     - Enum: 5 = Activity 
     - Enum: 6 = Document 
     - Enum: 7 = WebPanel 
     - Enum: 8 = Followup 

```crmscript
NSDashboardTile thing;
Integer entityType  = thing.GetEntityType();
```

