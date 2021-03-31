---
uid: crmscript_ref_NSListAgent_GetListEntityByName
title: ListEntity GetListEntityByName(String name)
intellisense: NSListAgent.GetListEntityByName
keywords: NSListAgent, GetListEntityByName
so.topic: reference
---

Gets a ListEntity resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.

**Returns:** A ListEntity or null.

```crmscript
NSListAgent agent;
String name;
ListEntity res = agent.GetListEntityByName(name);
```

