---
uid: crmscript_ref_NSEMailAgent_GetEMail
title: EMailEntity GetEMail(Integer id, Bool includeAttachments)
intellisense: NSEMailAgent.GetEMail
keywords: NSEMailAgent, GetEMail
so.topic: reference
---

Get en e-mail based on its primary key in the DB

**Parameters:**
 - **id** The primary key of the email row in the DB
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** The e-mail

```crmscript
NSEMailAgent agent;
Integer id;
Bool includeAttachments;
EMailEntity res = agent.GetEMail(id, includeAttachments);
```

