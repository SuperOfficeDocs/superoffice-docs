---
uid: crmscript_ref_NSTicketAgent_GetTicketMessage
title: NSTicketMessage GetTicketMessage(Integer ticketMessageId);
intellisense: NSTicketAgent.GetTicketMessage
keywords: NSTicketAgent, GetTicketMessage
so.topic: reference
---

# NSTicketMessage GetTicketMessage(Integer ticketMessageId);

Gets a NSTicketMessage object.

**Parameters:**
 - **ticketMessageId** The identifier of the NSTicketMessage object

**Returns:** NSTicketMessage

```crmscript
NSTicketAgent agent;
NSTicketMessage thing = agent.GetTicketMessage(123);
```

