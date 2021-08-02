---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedEMailFromAttachmentId
title: NSEMailEntity GetUnsanitizedEMailFromAttachmentId(Integer emailId, String[] attachmentIds, Bool includeAttachments)
intellisense: NSEMailAgent.GetUnsanitizedEMailFromAttachmentId
keywords: NSEMailAgent, GetUnsanitizedEMailFromAttachmentId
so.topic: reference
---

Get an e-mail based on an email and attachment id. The returned value is not sanitized.

**Parameters:**
 - **emailId** The primary key of the email row in the DB
 - **attachmentIds** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer emailId;
String[] attachmentIds;
Bool includeAttachments;
NSEMailEntity res = agent.GetUnsanitizedEMailFromAttachmentId(emailId, attachmentIds, includeAttachments);
```

