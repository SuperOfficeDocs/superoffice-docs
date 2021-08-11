---
uid: crmscript_ref_NSArchiveColumnInfo_SetHeadingIconHint
title: SetHeadingIconHint(String headingIconHint)
intellisense: NSArchiveColumnInfo.SetHeadingIconHint
keywords: NSArchiveColumnInfo, GetHeadingIconHint
so.topic: reference
---

# SetHeadingIconHint(String headingIconHint)

Icon hint for the archive heading only. If this is a nonempty string, the archive header should use this icon and ignore the DisplayName. Otherwise, the DisplayName should be used as the heading.

**Parameter:** 
 - **headingIconHint** String

```crmscript
NSArchiveColumnInfo thing;
String headingIconHint;
thing.SetHeadingIconHint(headingIconHint);
```

