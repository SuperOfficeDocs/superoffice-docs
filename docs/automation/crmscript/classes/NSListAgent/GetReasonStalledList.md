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

**Returns:** Vector of NSReasonStalled objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetReasonStalledList(ids);
```

