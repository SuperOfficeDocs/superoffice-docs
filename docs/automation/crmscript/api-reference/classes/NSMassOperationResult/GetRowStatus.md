---
uid: crmscript_ref_NSMassOperationResult_GetRowStatus
title: UpsertRowStatus[] GetRowStatus()
intellisense: NSMassOperationResult.GetRowStatus
keywords: NSMassOperationResult, GetRowStatus
so.topic: reference
---

Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null

**Returns:** UpsertRowStatus[]


```crmscript
NSMassOperationResult thing;
UpsertRowStatus[] rowStatus  = thing.GetRowStatus();
```


