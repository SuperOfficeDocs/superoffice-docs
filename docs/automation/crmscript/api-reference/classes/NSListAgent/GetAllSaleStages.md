---
uid: crmscript_ref_NSListAgent_GetAllSaleStages
title: NSSaleStageEntity[] GetAllSaleStages(Bool includeDeleted)
intellisense: NSListAgent.GetAllSaleStages
keywords: NSListAgent, GetAllSaleStages
so.topic: reference
---

# NSSaleStageEntity[] GetAllSaleStages(Bool includeDeleted)

Returns all ratings

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSSaleStageEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSSaleStageEntity[] res = agent.GetAllSaleStages(includeDeleted);
```

