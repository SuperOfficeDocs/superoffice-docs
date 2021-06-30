---
uid: crmscript_ref_NSBulkUpdateAgent_ExecuteBySelectionId
title: Integer ExecuteBySelectionId(FieldValueInfo[] fieldValueInfos, String tableName, String context, Integer selectionId, Bool isShadow)
intellisense: NSBulkUpdateAgent.ExecuteBySelectionId
keywords: NSBulkUpdateAgent, ExecuteBySelectionId
so.topic: reference
---

Do the batchupdate on this selection

**Parameters:**
 - **fieldValueInfos** The name of the wanted tablename
 - **tableName** The name of the table to bulk update
 - **context** Where is the function called for
 - **selectionId** The id of the selection
 - **isShadow** Use the shadow selection

**Returns:** Return batchtaskinfoid

```crmscript
NSBulkUpdateAgent agent;
FieldValueInfo[] fieldValueInfos;
String tableName;
String context;
Integer selectionId;
Bool isShadow;
Integer res = agent.ExecuteBySelectionId(fieldValueInfos, tableName, context, selectionId, isShadow);
```

