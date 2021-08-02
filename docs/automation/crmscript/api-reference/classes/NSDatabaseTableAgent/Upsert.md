---
uid: crmscript_ref_NSDatabaseTableAgent_Upsert
title: NSMassOperationResult Upsert(String tableName, String[] columns, String[] keys, String[] data, Integer nomatchAction, Bool returnRowStatus)
intellisense: NSDatabaseTableAgent.Upsert
keywords: NSDatabaseTableAgent, Upsert
so.topic: reference
---

Insert or update rows, optionally deleting/zeroing 'leftover' rows. Special support for UDEF, as well as optional extensive information return. Traveltransactionlog and WebHooks are supported

**Parameters:**
 - **tableName** The name of the table where rows should be inserted or updated
 - **columns** List of column names, in the same order as in the data
 - **keys** List of columns that are to be used as keys, to match any existing rows
 - **data** Outer array = row, inner = column in specified order; use CultureDataFormatter to format values
 - **nomatchAction** Action to take on rows in the target table, that are not matched by any rows in the incoming data. Use the deletion options with care. NEVER use deletion if your Upsert is so large you need to divide it into multiple batches.
     - Enum: 0 = NoChange 
     - Enum: 1 = ZeroColumns 
     - Enum: 2 = DeleteRow 
 - **returnRowStatus** If true, then the 'RowStatus' member of the return carrier will be populated with a per-row status, for each incoming row

**Returns:** NSMassOperationResult

```crmscript
NSDatabaseTableAgent agent;
String tableName;
String[] columns;
String[] keys;
String[] data;
Integer nomatchAction;
Bool returnRowStatus;
NSMassOperationResult res = agent.Upsert(tableName, columns, keys, data, nomatchAction, returnRowStatus);
```

