---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedPreviewAttachmentFromDocId
title: EMailAttachment GetUnsanitizedPreviewAttachmentFromDocId(Integer docId, String attachmentId)
intellisense: NSEMailAgent.GetUnsanitizedPreviewAttachmentFromDocId
keywords: NSEMailAgent, GetUnsanitizedPreviewAttachmentFromDocId
so.topic: reference
---

Retrieve an attachment from an e-mail stored in the document archive. The returned data is intended to be use for a preview. The returned data is not sanitized.

**Parameters:**
 - **docId** Unique ID for the e-mail in the document archive to retrieve the attachment from
 - **attachmentId** Id of the attachment in the e-mail

**Returns:** The attachment

```crmscript
NSEMailAgent agent;
Integer docId;
String attachmentId;
EMailAttachment res = agent.GetUnsanitizedPreviewAttachmentFromDocId(docId, attachmentId);
```

