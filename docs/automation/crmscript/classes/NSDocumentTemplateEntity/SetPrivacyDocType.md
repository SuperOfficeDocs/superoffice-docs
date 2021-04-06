---
uid: crmscript_ref_NSDocumentTemplateEntity_SetPrivacyDocType
title: SetPrivacyDocType(DocTmplPrivacyType privacyDocType)
intellisense: NSDocumentTemplateEntity.SetPrivacyDocType
keywords: NSDocumentTemplateEntity, GetPrivacyDocType
so.topic: reference
---

Indicator that this document template has a functional role, related to privacy/GDPR

**Parameter:** 
 - **privacyDocType** DocTmplPrivacyType
     - Enum: 0 = None 
     - Enum: 1 = PersonRegistered 

```crmscript
NSDocumentTemplateEntity thing;
DocTmplPrivacyType privacyDocType;
thing.SetPrivacyDocType(privacyDocType);
```

