---
uid: crmscript_ref_NSProjectEntity_GetUserDefinedFields
title: Map GetUserDefinedFields()
intellisense: NSProjectEntity.GetUserDefinedFields
keywords: NSProjectEntity, GetUserDefinedFields
so.topic: reference
---

Get the user-defined fields on the ProjectEntity as a map.

**Returns:** Map

```crmscript
NSProjectEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

