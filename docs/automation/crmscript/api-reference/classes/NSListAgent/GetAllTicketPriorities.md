---
uid: crmscript_ref_NSListAgent_GetAllTicketPriorities
title: NSTicketPriorityEntity[] GetAllTicketPriorities(Bool includeDeleted)
intellisense: NSListAgent.GetAllTicketPriorities
keywords: NSListAgent, GetAllTicketPriorities
so.topic: reference
---

# NSTicketPriorityEntity[] GetAllTicketPriorities(Bool includeDeleted)

Returns all available ticket priorities.

**Parameters:**
 - **includeDeleted** Include deleted items in result?

**Returns:** NSTicketPriorityEntity[]

```crmscript
NSListAgent agent;
Bool includeDeleted;
NSTicketPriorityEntity[] res = agent.GetAllTicketPriorities(includeDeleted);
```

