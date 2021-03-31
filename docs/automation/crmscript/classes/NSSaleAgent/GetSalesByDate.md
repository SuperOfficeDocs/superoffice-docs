---
uid: crmscript_ref_NSSaleAgent_GetSalesByDate
title: SaleArray GetSalesByDate(DateTime fromDate, DateTime toDate, Integer amountLimit, Integer status)
intellisense: NSSaleAgent.GetSalesByDate
keywords: NSSaleAgent, GetSalesByDate
so.topic: reference
---

Returns all sales within a time period. The sales array can be limited by amount and status.

**Parameters:**
 - **fromDate** The beginning of the time interval.
 - **toDate** The end of the time interval.
 - **amountLimit** The amount limit in the local currency.  -1 means no amount limit
 - **status** The sale status (Lost, Open, Sold, Unknown). SaleStatus.Unknown means no status filtering.
     - Enum: 0 = Unknown 
     - Enum: 1 = Open 
     - Enum: 2 = Sold 
     - Enum: 3 = Lost 
     - Enum: 4 = Stalled 
     - Enum: 1000 = SaintAll 

**Returns:** Array of sales.

```crmscript
NSSaleAgent agent;
DateTime fromDate;
DateTime toDate;
Integer amountLimit;
Integer status;
SaleArray res = agent.GetSalesByDate(fromDate, toDate, amountLimit, status);
```

