---
uid: crmscript_ref_NSErpSyncActorTypeMapping_SetActorTypeErp
title: SetActorTypeErp(NSErpActorType actorTypeErp)
intellisense: NSErpSyncActorTypeMapping.SetActorTypeErp
keywords: NSErpSyncActorTypeMapping, GetActorTypeErp
so.topic: reference
---

# SetActorTypeErp(NSErpActorType actorTypeErp)

The actor type (ERP side)

**Parameter:** 
 - **actorTypeErp** NSErpActorType
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

```crmscript
NSErpSyncActorTypeMapping thing;
NSErpActorType actorTypeErp;
thing.SetActorTypeErp(actorTypeErp);
```

