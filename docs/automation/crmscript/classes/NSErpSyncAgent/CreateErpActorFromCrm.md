---
title: crmscript_ref_NSErpSyncAgent_CreateErpActorFromCrm
description: Bool CreateErpActorFromCrm(Integer connectionId, Integer crmEntityId, Integer erpActorType, Integer crmActorType, StringDictionary erpFieldKeyValues)
intellisense: NSErpSyncAgent.CreateErpActorFromCrm
keywords: NSErpSyncAgent,CreateErpActorFromCrm
so.topic: reference
---

Create ErpActor from crm entity

**Parameters:**
 - **connectionId** The connection ID
 - **crmEntityId** The ID of the CRM entity to create an ERP actor from
 - **erpActorType** The ERP actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 
 - **crmActorType** The CRM actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
 - **erpFieldKeyValues** A map of matching erp field keys and values to set for the new erp entity

**Returns:** Created ERP actor with success

```crmscript
NSErpSyncAgent agent;
Integer connectionId;
Integer crmEntityId;
Integer erpActorType;
Integer crmActorType;
StringDictionary erpFieldKeyValues;
Bool res = agent.CreateErpActorFromCrm(connectionId, crmEntityId, erpActorType, crmActorType, erpFieldKeyValues);
```

