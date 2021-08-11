---
uid: crmscript_ref_NSEMailAgent_GetEMailFromAttachmentId
title: NSEMailEntity GetEMailFromAttachmentId(Integer emailId, String[] attachmentIds, Bool includeAttachments)
intellisense: NSEMailAgent.GetEMailFromAttachmentId
keywords: NSEMailAgent, GetEMailFromAttachmentId
so.topic: reference
---

# NSEMailEntity GetEMailFromAttachmentId(Integer emailId, String[] attachmentIds, Bool includeAttachments)

Get an e-mail based on an email and attachment id

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
NSEMailEntity res = agent.GetEMailFromAttachmentId(emailId, attachmentIds, includeAttachments);
```

