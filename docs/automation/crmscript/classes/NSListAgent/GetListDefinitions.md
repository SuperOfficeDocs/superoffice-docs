---
uid: crmscript_ref_NSListAgent_GetListDefinitions
title: ListEntityArray GetListDefinitions(Bool includeDeleted)
intellisense: NSListAgent.GetListDefinitions
keywords: NSListAgent, GetListDefinitions
so.topic: reference
---

Get a list of the lists - built-in and user-defined.

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** The list definitions

```crmscript
NSListAgent agent;
Bool includeDeleted;
ListEntityArray res = agent.GetListDefinitions(includeDeleted);
```

