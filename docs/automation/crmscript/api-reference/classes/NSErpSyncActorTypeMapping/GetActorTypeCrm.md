---
uid: crmscript_ref_NSErpSyncActorTypeMapping_GetActorTypeCrm
title: NSCrmActorType GetActorTypeCrm()
intellisense: NSErpSyncActorTypeMapping.GetActorTypeCrm
keywords: NSErpSyncActorTypeMapping, GetActorTypeCrm
so.topic: reference
---

# NSCrmActorType GetActorTypeCrm()

The actor type (CRM side)

**Returns:** NSCrmActorType

     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 

```crmscript
NSErpSyncActorTypeMapping thing;
NSCrmActorType actorTypeCrm  = thing.GetActorTypeCrm();
```

