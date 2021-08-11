---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetCustomFieldInfo
title: NSFieldInfoBase GetCustomFieldInfo(String tableName, String fieldName)
intellisense: NSUserDefinedFieldInfoAgent.GetCustomFieldInfo
keywords: NSUserDefinedFieldInfoAgent, GetCustomFieldInfo
so.topic: reference
---

# NSFieldInfoBase GetCustomFieldInfo(String tableName, String fieldName)

Return information about a particular custom field (user-defined + extra) on a particular table

**Parameters:**
 - **tableName** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
 - **fieldName** The name of the field: prog:id or field name. e.g. 'SuperOffice:21' or 'x_foobar'

**Returns:** NSFieldInfoBase

```crmscript
NSUserDefinedFieldInfoAgent agent;
String tableName;
String fieldName;
NSFieldInfoBase res = agent.GetCustomFieldInfo(tableName, fieldName);
```

