---
uid: crmscript_ref_NSDocumentTemplateEntity_GetPrivacyDocType
title: NSDocTmplPrivacyType GetPrivacyDocType()
intellisense: NSDocumentTemplateEntity.GetPrivacyDocType
keywords: NSDocumentTemplateEntity, GetPrivacyDocType
so.topic: reference
---

Indicator that this document template has a functional role, related to privacy/GDPR

**Returns:** NSDocTmplPrivacyType

     - Enum: 0 = None 
     - Enum: 1 = PersonRegistered 

```crmscript
NSDocumentTemplateEntity thing;
NSDocTmplPrivacyType privacyDocType  = thing.GetPrivacyDocType();
```


