---
uid: crmscript_ref_NSEMailAgent_GetAttachmentFromId
title: NSEMailAttachment GetAttachmentFromId(Integer mailItemId, String attachmentId)
intellisense: NSEMailAgent.GetAttachmentFromId
keywords: NSEMailAgent, GetAttachmentFromId
so.topic: reference
---

# NSEMailAttachment GetAttachmentFromId(Integer mailItemId, String attachmentId)

Retrieve an attachment from an e-mail

**Parameters:**
 - **mailItemId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** NSEMailAttachment

```crmscript
NSEMailAgent agent;
Integer mailItemId;
String attachmentId;
NSEMailAttachment res = agent.GetAttachmentFromId(mailItemId, attachmentId);
```

