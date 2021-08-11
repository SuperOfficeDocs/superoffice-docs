---
uid: crmscript_ref_NSEMailAgent_GetPreviewAttachmentFromId
title: NSEMailAttachment GetPreviewAttachmentFromId(Integer mailItemId, String attachmentId, String attachmentType, String attachmentFilename)
intellisense: NSEMailAgent.GetPreviewAttachmentFromId
keywords: NSEMailAgent, GetPreviewAttachmentFromId
so.topic: reference
---

# NSEMailAttachment GetPreviewAttachmentFromId(Integer mailItemId, String attachmentId, String attachmentType, String attachmentFilename)

Retrieve an attachment from an e-mail. The returned data is intended to be use for a preview.

**Parameters:**
 - **mailItemId** Unique ID for the e-mail to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail
 - **attachmentType** Mimetype of the attachment. Must be set if attachmentId contains a chain.
 - **attachmentFilename** Filename of the attachment. Must be set if attachmentId contains a chain.

**Returns:** The attachment

```crmscript
NSEMailAgent agent;
Integer mailItemId;
String attachmentId;
String attachmentType;
String attachmentFilename;
NSEMailAttachment res = agent.GetPreviewAttachmentFromId(mailItemId, attachmentId, attachmentType, attachmentFilename);
```

