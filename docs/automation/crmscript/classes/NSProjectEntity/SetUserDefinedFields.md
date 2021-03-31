---
title: crmscript_ref_NSProjectEntity_SetUserDefinedFields
description: NSProjectEntity.SetUserDefinedFields(Map udefs)
intellisense: NSProjectEntity.SetUserDefinedFields
keywords: NSProjectEntity, SetUserDefinedFields
so.topic: reference
---

Set the user-defined fields as a map.

**Parameter:** 
 - **udefs** Map user defined field values encoded as strings.

```crmscript
NSProjectEntity thing;
Map udefs;
udefs["SuperOffice:1"] = "[I:123]";
udefs["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
udefs["custom.progid"] = "foobar";
thing.SetUserDefinedFields(udefs);
```

