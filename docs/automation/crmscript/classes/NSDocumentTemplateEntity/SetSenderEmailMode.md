---
title: crmscript_ref_NSDocumentTemplateEntity_SetSenderEmailMode
description: NSDocumentTemplateEntity.SetSenderEmailMode(SenderMailMode senderEmailMode)
intellisense: NSDocumentTemplateEntity.SetSenderEmailMode
keywords: NSDocumentTemplateEntity, GetSenderEmailMode
so.topic: reference
---

If email template, when DocType is Privacy or quote email, it is possible to make sender address like our contact, or our support contact, or always one address

**Parameter:** 
 - **senderEmailMode** SenderMailMode
     - Enum: 0 = UseDefaultSender 
     - Enum: 1 = UseOurContact 
     - Enum: 2 = UseSupportContact 
     - Enum: 3 = UseLoggedInUser 

