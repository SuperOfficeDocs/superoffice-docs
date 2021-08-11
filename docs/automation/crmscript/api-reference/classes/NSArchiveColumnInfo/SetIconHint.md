---
uid: crmscript_ref_NSArchiveColumnInfo_SetIconHint
title: SetIconHint(String iconHint)
intellisense: NSArchiveColumnInfo.SetIconHint
keywords: NSArchiveColumnInfo, GetIconHint
so.topic: reference
---

# SetIconHint(String iconHint)

Icon hint corresponding to the display name; this icon hint is used in the configuration dialog and other places where we 'talk about' the columns of the archive. The actual heading of the archive may also contain icons in lieu of textual names, the icon hint for that is specified in HeadingIconHint and is a different one.

**Parameter:** 
 - **iconHint** String

```crmscript
NSArchiveColumnInfo thing;
String iconHint;
thing.SetIconHint(iconHint);
```

