---
uid: crmscript_ref_NSErpSyncActorSummary_SetActorType
title: SetActorType(Integer actorType)
intellisense: NSErpSyncActorSummary.SetActorType
keywords: NSErpSyncActorSummary, GetActorType
so.topic: reference
---

# SetActorType(Integer actorType)

Actor type

**Parameter:** 
 - **actorType** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

```crmscript
NSErpSyncActorSummary thing;
Integer actorType;
thing.SetActorType(actorType);
```

