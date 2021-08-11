---
uid: crmscript_ref_NSPersonEntity_GetDescription
title: String GetDescription()
intellisense: NSPersonEntity.GetDescription
keywords: NSPersonEntity, GetDescription
so.topic: reference
---

# String GetDescription()

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Returns:** String

```crmscript
NSPersonEntity thing;
String description  = thing.GetDescription();
```

