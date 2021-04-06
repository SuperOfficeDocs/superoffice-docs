---
uid: crmscript_ref_NSMassOperationResult_GetRowStatus
title: UpsertRowStatusArray GetRowStatus()
intellisense: NSMassOperationResult.GetRowStatus
keywords: NSMassOperationResult, GetRowStatus
so.topic: reference
---

Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null

**Returns:** UpsertRowStatusArray


```crmscript
NSMassOperationResult thing;
UpsertRowStatusArray rowStatus  = thing.GetRowStatus();
```


