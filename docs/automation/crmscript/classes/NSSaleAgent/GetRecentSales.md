---
title: crmscript_ref_NSSaleAgent_GetRecentSales_Integer_p_0_Integer_p_1
description: NSSaleAgent.GetRecentSales(Integer p_0, Integer p_1)
intellisense: NSSaleAgent.GetRecentSales
keywords: GetRecentSales(Integer,Integer)
so.topic: reference
---


Returns the latest sales (that are sold) limited by their amount. The result is sorted descending with the latest first. If the amount is -1, the amount restriction is omitted.



* **amountLimit:** The amount limit in the local currency.
* **count:** The maximum number of items to return. If -1 all are returned.
* **Returns:** Array of all recent sales.


