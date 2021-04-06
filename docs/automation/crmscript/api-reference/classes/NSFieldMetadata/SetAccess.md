---
uid: crmscript_ref_NSFieldMetadata_SetAccess
title: SetAccess(Integer access)
intellisense: NSFieldMetadata.SetAccess
keywords: NSFieldMetadata, GetAccess
so.topic: reference
---

Access restrictions on the field

**Parameter:** 
 - **access** Integer
     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSFieldMetadata thing;
Integer access;
thing.SetAccess(access);
```

