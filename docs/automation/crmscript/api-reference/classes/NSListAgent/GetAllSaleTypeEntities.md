---
uid: crmscript_ref_NSListAgent_GetAllSaleTypeEntities
title: NSSaleTypeEntity[] GetAllSaleTypeEntities(Bool includeDeleted)
intellisense: NSListAgent.GetAllSaleTypeEntities
keywords: NSListAgent, GetAllSaleTypeEntities
so.topic: reference
---

# NSSaleTypeEntity[] GetAllSaleTypeEntities(Bool includeDeleted)

Returns all sale types as entities with stakeholders, guide and quote properties

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSSaleTypeEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSSaleTypeEntity[] res = agent.GetAllSaleTypeEntities(includeDeleted);
```

