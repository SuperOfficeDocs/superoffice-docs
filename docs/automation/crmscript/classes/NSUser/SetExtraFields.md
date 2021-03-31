---
title: crmscript_ref_NSUser_SetExtraFields
description: NSUser.SetExtraFields(Map extras)
intellisense: NSUser.SetExtraFields
keywords: NSUser, SetExtraFields
so.topic: reference
---

Set the extra field values with a map.

**Parameter:** 
 - **extras** Map containing extra field values encoded as strings.

```crmscript
NSUser thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

