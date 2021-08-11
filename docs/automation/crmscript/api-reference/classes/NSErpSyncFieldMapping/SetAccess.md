---
uid: crmscript_ref_NSErpSyncFieldMapping_SetAccess
title: SetAccess(NSFieldAccess access)
intellisense: NSErpSyncFieldMapping.SetAccess
keywords: NSErpSyncFieldMapping, GetAccess
so.topic: reference
---

# SetAccess(NSFieldAccess access)

Access restrictions for the field

**Parameter:** 
 - **access** NSFieldAccess
     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSErpSyncFieldMapping thing;
NSFieldAccess access;
thing.SetAccess(access);
```

