---
uid: crmscript_ref_NSArchiveColumnInfo_GetIconHint
title: String GetIconHint()
intellisense: NSArchiveColumnInfo.GetIconHint
keywords: NSArchiveColumnInfo, GetIconHint
so.topic: reference
---

# String GetIconHint()

Icon hint corresponding to the display name; this icon hint is used in the configuration dialog and other places where we 'talk about' the columns of the archive. The actual heading of the archive may also contain icons in lieu of textual names, the icon hint for that is specified in HeadingIconHint and is a different one.

**Returns:** String

```crmscript
NSArchiveColumnInfo thing;
String iconHint  = thing.GetIconHint();
```

