---
uid: crmscript_ref_NSSaleEntity_SetExtraFields
title: SetExtraFields(Map extras)
intellisense: NSSaleEntity.SetExtraFields
keywords: NSSaleEntity, SetExtraFields
so.topic: reference
---

Set the extra field values on SaleEntity with a map.

**Parameter:** 
 - **extras** Map containing extra field values encoded as strings.

```crmscript
NSSaleEntity thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

