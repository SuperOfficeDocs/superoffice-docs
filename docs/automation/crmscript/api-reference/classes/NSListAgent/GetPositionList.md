---
uid: crmscript_ref_NSListAgent_GetPositionList
title: NSPosition[] GetPositionList(Integer[]  positionIds);
intellisense: NSListAgent.GetPositionList
keywords: NSListAgent, GetPositionList
so.topic: reference
---

Gets a vector of NSPosition objects.

**Parameters:**
 - **positionIds** The identifiers of the NSPosition objects

**Returns:** NSPosition[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSPosition[] res = agent.GetPositionList(ids);
```

