---
title: crmscript_ref_NSSaleAgent_SaveSaleStakeholder
description: NSSaleStakeholder SaveSaleStakeholder(NSSaleStakeholder saleStakeholder);
intellisense: NSSaleAgent.SaveSaleStakeholder
keywords: NSSaleAgent,SaveSaleStakeholder
so.topic: reference
---
	  
Updates the existing NSSaleStakeholder or creates a new NSSaleStakeholder if the id parameter is 0
	  
**Parameters**:
 - **saleStakeholder** The NSSaleStakeholder to save.

**Returns:** New or updated NSSaleStakeholder

```crmscript
NSSale  agent;
NSSaleStakeholder thing = agent.CreateDefaultSaleStakeholder();
thing = agent.SaveSaleStakeholder(thing);
```

