---
uid: crmscript_ref_NSDatabaseTableAgent_Insert
title: MassOperationResult Insert(String tableName, StringArray columns, StringArrayArray data)
intellisense: NSDatabaseTableAgent.Insert
keywords: NSDatabaseTableAgent, Insert
so.topic: reference
---

Mass-insert rows, with or without primary keys specified. Works on physical tables with no special processing for udef etc.; traveltransactionlog and WebHooks are supported

**Parameters:**
 - **tableName** The name of the table where rows should be inserted
 - **columns** List of column names, in the same order as in the Data parameter
 - **data** Outer array = rows, inner = columns in specified order; use CultureDataFormatter to format values that aren't string or int

**Returns:** Summary of results

```crmscript
NSDatabaseTableAgent agent;
String tableName;
StringArray columns;
StringArrayArray data;
MassOperationResult res = agent.Insert(tableName, columns, data);
```

