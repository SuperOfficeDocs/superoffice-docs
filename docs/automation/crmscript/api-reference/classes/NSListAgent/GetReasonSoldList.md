---
uid: crmscript_ref_NSListAgent_GetReasonSoldList
title: NSReasonSold[] GetReasonSoldList(Integer[]  reasonSoldIds);
intellisense: NSListAgent.GetReasonSoldList
keywords: NSListAgent, GetReasonSoldList
so.topic: reference
---

Gets a vector of ReasonSold objects.

**Parameters:**
 - **reasonSoldIds** The identifiers of the NSReasonSold objects

**Returns:** NSReasonSold[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSReasonSold[] res = agent.GetReasonSoldList(ids);
```

