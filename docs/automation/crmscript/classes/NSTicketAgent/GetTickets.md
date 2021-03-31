---
title: crmscript_ref_NSTicketAgent_GetTickets
description: TicketArray GetTickets(IntegerArray ticketIds)
intellisense: NSTicketAgent.GetTickets
keywords: NSTicketAgent,GetTickets
so.topic: reference
---

Get multiple tickets

**Parameters:**
 - **ticketIds** The ids of tickets to get

**Returns:** Returns array of tickets in same order as input ids

```crmscript
NSTicketAgent agent;
IntegerArray ticketIds;
TicketArray res = agent.GetTickets(ticketIds);
```

