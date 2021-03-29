---
title: crmscript_ref_Email_addAttachment_Integer_attachmentId_Bool_inline
description: Email.addAttachment(Integer attachmentId, Bool inline)
intellisense: Email.addAttachment
sortOrder: 282
keywords: addAttachment(Integer,Bool)
so.topic: reference
---

Adds an attachment to the email object.

attachmentId  The database id of the attachment to include
inline Set to true if you want to show the attachment inside the mail (used mostly for images)

Returns the id of the attachment relative to the email. If the inline parameter is set to true, this value can be used to inline attachments in the email body


