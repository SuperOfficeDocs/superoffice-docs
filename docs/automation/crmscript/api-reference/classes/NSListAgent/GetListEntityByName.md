---
uid: crmscript_ref_NSListAgent_GetListEntityByName
title: NSListEntity GetListEntityByName(String name)
intellisense: NSListAgent.GetListEntityByName
keywords: NSListAgent, GetListEntityByName
so.topic: reference
---

Gets a NSListEntity resolved by the provided name.

**Parameters:**
 - **name** The name of the list to look up.

**Returns:** NSListEntity

```crmscript
NSListAgent agent;
String name;
NSListEntity res = agent.GetListEntityByName(name);
```

