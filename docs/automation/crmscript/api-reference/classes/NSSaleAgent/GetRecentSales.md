---
uid: crmscript_ref_NSSaleAgent_GetRecentSales
title: Sale[] GetRecentSales(Integer amountLimit, Integer count)
intellisense: NSSaleAgent.GetRecentSales
keywords: NSSaleAgent, GetRecentSales
so.topic: reference
---

Returns the latest sales (that are sold) limited by their amount. The result is sorted descending with the latest first. If the amount is -1, the amount restriction is omitted.

**Parameters:**
 - **amountLimit** The amount limit in the local currency.
 - **count** The maximum number of items to return. If -1 all are returned.

**Returns:** Array of all recent sales.

```crmscript
NSSaleAgent agent;
Integer amountLimit;
Integer count;
Sale[] res = agent.GetRecentSales(amountLimit, count);
```

