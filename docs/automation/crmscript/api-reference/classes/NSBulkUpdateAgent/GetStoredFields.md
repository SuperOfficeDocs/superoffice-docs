---
uid: crmscript_ref_NSBulkUpdateAgent_GetStoredFields
title: NSFieldValueInfo[] GetStoredFields(String tablename, String context)
intellisense: NSBulkUpdateAgent.GetStoredFields
keywords: NSBulkUpdateAgent, GetStoredFields
so.topic: reference
---

# NSFieldValueInfo[] GetStoredFields(String tablename, String context)

Get all stored fields for a given tablename/entity and context

**Parameters:**
 - **tablename** The name of the wanted tablename
 - **context** Where is the function called for

**Returns:** NSFieldValueInfo[]

```crmscript
NSBulkUpdateAgent agent;
String tablename;
String context;
NSFieldValueInfo[] res = agent.GetStoredFields(tablename, context);
```

