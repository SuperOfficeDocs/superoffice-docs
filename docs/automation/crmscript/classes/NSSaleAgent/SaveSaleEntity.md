---
title: crmscript_ref_NSSaleAgent_SaveSaleEntity
description: NSSaleEntity SaveSaleEntity(NSSaleEntity saleEntity);
intellisense: NSSaleAgent.SaveSaleEntity
keywords: NSSaleAgent,SaveSaleEntity
so.topic: reference
---
	  
Updates the existing NSSaleEntity or creates a new NSSaleEntity if the id parameter is 0
	  
**Parameters**:
 - **saleEntity** The NSSaleEntity to save.

**Returns:** New or updated NSSaleEntity

```crmscript
NSSale  agent;
NSSaleEntity thing = agent.CreateDefaultSaleEntity();
thing = agent.SaveSaleEntity(thing);
```

