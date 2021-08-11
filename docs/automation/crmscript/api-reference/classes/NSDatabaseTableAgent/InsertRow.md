---
uid: crmscript_ref_NSDatabaseTableAgent_InsertRow
title: Integer InsertRow(String tableName, StringDictionary values)
intellisense: NSDatabaseTableAgent.InsertRow
keywords: NSDatabaseTableAgent, InsertRow
so.topic: reference
---

# Integer InsertRow(String tableName, StringDictionary values)

Insert a row into a table

**Parameters:**
 - **tableName** The name of the table to insert into; in the current release this must be an 'extratable'. Use the database name, on the form y_aTable
 - **values** A StringDictionary with the values to insert. You do not need to specify all the values in the table. The omitted ones will get default values

**Returns:** Integer

```crmscript
NSDatabaseTableAgent agent;
String tableName;
StringDictionary values;
Integer res = agent.InsertRow(tableName, values);
```

