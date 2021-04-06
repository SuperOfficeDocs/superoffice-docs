---
uid: crmscript_ref_NSEMailAgent_GetUnsanitizedEMail
title: EMailEntity GetUnsanitizedEMail(Integer id, Bool includeAttachments)
intellisense: NSEMailAgent.GetUnsanitizedEMail
keywords: NSEMailAgent, GetUnsanitizedEMail
so.topic: reference
---

Get en e-mail based on its primary key in the DB. The returned value is not sanitized.

**Parameters:**
 - **id** The primary key of the email row in the DB
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer id;
Bool includeAttachments;
EMailEntity res = agent.GetUnsanitizedEMail(id, includeAttachments);
```

