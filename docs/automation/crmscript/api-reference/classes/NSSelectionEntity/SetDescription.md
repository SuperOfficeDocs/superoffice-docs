---
uid: crmscript_ref_NSSelectionEntity_SetDescription
title: SetDescription(String description)
intellisense: NSSelectionEntity.SetDescription
keywords: NSSelectionEntity, GetDescription
so.topic: reference
---

# SetDescription(String description)

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Parameter:** 
 - **description** String

```crmscript
NSSelectionEntity thing;
String description;
thing.SetDescription(description);
```

