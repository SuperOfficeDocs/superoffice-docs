---
uid: crmscript_ref_NSErpSyncDefaultValue_GetAccess
title: FieldAccess GetAccess()
intellisense: NSErpSyncDefaultValue.GetAccess
keywords: NSErpSyncDefaultValue, GetAccess
so.topic: reference
---

Access restrictions for the field

**Returns:** FieldAccess

     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSErpSyncDefaultValue thing;
FieldAccess access  = thing.GetAccess();
```


