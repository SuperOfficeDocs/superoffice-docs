---
uid: crmscript_ref_NSTicketAgent_NotifyNewTicketMessage
title: Void NotifyNewTicketMessage(Integer ticketEntityId)
intellisense: NSTicketAgent.NotifyNewTicketMessage
keywords: NSTicketAgent, NotifyNewTicketMessage
so.topic: reference
---

# Void NotifyNewTicketMessage(Integer ticketEntityId)

Notify user agents about the creation of a new message on a ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to notify about

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
agent.NotifyNewTicketMessage(ticketEntityId);
```

