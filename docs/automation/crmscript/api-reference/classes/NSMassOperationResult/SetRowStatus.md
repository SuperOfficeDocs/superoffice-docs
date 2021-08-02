---
uid: crmscript_ref_NSMassOperationResult_SetRowStatus
title: SetRowStatus(NSUpsertRowStatus[] rowStatus)
intellisense: NSMassOperationResult.SetRowStatus
keywords: NSMassOperationResult, GetRowStatus
so.topic: reference
---

Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null

**Parameter:** 
 - **rowStatus** NSUpsertRowStatus[]

```crmscript
NSMassOperationResult thing;
NSUpsertRowStatus[] rowStatus;
thing.SetRowStatus(rowStatus);
```

