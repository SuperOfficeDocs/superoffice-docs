---
uid: crmscript_ref_NSSelectionEntity_GetSelectionUnionType
title: Integer GetSelectionUnionType()
intellisense: NSSelectionEntity.GetSelectionUnionType
keywords: NSSelectionEntity, GetSelectionUnionType
so.topic: reference
---

How to combine the two selections when SelectionType = Combined.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = SubtractRightFromLeft 
     - Enum: 2 = SubtractLeftFromRight 
     - Enum: 3 = Intersect 
     - Enum: 4 = XOR 
     - Enum: 5 = Union 

```crmscript
NSSelectionEntity thing;
Integer selectionUnionType  = thing.GetSelectionUnionType();
```


