---
title: crmscript_ref_NSErpSyncAgent_BreakActorLink
description: Bool BreakActorLink(Integer erpConnectionId, Integer crmRecordId, Integer crmActorType)
intellisense: NSErpSyncAgent.BreakActorLink
keywords: NSErpSyncAgent,BreakActorLink
so.topic: reference
---

Remove the link between a CRM entity and an ERP entity

**Parameters:**
 - **erpConnectionId** The ERP connection ID
 - **crmRecordId** The ID of the CRM entity to connect to
 - **crmActorType** Identifies the CRM actor type corresponding to this CRM entity
     - Enum: 0 = Unknown 
     - Enum: 1 = Contact 
     - Enum: 2 = Person 
     - Enum: 3 = Project 
     - Enum: 4 = Sale 

**Returns:** True if success

```crmscript
NSErpSyncAgent agent;
Integer erpConnectionId;
Integer crmRecordId;
Integer crmActorType;
Bool res = agent.BreakActorLink(erpConnectionId, crmRecordId, crmActorType);
```

