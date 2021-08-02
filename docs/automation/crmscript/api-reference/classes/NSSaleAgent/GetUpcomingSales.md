---
uid: crmscript_ref_NSSaleAgent_GetUpcomingSales
title: NSSale[] GetUpcomingSales(Integer weightedAmountLimit, Integer count)
intellisense: NSSaleAgent.GetUpcomingSales
keywords: NSSaleAgent, GetUpcomingSales
so.topic: reference
---

Returns all open sales, sorted descending with the latest first.  If the weigthed amount is -1, the amount restriction is omitted.

**Parameters:**
 - **weightedAmountLimit** The amount weighted by the probability that the sale is closed (amount * probability).
 - **count** The maximum number of items to return. If -1 all are returned.

**Returns:** NSSale[]

```crmscript
NSSaleAgent agent;
Integer weightedAmountLimit;
Integer count;
NSSale[] res = agent.GetUpcomingSales(weightedAmountLimit, count);
```

