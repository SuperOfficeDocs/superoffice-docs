---
uid: crmscript_ref_NSErpSyncActorTypeMapping_SetActorTypeErp
title: SetActorTypeErp(ErpActorType actorTypeErp)
intellisense: NSErpSyncActorTypeMapping.SetActorTypeErp
keywords: NSErpSyncActorTypeMapping, GetActorTypeErp
so.topic: reference
---

The actor type (ERP side)

**Parameter:** 
 - **actorTypeErp** ErpActorType
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
ErpActorType actorTypeErp;
thing.SetActorTypeErp(actorTypeErp);
```

