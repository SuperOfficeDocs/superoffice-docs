---
title: NSSale[] GetUpcomingSales(Integer weightedAmountLimit, Integer count)
path: /EJScript/Classes/NSSaleAgent/Member functions/NSSale[] GetUpcomingSales(Integer p_0, Integer p_1)
intellisense: 1
classref: 1
sortOrder: 6942
keywords: GetUpcomingSales(Integer,Integer)
---


Returns all open sales, sorted descending with the latest first.  If the weigthed amount is -1, the amount restriction is omitted.



* **weightedAmountLimit:** The amount weighted by the probability that the sale is closed (amount * probability).
* **count:** The maximum number of items to return. If -1 all are returned.
* **Returns:** Array of upcoming sales.


