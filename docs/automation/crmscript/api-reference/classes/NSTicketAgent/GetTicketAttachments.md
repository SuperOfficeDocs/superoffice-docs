---
uid: crmscript_ref_NSTicketAgent_GetTicketAttachments
title: AttachmentEntity[] GetTicketAttachments(Integer ticketEntityId)
intellisense: NSTicketAgent.GetTicketAttachments
keywords: NSTicketAgent, GetTicketAttachments
so.topic: reference
---

Get attachment infos for all attachments connected to messages in specified ticket

**Parameters:**
 - **ticketEntityId** The id of the ticket to get attachment infos from

**Returns:** An array containing attachment info objects for all the attachments

```crmscript
NSTicketAgent agent;
Integer ticketEntityId;
AttachmentEntity[] res = agent.GetTicketAttachments(ticketEntityId);
```

