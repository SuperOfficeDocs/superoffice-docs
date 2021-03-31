---
title: crmscript_ref_NSDocumentEntity_SetUserDefinedFields
description: NSDocumentEntity.SetUserDefinedFields(Map udefs)
intellisense: NSDocumentEntity.SetUserDefinedFields
keywords: NSDocumentEntity, SetUserDefinedFields
so.topic: reference
---

Set the user-defined fields as a map.

**Parameter:** 
 - **udefs** Map user defined field values encoded as strings.

```crmscript
NSDocumentEntity thing;
Map udefs;
udefs["SuperOffice:1"] = "[I:123]";
udefs["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
udefs["custom.progid"] = "foobar";
thing.SetUserDefinedFields(udefs);
```

