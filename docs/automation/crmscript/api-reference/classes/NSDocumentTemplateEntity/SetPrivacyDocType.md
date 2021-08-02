---
uid: crmscript_ref_NSDocumentTemplateEntity_SetPrivacyDocType
title: SetPrivacyDocType(NSDocTmplPrivacyType privacyDocType)
intellisense: NSDocumentTemplateEntity.SetPrivacyDocType
keywords: NSDocumentTemplateEntity, GetPrivacyDocType
so.topic: reference
---

Indicator that this document template has a functional role, related to privacy/GDPR

**Parameter:** 
 - **privacyDocType** NSDocTmplPrivacyType
     - Enum: 0 = None 
     - Enum: 1 = PersonRegistered 

```crmscript
NSDocumentTemplateEntity thing;
NSDocTmplPrivacyType privacyDocType;
thing.SetPrivacyDocType(privacyDocType);
```

