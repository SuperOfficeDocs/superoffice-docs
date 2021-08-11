---
uid: crmscript_ref_NSMarketingAgent_CreateDefaultShipmentMessageEntity
title: NSShipmentMessageEntity CreateDefaultShipmentMessageEntity()
intellisense: NSMarketingAgent.CreateDefaultShipmentMessageEntity
keywords: NSMarketingAgent, CreateDefaultShipmentMessageEntity
so.topic: reference
---

# NSShipmentMessageEntity CreateDefaultShipmentMessageEntity()
	  
Set default values into a new NSShipmentMessageEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSShipmentMessageEntity

```crmscript
NSMarketingAgent agent;
NSShipmentMessageEntity thing = agent.CreateDefaultShipmentMessageEntity();
thing = agent.SaveShipmentMessageEntity(thing);
```

