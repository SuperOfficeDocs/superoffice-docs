---
uid: crmscript_ref_NSDatabaseTableAgent_Delete
title: NSMassOperationResult Delete(String tableName, Integer[] iDs)
intellisense: NSDatabaseTableAgent.Delete
keywords: NSDatabaseTableAgent, Delete
so.topic: reference
---

Delete rows, by primary key; traveltransactionlog and WebHooks are supported

**Parameters:**
 - **tableName** The name of the table where rows should be deleted
 - **iDs** Primary keys of the rows to be deleted

**Returns:** NSMassOperationResult

```crmscript
NSDatabaseTableAgent agent;
String tableName;
Integer[] iDs;
NSMassOperationResult res = agent.Delete(tableName, iDs);
```

