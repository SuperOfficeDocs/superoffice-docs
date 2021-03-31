---
title: crmscript_ref_NSListAgent_GetAllSaleTypeEntities
description: SaleTypeEntityArray GetAllSaleTypeEntities(Bool includeDeleted)
intellisense: NSListAgent.GetAllSaleTypeEntities
keywords: NSListAgent,GetAllSaleTypeEntities
so.topic: reference
---

Returns all sale types as entities with stakeholders, guide and quote properties

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** Array of sale type entities with stakeholders, guide and quote properties

```crmscript
NSListAgent agent;
Bool includeDeleted;
SaleTypeEntityArray res = agent.GetAllSaleTypeEntities(includeDeleted);
```

