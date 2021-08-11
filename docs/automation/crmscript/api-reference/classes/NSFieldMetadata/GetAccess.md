---
uid: crmscript_ref_NSFieldMetadata_GetAccess
title: Integer GetAccess()
intellisense: NSFieldMetadata.GetAccess
keywords: NSFieldMetadata, GetAccess
so.topic: reference
---

# Integer GetAccess()

Access restrictions on the field

**Returns:** Integer

     - Enum: 0 = Normal 
     - Enum: 1 = Mandatory 
     - Enum: 2 = ReadOnly 

```crmscript
NSFieldMetadata thing;
Integer access  = thing.GetAccess();
```

