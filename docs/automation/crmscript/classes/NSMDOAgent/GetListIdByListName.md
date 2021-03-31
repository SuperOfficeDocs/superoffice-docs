---
title: crmscript_ref_NSMDOAgent_GetListIdByListName
description: Integer GetListIdByListName(String name)
intellisense: NSMDOAgent.GetListIdByListName
keywords: NSMDOAgent,GetListIdByListName
so.topic: reference
---

Retrieve the UdListDefinition id of a list, by its name. Not all lists have such an ID, but those that are based on tables do (the list name is then the same as the table name)

**Parameters:**
 - **name** The list name, same as the table name for lists that are backed by tables

**Returns:** List id in the UdListDefinition table

```crmscript
NSMDOAgent agent;
String name;
Integer res = agent.GetListIdByListName(name);
```

