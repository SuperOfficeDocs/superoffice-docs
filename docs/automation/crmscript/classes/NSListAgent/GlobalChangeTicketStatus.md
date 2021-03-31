---
title: crmscript_ref_NSListAgent_GlobalChangeTicketStatus
description: Void GlobalChangeTicketStatus(Integer fromTicketStatusId, Integer toTicketStatusId)
intellisense: NSListAgent.GlobalChangeTicketStatus
keywords: NSListAgent,GlobalChangeTicketStatus
so.topic: reference
---

This method will change all references from one ticket status to another. Typically used in conjuction with delete

**Parameters:**
 - **fromTicketStatusId** The id of the ticket status to change from
 - **toTicketStatusId** The id of the ticket status to change to

**Returns:** Does not return anything

```crmscript
NSListAgent agent;
Integer fromTicketStatusId;
Integer toTicketStatusId;
Void res = agent.GlobalChangeTicketStatus(fromTicketStatusId, toTicketStatusId);
```

