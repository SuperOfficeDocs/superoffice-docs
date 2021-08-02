---
uid: crmscript_ref_NSBulkUpdateAgent_GetAvailableFields
title: NSFieldValueInfo[] GetAvailableFields(String tablename)
intellisense: NSBulkUpdateAgent.GetAvailableFields
keywords: NSBulkUpdateAgent, GetAvailableFields
so.topic: reference
---

Get all available fields for a given tablename/entity

**Parameters:**
 - **tablename** The name of the wanted tablename

**Returns:** NSFieldValueInfo[]

```crmscript
NSBulkUpdateAgent agent;
String tablename;
NSFieldValueInfo[] res = agent.GetAvailableFields(tablename);
```

