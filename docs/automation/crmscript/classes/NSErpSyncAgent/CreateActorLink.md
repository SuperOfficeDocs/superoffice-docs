---
uid: crmscript_ref_NSErpSyncAgent_CreateActorLink
title: Bool CreateActorLink(Integer erpConnectionId, Integer crmRecordId, Integer crmActorType, String erpKey, Integer erpActorType)
intellisense: NSErpSyncAgent.CreateActorLink
keywords: NSErpSyncAgent, CreateActorLink
so.topic: reference
---

Link a crm entity to an erp entity

**Parameters:**
 - **erpConnectionId** The ERP connection ID
 - **crmRecordId** The ID of the CRM entity to connect to
 - **crmActorType** Identifies the CRM actor type corresponding to this CRM entity
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 
 - **erpKey** The ERP entity identifier
 - **erpActorType** The ERP actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

**Returns:** True if success

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer crmRecordId;
Integer crmActorType;
String erpKey;
Integer erpActorType;
Bool res = agent.CreateActorLink(erpConnectionId, crmRecordId, crmActorType, erpKey, erpActorType);
```

