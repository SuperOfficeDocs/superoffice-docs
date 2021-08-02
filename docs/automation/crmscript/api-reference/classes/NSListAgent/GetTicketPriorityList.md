---
uid: crmscript_ref_NSListAgent_GetTicketPriorityList
title: NSTicketPriority[] GetTicketPriorityList(Integer[]  ticketPriorityIds);
intellisense: NSListAgent.GetTicketPriorityList
keywords: NSListAgent, GetTicketPriorityList
so.topic: reference
---

Gets a vector of NSTicketPriority objects.

**Parameters:**
 - **ticketPriorityIds** The identifiers of the NSTicketPriority objects

**Returns:** NSTicketPriority[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSTicketPriority[] res = agent.GetTicketPriorityList(ids);
```

