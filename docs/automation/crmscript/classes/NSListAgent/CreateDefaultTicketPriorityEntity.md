---
title: crmscript_ref_NSListAgent_CreateDefaultTicketPriorityEntity
description: NSTicketPriorityEntity CreateDefaultTicketPriorityEntity()
intellisense: NSListAgent.CreateDefaultTicketPriorityEntity
keywords: NSListAgent,CreateDefaultTicketPriorityEntity
so.topic: reference
---
	  
Set default values into a new NSTicketPriorityEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTicketPriorityEntity with default values.

```crmscript
NSListAgent agent;
NSTicketPriorityEntity thing = agent.CreateDefaultTicketPriorityEntity();
thing = agent.SaveTicketPriorityEntity(thing);
```

