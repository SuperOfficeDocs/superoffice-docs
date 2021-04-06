---
uid: crmscript_ref_NSUserDefinedFieldInfo_SetJustification
title: SetJustification(UdefJustification justification)
intellisense: NSUserDefinedFieldInfo.SetJustification
keywords: NSUserDefinedFieldInfo, GetJustification
so.topic: reference
---

Justification - 0 = default, left, right, center

**Parameter:** 
 - **justification** UdefJustification
     - Enum: 0 = Default 
     - Enum: 1 = Left 
     - Enum: 2 = Center 
     - Enum: 3 = Right 

```crmscript
NSUserDefinedFieldInfo thing;
UdefJustification justification;
thing.SetJustification(justification);
```

