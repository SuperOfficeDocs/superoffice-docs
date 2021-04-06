---
uid: crmscript_ref_NSTicketAgent_CreateDefaultTicketMessageEntity
title: NSTicketMessageEntity CreateDefaultTicketMessageEntity()
intellisense: NSTicketAgent.CreateDefaultTicketMessageEntity
keywords: NSTicketAgent, CreateDefaultTicketMessageEntity
so.topic: reference
---
	  
Set default values into a new NSTicketMessageEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTicketMessageEntity with default values.

```crmscript
NSTicketAgent agent;
NSTicketMessageEntity thing = agent.CreateDefaultTicketMessageEntity();
thing = agent.SaveTicketMessageEntity(thing);
```

