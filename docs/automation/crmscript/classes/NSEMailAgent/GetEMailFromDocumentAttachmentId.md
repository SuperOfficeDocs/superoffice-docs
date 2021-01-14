---
title: NSEMailEntity GetEMailFromDocumentAttachmentId(Integer docId, String[] attachmentIds, Bool includeAttachments)
path: /EJScript/Classes/NSEMailAgent/Member functions/NSEMailEntity GetEMailFromDocumentAttachmentId(Integer p_0, String[] p_1, Bool p_2)
intellisense: 1
classref: 1
sortOrder: 2818
keywords: GetEMailFromDocumentAttachmentId(Integer,String[],Bool)
---


Get an e-mail based on an email in the archive system and attachment id



* **docId:** The primary key of the document row in the DB
* **attachmentIds:** Id of the attachment. If multiple elements this is treated as attachment in attachemnts, e.g. [1, 2] means attachment 2 in attachment 1 of email.
* **includeAttachments:** Should we retrieve attachments embedded in the e-mail from the server
* **Returns:** The attachment as an e-mail


