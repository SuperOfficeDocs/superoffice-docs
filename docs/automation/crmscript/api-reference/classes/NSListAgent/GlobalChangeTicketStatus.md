---
uid: crmscript_ref_NSListAgent_GlobalChangeTicketStatus
title: Void GlobalChangeTicketStatus(Integer fromTicketStatusId, Integer toTicketStatusId)
intellisense: NSListAgent.GlobalChangeTicketStatus
keywords: NSListAgent, GlobalChangeTicketStatus
so.topic: reference
---

# Void GlobalChangeTicketStatus(Integer fromTicketStatusId, Integer toTicketStatusId)

This method will change all references from one ticket status to another. Typically used in conjuction with delete

**Parameters:**
 - **fromTicketStatusId** The id of the ticket status to change from
 - **toTicketStatusId** The id of the ticket status to change to

```crmscript
NSListAgent agent;
Integer fromTicketStatusId;
Integer toTicketStatusId;
agent.GlobalChangeTicketStatus(fromTicketStatusId, toTicketStatusId);
```

