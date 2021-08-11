---
uid: crmscript_ref_NSDocumentEntity_SetLockSemantics
title: SetLockSemantics(Integer lockSemantics)
intellisense: NSDocumentEntity.SetLockSemantics
keywords: NSDocumentEntity, GetLockSemantics
so.topic: reference
---

# SetLockSemantics(Integer lockSemantics)

**Parameter:** 
 - **lockSemantics** Integer
     - Enum: 0 = None 
     - Enum: 1 = Locking 
     - Enum: 2 = Versioning 

```crmscript
NSDocumentEntity thing;
Integer lockSemantics;
thing.SetLockSemantics(lockSemantics);
```

