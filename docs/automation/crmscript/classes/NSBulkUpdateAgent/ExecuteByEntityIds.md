---
uid: crmscript_ref_NSBulkUpdateAgent_ExecuteByEntityIds
title: Integer ExecuteByEntityIds(FieldValueInfoArray fieldValueInfos, String tableName, String context, String ids)
intellisense: NSBulkUpdateAgent.ExecuteByEntityIds
keywords: NSBulkUpdateAgent, ExecuteByEntityIds
so.topic: reference
---

Do the batchupdate on selected

**Parameters:**
 - **fieldValueInfos** The name of the wanted tablename
 - **tableName** The name of the table to bulk update
 - **context** Where is the function called from
 - **ids** Comma separated string of the ids of the entities to update

**Returns:** Return batchtaskinfoid

```crmscript
NSBulkUpdateAgent agent;
FieldValueInfoArray fieldValueInfos;
String tableName;
String context;
String ids;
Integer res = agent.ExecuteByEntityIds(fieldValueInfos, tableName, context, ids);
```

