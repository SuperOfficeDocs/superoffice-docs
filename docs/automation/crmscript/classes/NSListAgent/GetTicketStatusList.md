---
uid: crmscript_ref_NSListAgent_GetTicketStatusList
title: NSTicketStatusEntity[] GetTicketStatusList(Integer[]  ticketStatusEntityIds);
intellisense: NSListAgent.GetTicketStatusList
keywords: NSListAgent, GetTicketStatusList
so.topic: reference
---

Gets a vector of TicketStatusEntity objects.

**Parameters:**
 - **ticketStatusEntityIds** The identifiers of the NSTicketStatusEntity objects

**Returns:** Vector of NSTicketStatusEntity objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetTicketStatusList(ids);
```

