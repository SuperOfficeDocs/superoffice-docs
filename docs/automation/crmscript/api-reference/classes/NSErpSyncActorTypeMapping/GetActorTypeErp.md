---
uid: crmscript_ref_NSErpSyncActorTypeMapping_GetActorTypeErp
title: NSErpActorType GetActorTypeErp()
intellisense: NSErpSyncActorTypeMapping.GetActorTypeErp
keywords: NSErpSyncActorTypeMapping, GetActorTypeErp
so.topic: reference
---

# NSErpActorType GetActorTypeErp()

The actor type (ERP side)

**Returns:** NSErpActorType

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
NSErpActorType actorTypeErp  = thing.GetActorTypeErp();
```

