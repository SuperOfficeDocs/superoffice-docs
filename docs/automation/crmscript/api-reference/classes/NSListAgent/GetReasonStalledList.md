---
uid: crmscript_ref_NSListAgent_GetReasonStalledList
title: NSReasonStalled[] GetReasonStalledList(Integer[]  reasonStalledIds);
intellisense: NSListAgent.GetReasonStalledList
keywords: NSListAgent, GetReasonStalledList
so.topic: reference
---

Gets a vector of ReasonStalled objects.

**Parameters:**
 - **reasonStalledIds** The identifiers of the NSReasonStalled objects

**Returns:** NSReasonStalled[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSReasonStalled[] res = agent.GetReasonStalledList(ids);
```

