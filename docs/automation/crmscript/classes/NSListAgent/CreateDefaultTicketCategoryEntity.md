---
title: crmscript_ref_NSListAgent_CreateDefaultTicketCategoryEntity
description: NSTicketCategoryEntity CreateDefaultTicketCategoryEntity()
intellisense: NSListAgent.CreateDefaultTicketCategoryEntity
keywords: NSListAgent,CreateDefaultTicketCategoryEntity
so.topic: reference
---
	  
Set default values into a new NSTicketCategoryEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTicketCategoryEntity with default values.

```crmscript
NSListAgent agent;
NSTicketCategoryEntity thing = agent.CreateDefaultTicketCategoryEntity();
thing = agent.SaveTicketCategoryEntity(thing);
```

