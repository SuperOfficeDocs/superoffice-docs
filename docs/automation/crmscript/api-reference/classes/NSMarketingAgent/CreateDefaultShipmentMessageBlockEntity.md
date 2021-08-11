---
uid: crmscript_ref_NSMarketingAgent_CreateDefaultShipmentMessageBlockEntity
title: NSShipmentMessageBlockEntity CreateDefaultShipmentMessageBlockEntity()
intellisense: NSMarketingAgent.CreateDefaultShipmentMessageBlockEntity
keywords: NSMarketingAgent, CreateDefaultShipmentMessageBlockEntity
so.topic: reference
---

# NSShipmentMessageBlockEntity CreateDefaultShipmentMessageBlockEntity()
	  
Set default values into a new NSShipmentMessageBlockEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSShipmentMessageBlockEntity

```crmscript
NSMarketingAgent agent;
NSShipmentMessageBlockEntity thing = agent.CreateDefaultShipmentMessageBlockEntity();
thing = agent.SaveShipmentMessageBlockEntity(thing);
```

