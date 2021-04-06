---
uid: crmscript_ref_NSModuleLicense_GetAllowedUserType
title: Integer GetAllowedUserType()
intellisense: NSModuleLicense.GetAllowedUserType
keywords: NSModuleLicense, GetAllowedUserType
so.topic: reference
---

Allowed associate type for user licenses: internal(0), external(4). 

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = InternalAssociate 
     - Enum: 2 = ResourceAssociate 
     - Enum: 3 = ExternalAssociate 
     - Enum: 4 = AnonymousAssociate 
     - Enum: 5 = SystemAssociate 

```crmscript
NSModuleLicense thing;
Integer allowedUserType  = thing.GetAllowedUserType();
```


