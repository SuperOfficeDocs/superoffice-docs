---
uid: crmscript_ref_NSUserDefinedFieldInfo_GetJustification
title: UdefJustification GetJustification()
intellisense: NSUserDefinedFieldInfo.GetJustification
keywords: NSUserDefinedFieldInfo, GetJustification
so.topic: reference
---

# UdefJustification GetJustification()

Justification - 0 = default, left, right, center

**Returns:** UdefJustification

     - Enum: 0 = Default 
     - Enum: 1 = Left 
     - Enum: 2 = Center 
     - Enum: 3 = Right 

```crmscript
NSUserDefinedFieldInfo thing;
UdefJustification justification  = thing.GetJustification();
```

