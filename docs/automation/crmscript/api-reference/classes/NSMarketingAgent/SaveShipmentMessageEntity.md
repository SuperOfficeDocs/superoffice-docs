---
uid: crmscript_ref_NSMarketingAgent_SaveShipmentMessageEntity
title: NSShipmentMessageEntity SaveShipmentMessageEntity(NSShipmentMessageEntity shipmentMessageEntity);
intellisense: NSMarketingAgent.SaveShipmentMessageEntity
keywords: NSMarketingAgent, SaveShipmentMessageEntity
so.topic: reference
---
	  
Updates the existing NSShipmentMessageEntity or creates a new NSShipmentMessageEntity if the id parameter is 0
	  
**Parameters**:
 - **shipmentMessageEntity** The NSShipmentMessageEntity to save.

**Returns:** New or updated NSShipmentMessageEntity

```crmscript
NSMarketing  agent;
NSShipmentMessageEntity thing = agent.CreateDefaultShipmentMessageEntity();
thing = agent.SaveShipmentMessageEntity(thing);
```

