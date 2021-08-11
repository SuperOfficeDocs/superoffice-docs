---
uid: crmscript_ref_NSSelectionEntity_SetSelectionUnionType
title: SetSelectionUnionType(Integer selectionUnionType)
intellisense: NSSelectionEntity.SetSelectionUnionType
keywords: NSSelectionEntity, GetSelectionUnionType
so.topic: reference
---

# SetSelectionUnionType(Integer selectionUnionType)

How to combine the two selections when SelectionType = Combined.

**Parameter:** 
 - **selectionUnionType** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = SubtractRightFromLeft 
     - Enum: 2 = SubtractLeftFromRight 
     - Enum: 3 = Intersect 
     - Enum: 4 = XOR 
     - Enum: 5 = Union 

```crmscript
NSSelectionEntity thing;
Integer selectionUnionType;
thing.SetSelectionUnionType(selectionUnionType);
```

