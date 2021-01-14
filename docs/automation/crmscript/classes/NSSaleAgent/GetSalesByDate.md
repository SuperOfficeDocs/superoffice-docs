---
title: NSSale[] GetSalesByDate(DateTime fromDate, DateTime toDate, Integer amountLimit, Integer status)
path: /EJScript/Classes/NSSaleAgent/Member functions/NSSale[] GetSalesByDate(DateTime p_0, DateTime p_1, Integer p_2, Integer p_3)
intellisense: 1
classref: 1
sortOrder: 6941
keywords: GetSalesByDate(DateTime,DateTime,Integer,Integer)
---


Returns all sales within a time period. The sales array can be limited by amount and status.



* **fromDate:** The beginning of the time interval.
* **toDate:** The end of the time interval.
* **amountLimit:** The amount limit in the local currency.  -1 means no amount limit
* **status:** The sale status (Lost, Open, Sold, Unknown). SaleStatus.Unknown means no status filtering.
* **Returns:** Array of sales.


