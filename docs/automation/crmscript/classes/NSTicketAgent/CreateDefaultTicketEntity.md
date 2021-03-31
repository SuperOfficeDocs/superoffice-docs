---
uid: crmscript_ref_NSTicketAgent_CreateDefaultTicketEntity
title: NSTicketEntity CreateDefaultTicketEntity()
intellisense: NSTicketAgent.CreateDefaultTicketEntity
keywords: NSTicketAgent, CreateDefaultTicketEntity
so.topic: reference
---
	  
Set default values into a new NSTicketEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTicketEntity with default values.

```crmscript
NSTicketAgent agent;
NSTicketEntity thing = agent.CreateDefaultTicketEntity();
thing = agent.SaveTicketEntity(thing);
```

