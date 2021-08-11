---
uid: crmscript_ref_NSErpSyncDefaultValue_GetAccess
title: NSFieldAccess GetAccess()
intellisense: NSErpSyncDefaultValue.GetAccess
keywords: NSErpSyncDefaultValue, GetAccess
so.topic: reference
---

# NSFieldAccess GetAccess()

Access restrictions for the field

**Returns:** NSFieldAccess

     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSErpSyncDefaultValue thing;
NSFieldAccess access  = thing.GetAccess();
```

