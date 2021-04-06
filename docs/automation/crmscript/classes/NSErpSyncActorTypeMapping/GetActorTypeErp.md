---
uid: crmscript_ref_NSErpSyncActorTypeMapping_GetActorTypeErp
title: ErpActorType GetActorTypeErp()
intellisense: NSErpSyncActorTypeMapping.GetActorTypeErp
keywords: NSErpSyncActorTypeMapping, GetActorTypeErp
so.topic: reference
---

The actor type (ERP side)

**Returns:** ErpActorType

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
ErpActorType actorTypeErp  = thing.GetActorTypeErp();
```


