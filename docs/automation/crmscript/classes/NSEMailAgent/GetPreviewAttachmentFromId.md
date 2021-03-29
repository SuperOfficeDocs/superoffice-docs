---
title: crmscript_ref_NSEMailAgent_GetPreviewAttachmentFromId_Integer_p_0_String_p_1_String_p_2_String_p_3
description: NSEMailAgent.GetPreviewAttachmentFromId(Integer p_0, String p_1, String p_2, String p_3)
intellisense: NSEMailAgent.GetPreviewAttachmentFromId
sortOrder: 2808
keywords: GetPreviewAttachmentFromId(Integer,String,String,String)
so.topic: reference
---


Retrieve an attachment from an e-mail. The returned data is intended to be use for a preview.



* **mailItemId:** Unique ID for the e-mail to retrieve the attachment from
* **attachmentId:** Id of the attachment in the e-mail
* **attachmentType:** Mimetype of the attachment. Must be set if attachmentId contains a chain.
* **attachmentFilename:** Filename of the attachment. Must be set if attachmentId contains a chain.
* **Returns:** The attachment


