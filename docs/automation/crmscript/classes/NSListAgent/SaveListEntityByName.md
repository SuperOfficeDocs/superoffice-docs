---
uid: crmscript_ref_NSListAgent_SaveListEntityByName
title: ListEntity SaveListEntityByName(String name, ListEntity listEntity)
intellisense: NSListAgent.SaveListEntityByName
keywords: NSListAgent, SaveListEntityByName
so.topic: reference
---

Save a ListEntity resolved by the provided name.

**Parameters:**
 - **name** The name of the list to save.
 - **listEntity** The ListEntity to save.

**Returns:** A ListEntity or null.

```crmscript
NSListAgent agent;
String name;
ListEntity listEntity;
ListEntity res = agent.SaveListEntityByName(name, listEntity);
```

