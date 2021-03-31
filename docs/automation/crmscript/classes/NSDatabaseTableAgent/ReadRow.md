---
title: crmscript_ref_NSDatabaseTableAgent_ReadRow
description: TableRecord ReadRow(String tableName, Integer id)
intellisense: NSDatabaseTableAgent.ReadRow
keywords: NSDatabaseTableAgent,ReadRow
so.topic: reference
---

Read a row from a table

**Parameters:**
 - **tableName** The name of the table to fetch; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable
 - **id** The id of the row to fetch

**Returns:** The row from the table

```crmscript
NSDatabaseTableAgent agent;
String tableName;
Integer id;
TableRecord res = agent.ReadRow(tableName, id);
```

