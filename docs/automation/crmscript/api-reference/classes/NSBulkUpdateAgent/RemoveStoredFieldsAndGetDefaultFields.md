---
uid: crmscript_ref_NSBulkUpdateAgent_RemoveStoredFieldsAndGetDefaultFields
title: FieldValueInfo[] RemoveStoredFieldsAndGetDefaultFields(String tableName, String context)
intellisense: NSBulkUpdateAgent.RemoveStoredFieldsAndGetDefaultFields
keywords: NSBulkUpdateAgent, RemoveStoredFieldsAndGetDefaultFields
so.topic: reference
---

Remove the stored settings of the bulk update for this table from this context, to get the default settings instead

**Parameters:**
 - **tableName** The name of the table to remove stored settings from
 - **context** Where is the function called from that we will remove the settings from

**Returns:** Returns array of the available fields for the given tablename

```crmscript
NSBulkUpdateAgent agent;
String tableName;
String context;
FieldValueInfo[] res = agent.RemoveStoredFieldsAndGetDefaultFields(tableName, context);
```

