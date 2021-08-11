---
uid: crmscript_ref_NSEMailAgent_GetEMailFromDocumentAttachmentId
title: NSEMailEntity GetEMailFromDocumentAttachmentId(Integer docId, String[] attachmentIds, Bool includeAttachments)
intellisense: NSEMailAgent.GetEMailFromDocumentAttachmentId
keywords: NSEMailAgent, GetEMailFromDocumentAttachmentId
so.topic: reference
---

# NSEMailEntity GetEMailFromDocumentAttachmentId(Integer docId, String[] attachmentIds, Bool includeAttachments)

Get an e-mail based on an email in the archive system and attachment id

**Parameters:**
 - **docId** The primary key of the document row in the DB
 - **attachmentIds** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
 - **includeAttachments** Should we retrieve attachments embedded in the e-mail from the server

**Returns:** NSEMailEntity

```crmscript
NSEMailAgent agent;
Integer docId;
String[] attachmentIds;
Bool includeAttachments;
NSEMailEntity res = agent.GetEMailFromDocumentAttachmentId(docId, attachmentIds, includeAttachments);
```

