---
uid: crmscript_ref_NSListAgent_GetTicketCategoryList
title: NSTicketCategoryEntity[] GetTicketCategoryList(Integer[]  ticketCategoryEntityIds);
intellisense: NSListAgent.GetTicketCategoryList
keywords: NSListAgent, GetTicketCategoryList
so.topic: reference
---

Gets a vector of TicketCategoryEntity objects.

**Parameters:**
 - **ticketCategoryEntityIds** The identifiers of the NSTicketCategoryEntity objects

**Returns:** Vector of NSTicketCategoryEntity objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetTicketCategoryList(ids);
```

