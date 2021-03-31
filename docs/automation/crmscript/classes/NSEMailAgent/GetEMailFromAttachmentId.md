---
uid: crmscript_ref_NSEMailAgent_GetEMailFromAttachmentId
title: EMailEntity GetEMailFromAttachmentId(Integer emailId, StringArray attachmentIds, Bool includeAttachments)
intellisense: NSEMailAgent.GetEMailFromAttachmentId
keywords: NSEMailAgent, GetEMailFromAttachmentId
so.topic: reference
---

Get an e-mail based on an email and attachment id

**Parameters:**
 - **emailId** The primary key of the email row in the DB
 - **attachmentIds** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** The attachment as an e-mail

```crmscript
NSEMailAgent agent;
Integer emailId;
StringArray attachmentIds;
Bool includeAttachments;
EMailEntity res = agent.GetEMailFromAttachmentId(emailId, attachmentIds, includeAttachments);
```

