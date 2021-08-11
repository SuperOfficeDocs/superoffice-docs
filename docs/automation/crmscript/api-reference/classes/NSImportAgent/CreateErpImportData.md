---
uid: crmscript_ref_NSImportAgent_CreateErpImportData
title: NSImportErpData CreateErpImportData(NSArchiveRestrictionInfo[] restriction, String[] columns, Integer connectionId, Integer erpActorType)
intellisense: NSImportAgent.CreateErpImportData
keywords: NSImportAgent, CreateErpImportData
so.topic: reference
---

# NSImportErpData CreateErpImportData(NSArchiveRestrictionInfo[] restriction, String[] columns, Integer connectionId, Integer erpActorType)

Populates the ImportLines and columnDefs basedfrom erp system

**Parameters:**
 - **restriction** Archive restrictions.
 - **columns** Columns.
 - **connectionId** Connection id for Erp system
 - **erpActorType** Erp Actor type
     - Enum: 0 = Unknown 
     - Enum: 1 = Customer 
     - Enum: 2 = Supplier 
     - Enum: 3 = Partner 
     - Enum: 4 = Person 
     - Enum: 5 = Project 
     - Enum: 6 = Employee 
     - Enum: 7 = Sale 

**Returns:** NSImportErpData

```crmscript
NSImportAgent agent;
NSArchiveRestrictionInfo[] restriction;
String[] columns;
Integer connectionId;
Integer erpActorType;
NSImportErpData res = agent.CreateErpImportData(restriction, columns, connectionId, erpActorType);
```

