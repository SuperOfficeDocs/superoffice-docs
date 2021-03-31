---
title: crmscript_ref_NSErpSyncAgent_SupportsAdvancedSearch
description: Bool SupportsAdvancedSearch(Integer erpConnectionId, Integer erpActorType)
intellisense: NSErpSyncAgent.SupportsAdvancedSearch
keywords: NSErpSyncAgent,SupportsAdvancedSearch
so.topic: reference
---

Indicates if the connection supports advanced search for the given erp actor

**Parameters:**
 - **erpConnectionId** Ths id of the connection
 - **erpActorType** The erp actor type to check for
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

**Returns:** True if advanced search is supported

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer erpActorType;
Bool res = agent.SupportsAdvancedSearch(erpConnectionId, erpActorType);
```

