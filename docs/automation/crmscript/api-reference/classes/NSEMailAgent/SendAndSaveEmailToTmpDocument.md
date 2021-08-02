---
uid: crmscript_ref_NSEMailAgent_SendAndSaveEmailToTmpDocument
title: String SendAndSaveEmailToTmpDocument(NSEMailEntity email, Bool stripAttachments)
intellisense: NSEMailAgent.SendAndSaveEmailToTmpDocument
keywords: NSEMailAgent, SendAndSaveEmailToTmpDocument
so.topic: reference
---

Send the provided e-mail and create tmp document ready to archive

**Parameters:**
 - **email** The e-mail to send
 - **stripAttachments** If true, do not include attachments in tmp document

**Returns:** String

```crmscript
NSEMailAgent agent;
NSEMailEntity email;
Bool stripAttachments;
String res = agent.SendAndSaveEmailToTmpDocument(email, stripAttachments);
```

