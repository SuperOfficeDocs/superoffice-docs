---
title: crmscript_ref_NSUserDefinedFieldInfoAgent_GetCustomFieldInfo
description: FieldInfoBase GetCustomFieldInfo(String tableName, String fieldName)
intellisense: NSUserDefinedFieldInfoAgent.GetCustomFieldInfo
keywords: NSUserDefinedFieldInfoAgent,GetCustomFieldInfo
so.topic: reference
---

Return information about a particular custom field (user-defined + extra) on a particular table

**Parameters:**
 - **tableName** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
 - **fieldName** The name of the field: prog:id or field name. e.g. 'SuperOffice:21' or 'x_foobar'

**Returns:** user-defined or extra field info. Describes default values, mandatory, visiblity, labels and choices.

```crmscript
NSUserDefinedFieldInfoAgent agent;
String tableName;
String fieldName;
FieldInfoBase res = agent.GetCustomFieldInfo(tableName, fieldName);
```

