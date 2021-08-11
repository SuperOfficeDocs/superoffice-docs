---
uid: crmscript_ref_NSListAgent_CreateDefaultTicketCategoryEntity
title: NSTicketCategoryEntity CreateDefaultTicketCategoryEntity()
intellisense: NSListAgent.CreateDefaultTicketCategoryEntity
keywords: NSListAgent, CreateDefaultTicketCategoryEntity
so.topic: reference
---

# NSTicketCategoryEntity CreateDefaultTicketCategoryEntity()
	  
Set default values into a new NSTicketCategoryEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSTicketCategoryEntity

```crmscript
NSListAgent agent;
NSTicketCategoryEntity thing = agent.CreateDefaultTicketCategoryEntity();
thing = agent.SaveTicketCategoryEntity(thing);
```

