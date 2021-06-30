---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetCustomFieldInfoList
title: FieldInfoBase[] GetCustomFieldInfoList(String tableName, Bool includeStandard)
intellisense: NSUserDefinedFieldInfoAgent.GetCustomFieldInfoList
keywords: NSUserDefinedFieldInfoAgent, GetCustomFieldInfoList
so.topic: reference
---

Return information about all the custom fields (user-defined + extra) on a particular table

**Parameters:**
 - **tableName** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
 - **includeStandard** Include standard fields in result. Default false.

**Returns:** Array of user-defined and extra field info in rank order. Describes default values, mandatory, visiblity, labels and choices.

```crmscript
NSUserDefinedFieldInfoAgent agent;
String tableName;
Bool includeStandard;
FieldInfoBase[] res = agent.GetCustomFieldInfoList(tableName, includeStandard);
```

