---
uid: crmscript_ref_NSFieldMetadata_SetMaxLength
title: SetMaxLength(Integer maxLength)
intellisense: NSFieldMetadata.SetMaxLength
keywords: NSFieldMetadata, GetMaxLength
so.topic: reference
---

# SetMaxLength(Integer maxLength)

Maximum length for strings, if set. 0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.)

**Parameter:** 
 - **maxLength** Integer

```crmscript
NSFieldMetadata thing;
Integer maxLength;
thing.SetMaxLength(maxLength);
```

