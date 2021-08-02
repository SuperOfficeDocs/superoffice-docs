---
uid: crmscript_ref_NSDocumentTemplateEntity_SetInvitationDocType
title: SetInvitationDocType(NSDocTmplInvitationType invitationDocType)
intellisense: NSDocumentTemplateEntity.SetInvitationDocType
keywords: NSDocumentTemplateEntity, GetInvitationDocType
so.topic: reference
---

Type for sending email meeting invitation. Not an invitation type template = 0, New = 1, Changed = 2, Cancelled = 3

**Parameter:** 
 - **invitationDocType** NSDocTmplInvitationType
     - Enum: 0 = None 
     - Enum: 1 = New 
     - Enum: 2 = Changed 
     - Enum: 3 = Cancelled 

```crmscript
NSDocumentTemplateEntity thing;
NSDocTmplInvitationType invitationDocType;
thing.SetInvitationDocType(invitationDocType);
```

