---
uid: crmscript_ref_NSBulkUpdateAgent_GetAvailableFields
title: FieldValueInfo[] GetAvailableFields(String tablename)
intellisense: NSBulkUpdateAgent.GetAvailableFields
keywords: NSBulkUpdateAgent, GetAvailableFields
so.topic: reference
---

Get all available fields for a given tablename/entity

**Parameters:**
 - **tablename** The name of the wanted tablename

**Returns:** Returns array of the available fields for the given entity

```crmscript
NSBulkUpdateAgent agent;
String tablename;
FieldValueInfo[] res = agent.GetAvailableFields(tablename);
```

