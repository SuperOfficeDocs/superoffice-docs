---
uid: crmscript_ref_NSSentryAgent_GetNewTableRight
title: TableRight GetNewTableRight(String tableName)
intellisense: NSSentryAgent.GetNewTableRight
keywords: NSSentryAgent, GetNewTableRight
so.topic: reference
---

Returns a TableRight for a new row based on tableName parameter.

**Parameters:**
 - **tableName** Name of the table to get the TableRights from

**Returns:** The TableRight

```crmscript
NSSentryAgent agent;
String tableName;
TableRight res = agent.GetNewTableRight(tableName);
```

