---
uid: crmscript_ref_NSDashboard_GetLayout
title: Integer GetLayout()
intellisense: NSDashboard.GetLayout
keywords: NSDashboard, GetLayout
so.topic: reference
---

# Integer GetLayout()

The dashboard layout, how the tiles are organized on the screen

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = One 
     - Enum: 2 = TwoVerticalSplit 
     - Enum: 3 = ThreeESplit 
     - Enum: 4 = TwoHorizontalSplit 
     - Enum: 5 = ThreeTSplit 
     - Enum: 7 = Four 

```crmscript
NSDashboard thing;
Integer layout  = thing.GetLayout();
```

