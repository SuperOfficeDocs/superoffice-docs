---
title: crmscript_ref_NSEMailAgent_GetEMailFromAttachmentId_Integer_p_0_String__p_1_Bool_p_2
description: NSEMailAgent.GetEMailFromAttachmentId(Integer p_0, String[] p_1, Bool p_2)
intellisense: NSEMailAgent.GetEMailFromAttachmentId
sortOrder: 2817
keywords: GetEMailFromAttachmentId(Integer,String[],Bool)
so.topic: reference
---


Get an e-mail based on an email and attachment id



* **emailId:** The primary key of the email row in the DB
* **attachmentIds:** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
* **includeAttachments:** Should we retrieve attachments embedded in the e-mail from the server
* **Returns:** The attachment as an e-mail


