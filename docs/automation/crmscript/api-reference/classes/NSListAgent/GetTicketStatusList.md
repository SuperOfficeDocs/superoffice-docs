---
uid: crmscript_ref_NSListAgent_GetTicketStatusList
title: NSTicketStatusEntity[] GetTicketStatusList(Integer[]  ticketStatusEntityIds);
intellisense: NSListAgent.GetTicketStatusList
keywords: NSListAgent, GetTicketStatusList
so.topic: reference
---

# NSTicketStatusEntity[] GetTicketStatusList(Integer[]  ticketStatusEntityIds);

Gets a vector of NSTicketStatusEntity objects.

**Parameters:**
 - **ticketStatusEntityIds** The identifiers of the NSTicketStatusEntity objects

**Returns:** NSTicketStatusEntity[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSTicketStatusEntity[] res = agent.GetTicketStatusList(ids);
```

