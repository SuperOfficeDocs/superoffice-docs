---
uid: crmscript_ref_NSErpSyncAgent_GetConnectionsAndDisplayFields
title: NSErpConnectionData[] GetConnectionsAndDisplayFields(Integer crmActorType, Integer entityId)
intellisense: NSErpSyncAgent.GetConnectionsAndDisplayFields
keywords: NSErpSyncAgent, GetConnectionsAndDisplayFields
so.topic: reference
---

# NSErpConnectionData[] GetConnectionsAndDisplayFields(Integer crmActorType, Integer entityId)

Get all connection statuses and fields for a given entity

**Parameters:**
 - **crmActorType** The type of the CRM entity
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
 - **entityId** The id of the entity

**Returns:** NSErpConnectionData[]

```crmscript
NSErpSyncAgent agent;
Integer crmActorType;
Integer entityId;
NSErpConnectionData[] res = agent.GetConnectionsAndDisplayFields(crmActorType, entityId);
```

