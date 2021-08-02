---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetCustomFieldInfoList
title: NSFieldInfoBase[] GetCustomFieldInfoList(String tableName, Bool includeStandard)
intellisense: NSUserDefinedFieldInfoAgent.GetCustomFieldInfoList
keywords: NSUserDefinedFieldInfoAgent, GetCustomFieldInfoList
so.topic: reference
---

Return information about all the custom fields (user-defined + extra) on a particular table

**Parameters:**
 - **tableName** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
 - **includeStandard** Include standard fields in result. Default false.

**Returns:** NSFieldInfoBase[]

```crmscript
NSUserDefinedFieldInfoAgent agent;
String tableName;
Bool includeStandard;
NSFieldInfoBase[] res = agent.GetCustomFieldInfoList(tableName, includeStandard);
```

