---
title: crmscript_ref_NSDocumentTemplateEntity_GetSenderEmailMode
description: SenderMailMode NSDocumentTemplateEntity.GetSenderEmailMode()
intellisense: NSDocumentTemplateEntity.GetSenderEmailMode
keywords: NSDocumentTemplateEntity, GetSenderEmailMode
so.topic: reference
---

If email template, when DocType is Privacy or quote email, it is possible to make sender address like our contact, or our support contact, or always one address

**Returns:** SenderMailMode

     - Enum: 0 = UseDefaultSender 
     - Enum: 1 = UseOurContact 
     - Enum: 2 = UseSupportContact 
     - Enum: 3 = UseLoggedInUser 

