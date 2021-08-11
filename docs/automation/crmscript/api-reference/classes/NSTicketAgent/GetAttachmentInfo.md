---
uid: crmscript_ref_NSTicketAgent_GetAttachmentInfo
title: NSAttachmentEntity[] GetAttachmentInfo(Integer ticketMessageEntityId)
intellisense: NSTicketAgent.GetAttachmentInfo
keywords: NSTicketAgent, GetAttachmentInfo
so.topic: reference
---

# NSAttachmentEntity[] GetAttachmentInfo(Integer ticketMessageEntityId)

Get a list with meta data for all attached attachments

**Parameters:**
 - **ticketMessageEntityId** The id of the ticket message to get attachment infos

**Returns:** NSAttachmentEntity[]

```crmscript
NSTicketAgent agent;
Integer ticketMessageEntityId;
NSAttachmentEntity[] res = agent.GetAttachmentInfo(ticketMessageEntityId);
```

