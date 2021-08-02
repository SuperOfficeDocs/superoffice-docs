---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedPreviewAttachmentFromId
title: NSEMailAttachment GetUnsanitizedPreviewAttachmentFromId(Integer mailItemId, String attachmentId, String attachmentType, String attachmentFilename)
intellisense: NSEMailAgent.GetUnsanitizedPreviewAttachmentFromId
keywords: NSEMailAgent, GetUnsanitizedPreviewAttachmentFromId
so.topic: reference
---

Retrieve an attachment from an e-mail. The returned data is intended to be use for a preview. The returned data is not sanitized.

**Parameters:**
 - **mailItemId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail
 - **attachmentType** Mimetype of the attachment. Must be set if attachmentId contains a chain.
 - **attachmentFilename** Filename of the attachment. Must be set if attachmentId contains a chain.

**Returns:** NSEMailAttachment

```crmscript
NSEMailAgent agent;
Integer mailItemId;
String attachmentId;
String attachmentType;
String attachmentFilename;
NSEMailAttachment res = agent.GetUnsanitizedPreviewAttachmentFromId(mailItemId, attachmentId, attachmentType, attachmentFilename);
```

