---
title: crmscript_ref_NSErpSyncAgent_GetActorTypeMapping
description: ErpSyncActorTypeMapping GetActorTypeMapping(Integer erpConnectionId, Integer actorType)
intellisense: NSErpSyncAgent.GetActorTypeMapping
keywords: NSErpSyncAgent,GetActorTypeMapping
so.topic: reference
---

Get the current mappings for one connection/actor; connection+actor type = unique key

**Parameters:**
 - **erpConnectionId** The ERP connection ID
 - **actorType** The actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

**Returns:** The current mapping from the database

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer actorType;
ErpSyncActorTypeMapping res = agent.GetActorTypeMapping(erpConnectionId, actorType);
```

