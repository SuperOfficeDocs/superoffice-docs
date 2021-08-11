---
uid: crmscript_ref_NSArchiveColumnInfo_GetDisplayType
title: String GetDisplayType()
intellisense: NSArchiveColumnInfo.GetDisplayType
keywords: NSArchiveColumnInfo, GetDisplayType
so.topic: reference
---

# String GetDisplayType()

Type of column, so that the archive knows how to display it (actual display values are always strings, invariant-culture formatted). This name can contain resource tags.

**Returns:** String

```crmscript
NSArchiveColumnInfo thing;
String displayType  = thing.GetDisplayType();
```

