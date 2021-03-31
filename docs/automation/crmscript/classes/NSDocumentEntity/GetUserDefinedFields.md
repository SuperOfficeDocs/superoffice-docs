---
title: crmscript_ref_NSDocumentEntity_GetUserDefinedFields
description: Map NSDocumentEntity.GetUserDefinedFields()
intellisense: NSDocumentEntity.GetUserDefinedFields
keywords: NSDocumentEntity, GetUserDefinedFields
so.topic: reference
---

Get the user-defined fields as a map.

**Returns:** Map containing user defined field values by field prog.id.

```crmscript
NSDocumentEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

