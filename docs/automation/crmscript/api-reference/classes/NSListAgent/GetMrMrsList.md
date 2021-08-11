---
uid: crmscript_ref_NSListAgent_GetMrMrsList
title: NSMrMrs[] GetMrMrsList(Integer[]  mrMrsIds);
intellisense: NSListAgent.GetMrMrsList
keywords: NSListAgent, GetMrMrsList
so.topic: reference
---

# NSMrMrs[] GetMrMrsList(Integer[]  mrMrsIds);

Gets a vector of NSMrMrs objects.

**Parameters:**
 - **mrMrsIds** The identifiers of the NSMrMrs objects

**Returns:** NSMrMrs[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSMrMrs[] res = agent.GetMrMrsList(ids);
```

