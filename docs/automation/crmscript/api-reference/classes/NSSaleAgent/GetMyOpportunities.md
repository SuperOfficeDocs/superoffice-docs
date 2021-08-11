---
uid: crmscript_ref_NSSaleAgent_GetMyOpportunities
title: NSSale[] GetMyOpportunities(Integer count)
intellisense: NSSaleAgent.GetMyOpportunities
keywords: NSSaleAgent, GetMyOpportunities
so.topic: reference
---

# NSSale[] GetMyOpportunities(Integer count)

Returning the opportunities (open sales) belonging to the user currently logged on

**Parameters:**
 - **count** The number of sales that is returned. -1 returns all.

**Returns:** NSSale[]

```crmscript
NSSaleAgent agent;
Integer count;
NSSale[] res = agent.GetMyOpportunities(count);
```

