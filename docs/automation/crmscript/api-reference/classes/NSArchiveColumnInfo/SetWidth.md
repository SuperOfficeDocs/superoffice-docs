---
uid: crmscript_ref_NSArchiveColumnInfo_SetWidth
title: SetWidth(String width)
intellisense: NSArchiveColumnInfo.SetWidth
keywords: NSArchiveColumnInfo, GetWidth
so.topic: reference
---

# SetWidth(String width)

The width specification, if the column info has been extended with GUI-based information. It is either "n%" or "nc", where n is an integer. Percent-formatted fields grow and shrink; number-of-characters formatted fields have constant width when the whole archive width changes.

**Parameter:** 
 - **width** String

```crmscript
NSArchiveColumnInfo thing;
String width;
thing.SetWidth(width);
```

