---
title: crmscript_ref_NSBulkUpdateAgent_GetJobResultAsJsonFromBinaryObjectId
description: String GetJobResultAsJsonFromBinaryObjectId(String tableName, Integer binaryObjectId)
intellisense: NSBulkUpdateAgent.GetJobResultAsJsonFromBinaryObjectId
keywords: NSBulkUpdateAgent,GetJobResultAsJsonFromBinaryObjectId
so.topic: reference
---

Get result of the batchupdate job

**Parameters:**
 - **tableName** The name of the table that was updated to show the log from
 - **binaryObjectId** Which binaryobject id has stored the job result

**Returns:** Result of job as json

```crmscript
NSBulkUpdateAgent agent;
String tableName;
Integer binaryObjectId;
String res = agent.GetJobResultAsJsonFromBinaryObjectId(tableName, binaryObjectId);
```

