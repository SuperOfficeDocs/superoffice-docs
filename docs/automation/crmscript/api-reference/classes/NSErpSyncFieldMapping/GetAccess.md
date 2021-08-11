---
uid: crmscript_ref_NSErpSyncFieldMapping_GetAccess
title: NSFieldAccess GetAccess()
intellisense: NSErpSyncFieldMapping.GetAccess
keywords: NSErpSyncFieldMapping, GetAccess
so.topic: reference
---

# NSFieldAccess GetAccess()

Access restrictions for the field

**Returns:** NSFieldAccess

     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSErpSyncFieldMapping thing;
NSFieldAccess access  = thing.GetAccess();
```

