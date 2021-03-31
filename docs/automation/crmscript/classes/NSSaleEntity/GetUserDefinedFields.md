---
uid: crmscript_ref_NSSaleEntity_GetUserDefinedFields
title: Map GetUserDefinedFields()
intellisense: NSSaleEntity.GetUserDefinedFields
keywords: NSSaleEntity, GetUserDefinedFields
so.topic: reference
---

Get the user-defined fields on the SaleEntity as a map.

**Returns:** Map containing user defined field values by field prog.id.

```crmscript
NSSaleEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

