---
uid: crmscript_ref_NSListAgent_GetSourceList
title: NSSource[] GetSourceList(Integer[]  sourceIds);
intellisense: NSListAgent.GetSourceList
keywords: NSListAgent, GetSourceList
so.topic: reference
---

# NSSource[] GetSourceList(Integer[]  sourceIds);

Gets a vector of Source objects.

**Parameters:**
 - **sourceIds** The identifiers of the NSSource objects

**Returns:** NSSource[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSSource[] res = agent.GetSourceList(ids);
```

