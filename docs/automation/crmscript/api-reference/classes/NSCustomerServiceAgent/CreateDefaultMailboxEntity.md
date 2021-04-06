---
uid: crmscript_ref_NSCustomerServiceAgent_CreateDefaultMailboxEntity
title: NSMailboxEntity CreateDefaultMailboxEntity()
intellisense: NSCustomerServiceAgent.CreateDefaultMailboxEntity
keywords: NSCustomerServiceAgent, CreateDefaultMailboxEntity
so.topic: reference
---
	  
Set default values into a new NSMailboxEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSMailboxEntity with default values.

```crmscript
NSCustomerServiceAgent agent;
NSMailboxEntity thing = agent.CreateDefaultMailboxEntity();
thing = agent.SaveMailboxEntity(thing);
```

