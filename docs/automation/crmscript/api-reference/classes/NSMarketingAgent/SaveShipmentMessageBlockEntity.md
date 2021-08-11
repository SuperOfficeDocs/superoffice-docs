---
uid: crmscript_ref_NSMarketingAgent_SaveShipmentMessageBlockEntity
title: NSShipmentMessageBlockEntity SaveShipmentMessageBlockEntity(NSShipmentMessageBlockEntity shipmentMessageBlockEntity);
intellisense: NSMarketingAgent.SaveShipmentMessageBlockEntity
keywords: NSMarketingAgent, SaveShipmentMessageBlockEntity
so.topic: reference
---

# NSShipmentMessageBlockEntity SaveShipmentMessageBlockEntity(NSShipmentMessageBlockEntity shipmentMessageBlockEntity);
	  
Updates the existing NSShipmentMessageBlockEntity or creates a new NSShipmentMessageBlockEntity if the id parameter is 0
	  
**Parameters**:
 - **shipmentMessageBlockEntity** The NSShipmentMessageBlockEntity to save.

**Returns:** NSShipmentMessageBlockEntity

```crmscript
NSMarketing  agent;
NSShipmentMessageBlockEntity thing = agent.CreateDefaultShipmentMessageBlockEntity();
thing = agent.SaveShipmentMessageBlockEntity(thing);
```

