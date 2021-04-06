---
uid: crmscript_ref_NSDocumentEntity_SetDescription
title: SetDescription(String description)
intellisense: NSDocumentEntity.SetDescription
keywords: NSDocumentEntity, GetDescription
so.topic: reference
---

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Parameter:** 
 - **description** String

```crmscript
NSDocumentEntity thing;
String description;
thing.SetDescription(description);
```

