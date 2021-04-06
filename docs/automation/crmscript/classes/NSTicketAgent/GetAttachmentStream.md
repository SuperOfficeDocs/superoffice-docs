---
uid: crmscript_ref_NSTicketAgent_GetAttachmentStream
title: Stream GetAttachmentStream(Integer attachmentId)
intellisense: NSTicketAgent.GetAttachmentStream
keywords: NSTicketAgent, GetAttachmentStream
so.topic: reference
---

Get the content of an attachment

**Parameters:**
 - **attachmentId** The id of the attachment to retrieve

**Returns:** A stream to the attachment content

```crmscript
NSTicketAgent agent;
Integer attachmentId;
Stream res = agent.GetAttachmentStream(attachmentId);
```

