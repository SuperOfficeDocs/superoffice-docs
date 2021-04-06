---
uid: crmscript_ref_NSTicketAgent_NotifyNewTicket
title: Void NotifyNewTicket(Integer ticketEntityId)
intellisense: NSTicketAgent.NotifyNewTicket
keywords: NSTicketAgent, NotifyNewTicket
so.topic: reference
---

Notify user agents about the creation of a new ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to notify about

**Returns:** This method has no return value

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
Void res = agent.NotifyNewTicket(ticketEntityId);
```

