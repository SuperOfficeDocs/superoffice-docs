---
uid: crmscript_ref_NSErpSyncAgent_GetConnectionsAndDisplayFields
title: ErpConnectionDataArray GetConnectionsAndDisplayFields(Integer crmActorType, Integer entityId)
intellisense: NSErpSyncAgent.GetConnectionsAndDisplayFields
keywords: NSErpSyncAgent, GetConnectionsAndDisplayFields
so.topic: reference
---

Get all connection statuses and fields for a given entity

**Parameters:**
 - **crmActorType** The type of the CRM entity
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
 - **entityId** The id of the entity

**Returns:** An array of ErpConnectionData carriers

```crmscript
NSErpSyncAgent agent;
Integer crmActorType;
Integer entityId;
ErpConnectionDataArray res = agent.GetConnectionsAndDisplayFields(crmActorType, entityId);
```

