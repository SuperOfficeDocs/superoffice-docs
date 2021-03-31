---
uid: crmscript_ref_NSMarketingAgent_CreateDefaultShipmentMessageEntity
title: NSShipmentMessageEntity CreateDefaultShipmentMessageEntity()
intellisense: NSMarketingAgent.CreateDefaultShipmentMessageEntity
keywords: NSMarketingAgent, CreateDefaultShipmentMessageEntity
so.topic: reference
---
	  
Set default values into a new NSShipmentMessageEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSShipmentMessageEntity with default values.

```crmscript
NSMarketingAgent agent;
NSShipmentMessageEntity thing = agent.CreateDefaultShipmentMessageEntity();
thing = agent.SaveShipmentMessageEntity(thing);
```

