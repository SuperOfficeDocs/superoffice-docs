---
uid: crmscript_ref_NSListAgent_MoveAllTickets
title: Void MoveAllTickets(Integer fromTicketCategoryId, Integer toTicketCategoryId)
intellisense: NSListAgent.MoveAllTickets
keywords: NSListAgent, MoveAllTickets
so.topic: reference
---

Move all tickets from one ticket category to another

**Parameters:**
 - **fromTicketCategoryId** The id of the category we want to move tickets from
 - **toTicketCategoryId** The id of the category we want to move the tickets to

```crmscript
NSListAgent agent;
Integer fromTicketCategoryId;
Integer toTicketCategoryId;
agent.MoveAllTickets(fromTicketCategoryId, toTicketCategoryId);
```

