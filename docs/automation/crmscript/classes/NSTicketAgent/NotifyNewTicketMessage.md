---
uid: crmscript_ref_NSTicketAgent_NotifyNewTicketMessage
title: Void NotifyNewTicketMessage(Integer ticketEntityId)
intellisense: NSTicketAgent.NotifyNewTicketMessage
keywords: NSTicketAgent, NotifyNewTicketMessage
so.topic: reference
---

Notify user agents about the creation of a new message on a ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to notify about

**Returns:** This method has no return value

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
Void res = agent.NotifyNewTicketMessage(ticketEntityId);
```

