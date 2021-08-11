---
uid: crmscript_ref_NSArchiveColumnInfo_SetDisplayType
title: SetDisplayType(String displayType)
intellisense: NSArchiveColumnInfo.SetDisplayType
keywords: NSArchiveColumnInfo, GetDisplayType
so.topic: reference
---

# SetDisplayType(String displayType)

Type of column, so that the archive knows how to display it (actual display values are always strings, invariant-culture formatted). This name can contain resource tags.

**Parameter:** 
 - **displayType** String

```crmscript
NSArchiveColumnInfo thing;
String displayType;
thing.SetDisplayType(displayType);
```

