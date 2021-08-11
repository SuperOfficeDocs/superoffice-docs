---
uid: crmscript_ref_NSListAgent_GetCompetitorList
title: NSCompetitor[] GetCompetitorList(Integer[]  competitorIds);
intellisense: NSListAgent.GetCompetitorList
keywords: NSListAgent, GetCompetitorList
so.topic: reference
---

# NSCompetitor[] GetCompetitorList(Integer[]  competitorIds);

Gets a vector of NSCompetitor objects.

**Parameters:**
 - **competitorIds** The identifiers of the NSCompetitor objects

**Returns:** NSCompetitor[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCompetitor[] res = agent.GetCompetitorList(ids);
```

