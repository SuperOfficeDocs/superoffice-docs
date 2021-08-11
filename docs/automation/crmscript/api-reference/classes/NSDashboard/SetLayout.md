---
uid: crmscript_ref_NSDashboard_SetLayout
title: SetLayout(Integer layout)
intellisense: NSDashboard.SetLayout
keywords: NSDashboard, GetLayout
so.topic: reference
---

# SetLayout(Integer layout)

The dashboard layout, how the tiles are organized on the screen

**Parameter:** 
 - **layout** Integer
     - Enum: 0 = None 
     - Enum: 1 = One 
     - Enum: 2 = TwoVerticalSplit 
     - Enum: 3 = ThreeESplit 
     - Enum: 4 = TwoHorizontalSplit 
     - Enum: 5 = ThreeTSplit 
     - Enum: 7 = Four 

```crmscript
NSDashboard thing;
Integer layout;
thing.SetLayout(layout);
```

