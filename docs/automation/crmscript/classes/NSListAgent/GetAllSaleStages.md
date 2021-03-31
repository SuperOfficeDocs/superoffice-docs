---
title: crmscript_ref_NSListAgent_GetAllSaleStages
description: SaleStageEntityArray GetAllSaleStages(Bool includeDeleted)
intellisense: NSListAgent.GetAllSaleStages
keywords: NSListAgent,GetAllSaleStages
so.topic: reference
---

Returns all ratings

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** Array of sale stage ratings

```crmscript
NSListAgent agent;
Bool includeDeleted;
SaleStageEntityArray res = agent.GetAllSaleStages(includeDeleted);
```

