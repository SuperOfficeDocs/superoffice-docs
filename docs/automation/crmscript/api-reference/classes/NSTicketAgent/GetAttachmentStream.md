---
uid: crmscript_ref_NSTicketAgent_GetAttachmentStream
title: NSStream GetAttachmentStream(Integer attachmentId)
intellisense: NSTicketAgent.GetAttachmentStream
keywords: NSTicketAgent, GetAttachmentStream
so.topic: reference
---

Get the content of an attachment

**Parameters:**
 - **attachmentId** The id of the attachment to retrieve

**Returns:** NSStream

```crmscript
NSTicketAgent agent;
Integer attachmentId;
NSStream res = agent.GetAttachmentStream(attachmentId);
```

