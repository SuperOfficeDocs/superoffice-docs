---
title: crmscript_ref_NSMarketingAgent_GetUserBlocks
description: ShipmentMessageBlockEntityArray GetUserBlocks(Integer associateId)
intellisense: NSMarketingAgent.GetUserBlocks
keywords: NSMarketingAgent,GetUserBlocks
so.topic: reference
---

Get the saved user blocks to be used in a shipment/mailing message

**Parameters:**
 - **associateId** The associate id to get the user blocks. 0 will get all saved blocks

**Returns:** An array of user blocks

```crmscript
NSMarketingAgent agent;
Integer associateId;
ShipmentMessageBlockEntityArray res = agent.GetUserBlocks(associateId);
```

