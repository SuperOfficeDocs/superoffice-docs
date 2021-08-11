---
uid: crmscript_ref_NSPersonEntity_GetUserDefinedFields
title: Map GetUserDefinedFields()
intellisense: NSPersonEntity.GetUserDefinedFields
keywords: NSPersonEntity, GetUserDefinedFields
so.topic: reference
---

# Map GetUserDefinedFields()

Get the user-defined fields on the NSPersonEntity as a map.

**Returns:** Map

```crmscript
NSPersonEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

