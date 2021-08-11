---
uid: crmscript_ref_NSRoleEntity_GetRoleType
title: Integer GetRoleType()
intellisense: NSRoleEntity.GetRoleType
keywords: NSRoleEntity, GetRoleType
so.topic: reference
---

# Integer GetRoleType()

The role type. Note that changing this field has no effect, so treat this as a read-only field. 

**Returns:** Integer

     - Enum: 0 = Employee 
     - Enum: 1 = ExternalUser 
     - Enum: 2 = Anonymous 
     - Enum: 3 = System 

```crmscript
NSRoleEntity thing;
Integer roleType  = thing.GetRoleType();
```

