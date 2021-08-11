---
uid: crmscript_ref_NSTicketAgent_GetTickets
title: Ticket[] GetTickets(Integer[] ticketIds)
intellisense: NSTicketAgent.GetTickets
keywords: NSTicketAgent, GetTickets
so.topic: reference
---

# Ticket[] GetTickets(Integer[] ticketIds)

Get multiple tickets

**Parameters:**
 - **ticketIds** The ids of tickets to get

**Returns:** Ticket[]

```crmscript
NSTicketAgent agent;
Integer[] ticketIds;
Ticket[] res = agent.GetTickets(ticketIds);
```

