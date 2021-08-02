---
uid: crmscript_ref_NSUserAgent_GetDataRights
title: StringDictionary GetDataRights(Integer roleId, String tableName)
intellisense: NSUserAgent.GetDataRights
keywords: NSUserAgent, GetDataRights
so.topic: reference
---

Read specific a set of data rights at the given row in the rights matrix. An exception will be thrown if non existing position is specified.

**Parameters:**
 - **roleId** The role id to set the data right for
 - **tableName** The name of the entity/table

**Returns:** StringDictionary

```crmscript
NSUserAgent agent;
Integer roleId;
String tableName;
StringDictionary res = agent.GetDataRights(roleId, tableName);
```

