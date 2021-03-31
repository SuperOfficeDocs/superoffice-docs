---
title: crmscript_ref_NSErpSyncAgent_GetFieldValuesFromCrm
description: ErpSyncFieldValueArray GetFieldValuesFromCrm(Integer recordId, Integer actorTypeCrm)
intellisense: NSErpSyncAgent.GetFieldValuesFromCrm
keywords: NSErpSyncAgent,GetFieldValuesFromCrm
so.topic: reference
---

Get Crm Field values

**Parameters:**
 - **recordId** The id of the CRM entity
 - **actorTypeCrm** CRM Actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 

**Returns:** The Crm Fields

```crmscript
NSErpSyncAgent agent;
Integer recordId;
Integer actorTypeCrm;
ErpSyncFieldValueArray res = agent.GetFieldValuesFromCrm(recordId, actorTypeCrm);
```

