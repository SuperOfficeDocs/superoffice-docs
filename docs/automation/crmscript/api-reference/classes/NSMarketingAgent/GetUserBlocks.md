---
uid: crmscript_ref_NSMarketingAgent_GetUserBlocks
title: NSShipmentMessageBlockEntity[] GetUserBlocks(Integer associateId)
intellisense: NSMarketingAgent.GetUserBlocks
keywords: NSMarketingAgent, GetUserBlocks
so.topic: reference
---

# NSShipmentMessageBlockEntity[] GetUserBlocks(Integer associateId)

Get the saved user blocks to be used in a shipment/mailing message

**Parameters:**
 - **associateId** The associate id to get the user blocks. 0 will get all saved blocks

**Returns:** NSShipmentMessageBlockEntity[]

```crmscript
NSMarketingAgent agent;
Integer associateId;
NSShipmentMessageBlockEntity[] res = agent.GetUserBlocks(associateId);
```

