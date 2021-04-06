---
uid: crmscript_ref_NSFieldMetadata_GetMaxLength
title: Integer GetMaxLength()
intellisense: NSFieldMetadata.GetMaxLength
keywords: NSFieldMetadata, GetMaxLength
so.topic: reference
---

Maximum length for strings, if set. 0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.)

**Returns:** Integer


```crmscript
NSFieldMetadata thing;
Integer maxLength  = thing.GetMaxLength();
```


