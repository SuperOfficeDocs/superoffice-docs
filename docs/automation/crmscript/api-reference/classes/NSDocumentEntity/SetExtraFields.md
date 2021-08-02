---
uid: crmscript_ref_NSDocumentEntity_SetExtraFields
title: SetExtraFields(Map extras)
intellisense: NSDocumentEntity.SetExtraFields
keywords: NSDocumentEntity, SetExtraFields
so.topic: reference
---

Set the extra field values on NSDocumentEntity with a map.

**Parameter:** 
 - **extras** Map containing extra field values encoded as strings.

```crmscript
NSDocumentEntity thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

