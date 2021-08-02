---
uid: crmscript_ref_NSErpSyncAgent_ForceResyncExternal
title: NSPluginResponse ForceResyncExternal(Integer erpConnectionId, Integer erpActorType, String[] externalKeys)
intellisense: NSErpSyncAgent.ForceResyncExternal
keywords: NSErpSyncAgent, ForceResyncExternal
so.topic: reference
---

Force resync from CRM or given Erp connection to all other connections, using external keys

**Parameters:**
 - **erpConnectionId** Resync from the given erp connection
 - **erpActorType** Which actor type the external keys are associated with
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 
 - **externalKeys** The internal keys of the entities to resync, or empty to resync all

**Returns:** NSPluginResponse

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer erpActorType;
String[] externalKeys;
NSPluginResponse res = agent.ForceResyncExternal(erpConnectionId, erpActorType, externalKeys);
```

