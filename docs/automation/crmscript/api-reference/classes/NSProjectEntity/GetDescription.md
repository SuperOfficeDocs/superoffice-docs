---
uid: crmscript_ref_NSProjectEntity_GetDescription
title: String GetDescription()
intellisense: NSProjectEntity.GetDescription
keywords: NSProjectEntity, GetDescription
so.topic: reference
---

# String GetDescription()

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Returns:** String

```crmscript
NSProjectEntity thing;
String description  = thing.GetDescription();
```

