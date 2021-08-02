---
uid: crmscript_ref_NSListAgent_GetLinkList
title: NSLink[] GetLinkList(Integer[]  linkIds);
intellisense: NSListAgent.GetLinkList
keywords: NSListAgent, GetLinkList
so.topic: reference
---

Gets a vector of Link objects.

**Parameters:**
 - **linkIds** The identifiers of the NSLink objects

**Returns:** NSLink[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSLink[] res = agent.GetLinkList(ids);
```

