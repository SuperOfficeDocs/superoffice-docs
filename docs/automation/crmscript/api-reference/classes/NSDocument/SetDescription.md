---
uid: crmscript_ref_NSDocument_SetDescription
title: SetDescription(String description)
intellisense: NSDocument.SetDescription
keywords: NSDocument, GetDescription
so.topic: reference
---

# SetDescription(String description)

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Parameter:** 
 - **description** String

```crmscript
NSDocument thing;
String description;
thing.SetDescription(description);
```

