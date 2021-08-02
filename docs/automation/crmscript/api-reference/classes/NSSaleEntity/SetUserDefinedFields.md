---
uid: crmscript_ref_NSSaleEntity_SetUserDefinedFields
title: SetUserDefinedFields(Map udefs)
intellisense: NSSaleEntity.SetUserDefinedFields
keywords: NSSaleEntity, SetUserDefinedFields
so.topic: reference
---

Set the user-defined fields on the SaleEntity as a map.

**Parameter:** 
 - **udefs** Map

```crmscript
NSSaleEntity thing;
Map udefs;
udefs["SuperOffice:1"] = "[I:123]";
udefs["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
udefs["custom.progid"] = "foobar";
thing.SetUserDefinedFields(udefs);
```

