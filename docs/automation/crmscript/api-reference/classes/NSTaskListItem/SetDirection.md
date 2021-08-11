---
uid: crmscript_ref_NSTaskListItem_SetDirection
title: SetDirection(Integer direction)
intellisense: NSTaskListItem.SetDirection
keywords: NSTaskListItem, GetDirection
so.topic: reference
---

# SetDirection(Integer direction)

1 = incoming, 2 = outgoing, see EAppntDirection

**Parameter:** 
 - **direction** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Incoming 
     - Enum: 2 = Outgoing 
     - Enum: 3 = SaintAll 

```crmscript
NSTaskListItem thing;
Integer direction;
thing.SetDirection(direction);
```

