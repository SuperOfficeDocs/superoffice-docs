---
uid: crmscript_ref_NSPreference_GetTableName
title: String GetTableName()
intellisense: NSPreference.GetTableName
keywords: NSPreference, GetTableName
so.topic: reference
---

# String GetTableName()

For DisplayType=PrefDescValueType.ListTableRef, TableName will contain the name of the table which the value reference to.

**Returns:** String

```crmscript
NSPreference thing;
String tableName  = thing.GetTableName();
```

