---
uid: crmscript_ref_NSErpSyncActorTypeMapping_SetActorTypeCrm
title: SetActorTypeCrm(NSCrmActorType actorTypeCrm)
intellisense: NSErpSyncActorTypeMapping.SetActorTypeCrm
keywords: NSErpSyncActorTypeMapping, GetActorTypeCrm
so.topic: reference
---

# SetActorTypeCrm(NSCrmActorType actorTypeCrm)

The actor type (CRM side)

**Parameter:** 
 - **actorTypeCrm** NSCrmActorType
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 

```crmscript
NSErpSyncActorTypeMapping thing;
NSCrmActorType actorTypeCrm;
thing.SetActorTypeCrm(actorTypeCrm);
```

