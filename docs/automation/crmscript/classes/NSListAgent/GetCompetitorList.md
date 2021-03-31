---
uid: crmscript_ref_NSListAgent_GetCompetitorList
title: NSCompetitor[] GetCompetitorList(Integer[]  competitorIds);
intellisense: NSListAgent.GetCompetitorList
keywords: NSListAgent, GetCompetitorList
so.topic: reference
---

Gets a vector of Competitor objects.

**Parameters:**
 - **competitorIds** The identifiers of the NSCompetitor objects

**Returns:** Vector of NSCompetitor objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetCompetitorList(ids);
```

