---
uid: crmscript_ref_NSListAgent_GetTicketCategoryList
title: NSTicketCategoryEntity[] GetTicketCategoryList(Integer[]  ticketCategoryEntityIds);
intellisense: NSListAgent.GetTicketCategoryList
keywords: NSListAgent, GetTicketCategoryList
so.topic: reference
---

Gets a vector of NSTicketCategoryEntity objects.

**Parameters:**
 - **ticketCategoryEntityIds** The identifiers of the NSTicketCategoryEntity objects

**Returns:** NSTicketCategoryEntity[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSTicketCategoryEntity[] res = agent.GetTicketCategoryList(ids);
```

