---
uid: crmscript_ref_NSErpSyncAgent_GetFieldsForNewErpActor
title: NSFieldMetadata[] GetFieldsForNewErpActor(Integer erpConnectionId, Integer erpActorType)
intellisense: NSErpSyncAgent.GetFieldsForNewErpActor
keywords: NSErpSyncAgent, GetFieldsForNewErpActor
so.topic: reference
---

Get the fields that must be filled out when creating a new ERP actor

**Parameters:**
 - **erpConnectionId** The id of the connection
 - **erpActorType** The type of the ERP actor to create
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

**Returns:** NSFieldMetadata[]

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer erpActorType;
NSFieldMetadata[] res = agent.GetFieldsForNewErpActor(erpConnectionId, erpActorType);
```

