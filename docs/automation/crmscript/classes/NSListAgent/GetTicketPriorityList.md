---
uid: crmscript_ref_NSListAgent_GetTicketPriorityList
title: NSTicketPriority[] GetTicketPriorityList(Integer[]  ticketPriorityIds);
intellisense: NSListAgent.GetTicketPriorityList
keywords: NSListAgent, GetTicketPriorityList
so.topic: reference
---

Gets a vector of TicketPriority objects.

**Parameters:**
 - **ticketPriorityIds** The identifiers of the NSTicketPriority objects

**Returns:** Vector of NSTicketPriority objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetTicketPriorityList(ids);
```

