---
uid: crmscript_ref_NSDatabaseTableAgent_Truncate
title: MassOperationResult Truncate(String tableName)
intellisense: NSDatabaseTableAgent.Truncate
keywords: NSDatabaseTableAgent, Truncate
so.topic: reference
---

Drop all rows in a table. This clearance is not individually logged in TravelTransactionlog or Webhook/script calls

**Parameters:**
 - **tableName** Name of table to be truncated

**Returns:** Summary of results

```crmscript
NSDatabaseTableAgent agent;
String tableName;
MassOperationResult res = agent.Truncate(tableName);
```

