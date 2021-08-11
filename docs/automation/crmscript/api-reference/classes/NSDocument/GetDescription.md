---
uid: crmscript_ref_NSDocument_GetDescription
title: String GetDescription()
intellisense: NSDocument.GetDescription
keywords: NSDocument, GetDescription
so.topic: reference
---

# String GetDescription()

The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases

**Returns:** String

```crmscript
NSDocument thing;
String description  = thing.GetDescription();
```

