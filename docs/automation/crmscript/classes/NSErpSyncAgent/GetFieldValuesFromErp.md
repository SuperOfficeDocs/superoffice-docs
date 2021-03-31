---
title: crmscript_ref_NSErpSyncAgent_GetFieldValuesFromErp
description: ErpSyncFieldValueArray GetFieldValuesFromErp(Integer erpConnectionId, Integer actorTypeErp, String erpKey)
intellisense: NSErpSyncAgent.GetFieldValuesFromErp
keywords: NSErpSyncAgent,GetFieldValuesFromErp
so.topic: reference
---

Get Erp Field values

**Parameters:**
 - **erpConnectionId** Erp connection id
 - **actorTypeErp** ERP Actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 
 - **erpKey** Primary key for the erp actor

**Returns:** The Erp Fields

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer actorTypeErp;
String erpKey;
ErpSyncFieldValueArray res = agent.GetFieldValuesFromErp(erpConnectionId, actorTypeErp, erpKey);
```

