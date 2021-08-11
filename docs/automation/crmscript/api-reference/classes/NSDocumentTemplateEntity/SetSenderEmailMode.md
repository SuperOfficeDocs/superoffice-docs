---
uid: crmscript_ref_NSDocumentTemplateEntity_SetSenderEmailMode
title: SetSenderEmailMode(NSSenderMailMode senderEmailMode)
intellisense: NSDocumentTemplateEntity.SetSenderEmailMode
keywords: NSDocumentTemplateEntity, GetSenderEmailMode
so.topic: reference
---

# SetSenderEmailMode(NSSenderMailMode senderEmailMode)

If email template, when DocType is Privacy or quote email, it is possible to make sender address like our contact, or our support contact, or always one address

**Parameter:** 
 - **senderEmailMode** NSSenderMailMode
     - Enum: 0 = UseDefaultSender 
     - Enum: 1 = UseOurContact 
     - Enum: 2 = UseSupportContact 
     - Enum: 3 = UseLoggedInUser 

```crmscript
NSDocumentTemplateEntity thing;
NSSenderMailMode senderEmailMode;
thing.SetSenderEmailMode(senderEmailMode);
```

