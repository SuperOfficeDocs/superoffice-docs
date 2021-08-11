---
uid: crmscript_ref_NSTicketAgent_GetTicketAttachments
title: NSAttachmentEntity[] GetTicketAttachments(Integer ticketEntityId)
intellisense: NSTicketAgent.GetTicketAttachments
keywords: NSTicketAgent, GetTicketAttachments
so.topic: reference
---

# NSAttachmentEntity[] GetTicketAttachments(Integer ticketEntityId)

Get attachment infos for all attachments connected to messages in specified ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to get attachment infos from

**Returns:** NSAttachmentEntity[]

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
NSAttachmentEntity[] res = agent.GetTicketAttachments(ticketEntityId);
```

