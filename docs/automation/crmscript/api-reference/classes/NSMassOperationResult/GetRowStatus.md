---
uid: crmscript_ref_NSMassOperationResult_GetRowStatus
title: NSUpsertRowStatus[] GetRowStatus()
intellisense: NSMassOperationResult.GetRowStatus
keywords: NSMassOperationResult, GetRowStatus
so.topic: reference
---

# NSUpsertRowStatus[] GetRowStatus()

Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null

**Returns:** NSUpsertRowStatus[]

```crmscript
NSMassOperationResult thing;
NSUpsertRowStatus[] rowStatus  = thing.GetRowStatus();
```

