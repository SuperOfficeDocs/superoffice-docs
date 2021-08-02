---
uid: crmscript_ref_NSListAgent_GetListDefinitions
title: NSListEntity[] GetListDefinitions(Bool includeDeleted)
intellisense: NSListAgent.GetListDefinitions
keywords: NSListAgent, GetListDefinitions
so.topic: reference
---

Get a list of the lists - built-in and user-defined.

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSListEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSListEntity[] res = agent.GetListDefinitions(includeDeleted);
```

