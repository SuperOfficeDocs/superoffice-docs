---
title: crmscript_ref_NSListAgent_CreateDefaultAmountClassEntity
description: NSAmountClassEntity CreateDefaultAmountClassEntity()
intellisense: NSListAgent.CreateDefaultAmountClassEntity
keywords: NSListAgent,CreateDefaultAmountClassEntity
so.topic: reference
---
	  
Set default values into a new NSAmountClassEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSAmountClassEntity with default values.

```crmscript
NSListAgent agent;
NSAmountClassEntity thing = agent.CreateDefaultAmountClassEntity();
thing = agent.SaveAmountClassEntity(thing);
```

