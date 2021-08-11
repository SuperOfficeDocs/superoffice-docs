---
uid: crmscript_ref_NSListAgent_SaveSaleTypeEntity
title: NSSaleTypeEntity SaveSaleTypeEntity(NSSaleTypeEntity saleTypeEntity);
intellisense: NSListAgent.SaveSaleTypeEntity
keywords: NSListAgent, SaveSaleTypeEntity
so.topic: reference
---

# NSSaleTypeEntity SaveSaleTypeEntity(NSSaleTypeEntity saleTypeEntity);
	  
Updates the existing NSSaleTypeEntity or creates a new NSSaleTypeEntity if the id parameter is 0
	  
**Parameters**:
 - **saleTypeEntity** The NSSaleTypeEntity to save.

**Returns:** NSSaleTypeEntity

```crmscript
NSList  agent;
NSSaleTypeEntity thing = agent.CreateDefaultSaleTypeEntity();
thing = agent.SaveSaleTypeEntity(thing);
```

