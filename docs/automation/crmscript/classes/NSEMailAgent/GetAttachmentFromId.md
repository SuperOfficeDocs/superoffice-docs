---
title: crmscript_ref_NSEMailAgent_GetAttachmentFromId
description: EMailAttachment GetAttachmentFromId(Integer mailItemId, String attachmentId)
intellisense: NSEMailAgent.GetAttachmentFromId
keywords: NSEMailAgent,GetAttachmentFromId
so.topic: reference
---

Retrieve an attachment from an e-mail

**Parameters:**
 - **mailItemId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** The attachment

```crmscript
NSEMailAgent agent;
Integer mailItemId;
String attachmentId;
EMailAttachment res = agent.GetAttachmentFromId(mailItemId, attachmentId);
```

