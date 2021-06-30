---
uid: crmscript_ref_NSTicketAgent_GetAttachmentInfo
title: AttachmentEntity[] GetAttachmentInfo(Integer ticketMessageEntityId)
intellisense: NSTicketAgent.GetAttachmentInfo
keywords: NSTicketAgent, GetAttachmentInfo
so.topic: reference
---

Get a list with meta data for all attached attachments

**Parameters:**
 - **ticketMessageEntityId** The id of the ticket message to get attachment infos

**Returns:** An array with AttachmentEntity objects, describing each attachment

```crmscript
NSTicketAgent agent;
Integer ticketMessageEntityId;
AttachmentEntity[] res = agent.GetAttachmentInfo(ticketMessageEntityId);
```

