---
uid: crmscript_ref_NSPersonEntity_SetDescription
title: SetDescription(String description)
intellisense: NSPersonEntity.SetDescription
keywords: NSPersonEntity, GetDescription
so.topic: reference
---

# SetDescription(String description)

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Parameter:** 
 - **description** String

```crmscript
NSPersonEntity thing;
String description;
thing.SetDescription(description);
```

