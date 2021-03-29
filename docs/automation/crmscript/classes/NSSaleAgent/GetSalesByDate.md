---
title: crmscript_ref_NSSaleAgent_GetSalesByDate_DateTime_p_0_DateTime_p_1_Integer_p_2_Integer_p_3
description: NSSaleAgent.GetSalesByDate(DateTime p_0, DateTime p_1, Integer p_2, Integer p_3)
intellisense: NSSaleAgent.GetSalesByDate
keywords: GetSalesByDate(DateTime,DateTime,Integer,Integer)
so.topic: reference
---


Returns all sales within a time period. The sales array can be limited by amount and status.



* **fromDate:** The beginning of the time interval.
* **toDate:** The end of the time interval.
* **amountLimit:** The amount limit in the local currency.  -1 means no amount limit
* **status:** The sale status (Lost, Open, Sold, Unknown). SaleStatus.Unknown means no status filtering.
* **Returns:** Array of sales.


