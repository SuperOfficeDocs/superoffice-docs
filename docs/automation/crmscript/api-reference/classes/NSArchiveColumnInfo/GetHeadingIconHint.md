---
uid: crmscript_ref_NSArchiveColumnInfo_GetHeadingIconHint
title: String GetHeadingIconHint()
intellisense: NSArchiveColumnInfo.GetHeadingIconHint
keywords: NSArchiveColumnInfo, GetHeadingIconHint
so.topic: reference
---

# String GetHeadingIconHint()

Icon hint for the archive heading only. If this is a nonempty string, the archive header should use this icon and ignore the DisplayName. Otherwise, the DisplayName should be used as the heading.

**Returns:** String

```crmscript
NSArchiveColumnInfo thing;
String headingIconHint  = thing.GetHeadingIconHint();
```

