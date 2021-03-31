---
uid: crmscript_ref_NSBulkUpdateAgent_GetStoredFields
title: FieldValueInfoArray GetStoredFields(String tablename, String context)
intellisense: NSBulkUpdateAgent.GetStoredFields
keywords: NSBulkUpdateAgent, GetStoredFields
so.topic: reference
---

Get all stored fields for a given tablename/entity and context

**Parameters:**
 - **tablename** The name of the wanted tablename
 - **context** Where is the function called for

**Returns:** Returns array of the stored or default fields for the given entity

```crmscript
NSBulkUpdateAgent agent;
String tablename;
String context;
FieldValueInfoArray res = agent.GetStoredFields(tablename, context);
```

