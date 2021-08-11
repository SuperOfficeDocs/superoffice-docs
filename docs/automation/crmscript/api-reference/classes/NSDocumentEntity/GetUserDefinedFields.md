---
uid: crmscript_ref_NSDocumentEntity_GetUserDefinedFields
title: Map GetUserDefinedFields()
intellisense: NSDocumentEntity.GetUserDefinedFields
keywords: NSDocumentEntity, GetUserDefinedFields
so.topic: reference
---

# Map GetUserDefinedFields()

Get the user-defined fields on the NSDocumentEntity as a map.

**Returns:** Map

```crmscript
NSDocumentEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

