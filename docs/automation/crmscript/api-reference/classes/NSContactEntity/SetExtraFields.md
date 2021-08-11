---
uid: crmscript_ref_NSContactEntity_SetExtraFields
title: SetExtraFields(Map extras)
intellisense: NSContactEntity.SetExtraFields
keywords: NSContactEntity, SetExtraFields
so.topic: reference
---

# SetExtraFields(Map extras)

Set the extra field values on NSContactEntity with a map.

**Parameter:** 
 - **extras** Map containing extra field values encoded as strings.

```crmscript
NSContactEntity thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

