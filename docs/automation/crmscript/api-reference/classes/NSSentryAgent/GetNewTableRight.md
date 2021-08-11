---
uid: crmscript_ref_NSSentryAgent_GetNewTableRight
title: NSTableRight GetNewTableRight(String tableName)
intellisense: NSSentryAgent.GetNewTableRight
keywords: NSSentryAgent, GetNewTableRight
so.topic: reference
---

# NSTableRight GetNewTableRight(String tableName)

Returns a NSTableRight for a new row based on tableName parameter.

**Parameters:**
 - **tableName** Name of the table to get the TableRights from

**Returns:** NSTableRight

```crmscript
NSSentryAgent agent;
String tableName;
NSTableRight res = agent.GetNewTableRight(tableName);
```

