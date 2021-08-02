---
uid: crmscript_ref_NSTaskListItem_GetDirection
title: Integer GetDirection()
intellisense: NSTaskListItem.GetDirection
keywords: NSTaskListItem, GetDirection
so.topic: reference
---

1 = incoming, 2 = outgoing, see EAppntDirection

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Incoming 
     - Enum: 2 = Outgoing 
     - Enum: 3 = SaintAll 

```crmscript
NSTaskListItem thing;
Integer direction  = thing.GetDirection();
```


