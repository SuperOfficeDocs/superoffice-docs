---
uid: crmscript_ref_NSEMailAgent_GetPreviewAttachmentFromDocId
title: NSEMailAttachment GetPreviewAttachmentFromDocId(Integer docId, String attachmentId)
intellisense: NSEMailAgent.GetPreviewAttachmentFromDocId
keywords: NSEMailAgent, GetPreviewAttachmentFromDocId
so.topic: reference
---

# NSEMailAttachment GetPreviewAttachmentFromDocId(Integer docId, String attachmentId)

Retrieve an attachment from an e-mail stored in the document archive. The returned data is intended to be use for a preview.

**Parameters:**
 - **docId** Unique ID for the e-mail in the document archive to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** NSEMailAttachment

```crmscript
NSEMailAgent agent;
Integer docId;
String attachmentId;
NSEMailAttachment res = agent.GetPreviewAttachmentFromDocId(docId, attachmentId);
```

