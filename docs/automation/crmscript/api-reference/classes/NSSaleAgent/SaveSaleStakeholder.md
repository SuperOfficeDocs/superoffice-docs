---
uid: crmscript_ref_NSSaleAgent_SaveSaleStakeholder
title: NSSaleStakeholder SaveSaleStakeholder(NSSaleStakeholder saleStakeholder);
intellisense: NSSaleAgent.SaveSaleStakeholder
keywords: NSSaleAgent, SaveSaleStakeholder
so.topic: reference
---

# NSSaleStakeholder SaveSaleStakeholder(NSSaleStakeholder saleStakeholder);
	  
Updates the existing NSSaleStakeholder or creates a new NSSaleStakeholder if the id parameter is 0
	  
**Parameters**:
 - **saleStakeholder** The NSSaleStakeholder to save.

**Returns:** NSSaleStakeholder

```crmscript
NSSale  agent;
NSSaleStakeholder thing = agent.CreateDefaultSaleStakeholder();
thing = agent.SaveSaleStakeholder(thing);
```

