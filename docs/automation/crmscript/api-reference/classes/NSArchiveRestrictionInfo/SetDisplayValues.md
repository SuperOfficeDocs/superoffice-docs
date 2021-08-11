---
uid: crmscript_ref_NSArchiveRestrictionInfo_SetDisplayValues
title: SetDisplayValues(String[] displayValues)
intellisense: NSArchiveRestrictionInfo.SetDisplayValues
keywords: NSArchiveRestrictionInfo, GetDisplayValues
so.topic: reference
---

# SetDisplayValues(String[] displayValues)

Display representation of value(s) - list ID's are decoded to display texts, other values are represented in a format suitable for decoding and display through the CultureDataFormatter.

**Parameter:** 
 - **displayValues** String[]

```crmscript
NSArchiveRestrictionInfo thing;
String[] displayValues;
thing.SetDisplayValues(displayValues);
```

