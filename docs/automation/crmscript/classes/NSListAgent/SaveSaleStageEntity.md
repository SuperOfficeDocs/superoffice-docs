---
uid: crmscript_ref_NSListAgent_SaveSaleStageEntity
title: NSSaleStageEntity SaveSaleStageEntity(NSSaleStageEntity saleStageEntity);
intellisense: NSListAgent.SaveSaleStageEntity
keywords: NSListAgent, SaveSaleStageEntity
so.topic: reference
---
	  
Updates the existing NSSaleStageEntity or creates a new NSSaleStageEntity if the id parameter is 0
	  
**Parameters**:
 - **saleStageEntity** The NSSaleStageEntity to save.

**Returns:** New or updated NSSaleStageEntity

```crmscript
NSList  agent;
NSSaleStageEntity thing = agent.CreateDefaultSaleStageEntity();
thing = agent.SaveSaleStageEntity(thing);
```

