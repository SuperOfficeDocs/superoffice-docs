---
title: crmscript_ref_NSUserAgent_GetDataRights
description: StringDictionary GetDataRights(Integer roleId, String tableName)
intellisense: NSUserAgent.GetDataRights
keywords: NSUserAgent,GetDataRights
so.topic: reference
---

Read specific a set of data rights at the given row in the rights matrix. An exception will be thrown if non existing position is specified.

**Parameters:**
 - **roleId** The role id to set the data right for
 - **tableName** The name of the entity/table

**Returns:** The data right values for all the defined relationships (C, CR, CRU, or CRUD)

```crmscript
NSUserAgent agent;
Integer roleId;
String tableName;
StringDictionary res = agent.GetDataRights(roleId, tableName);
```

