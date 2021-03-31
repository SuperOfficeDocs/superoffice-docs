---
title: crmscript_ref_NSSaleAgent_GetSaleStakeholderList
description: NSSaleStakeholder[] GetSaleStakeholderList(Integer[]  saleStakeholderIds);
intellisense: NSSaleAgent.GetSaleStakeholderList
keywords: NSSaleAgent,GetSaleStakeholderList
so.topic: reference
---

Gets a vector of SaleStakeholder objects.

**Parameters:**
 - **saleStakeholderIds** The identifiers of the NSSaleStakeholder objects

**Returns:** Vector of NSSaleStakeholder objects

```crmscript
Integer[] ids;
NSSaleAgent agent;
agent.GetSaleStakeholderList(ids);
```

