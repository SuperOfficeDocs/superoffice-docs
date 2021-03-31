---
title: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
description: EMailEntity GetUnsanitizedEMailFromDocumentAttachmentId(Integer docId, StringArray attachmentIds, Bool includeAttachments)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromDocumentAttachmentId
keywords: NSEMailAgent,GetUnsanitizedEMailFromDocumentAttachmentId
so.topic: reference
---

Get an e-mail based on an email in the archive system and attachment id. The returned value is not sanitized.

**Parameters:**
 - **docId** The primary key of the document row in the DB
 - **attachmentIds** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** The attachment as an e-mail

```crmscript
NSEMailAgent agent;
Integer docId;
StringArray attachmentIds;
Bool includeAttachments;
EMailEntity res = agent.GetUnsanitizedEMailFromDocumentAttachmentId(docId, attachmentIds, includeAttachments);
```

