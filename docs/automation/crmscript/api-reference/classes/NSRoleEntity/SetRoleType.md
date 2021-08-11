---
uid: crmscript_ref_NSRoleEntity_SetRoleType
title: SetRoleType(Integer roleType)
intellisense: NSRoleEntity.SetRoleType
keywords: NSRoleEntity, GetRoleType
so.topic: reference
---

# SetRoleType(Integer roleType)

The role type. Note that changing this field has no effect, so treat this as a read-only field. 

**Parameter:** 
 - **roleType** Integer
     - Enum: 0 = Employee 
     - Enum: 1 = ExternalUser 
     - Enum: 2 = Anonymous 
     - Enum: 3 = System 

```crmscript
NSRoleEntity thing;
Integer roleType;
thing.SetRoleType(roleType);
```

