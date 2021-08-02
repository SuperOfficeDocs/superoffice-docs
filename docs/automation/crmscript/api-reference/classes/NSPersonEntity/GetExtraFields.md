---
uid: crmscript_ref_NSPersonEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSPersonEntity.GetExtraFields
keywords: NSPersonEntity, GetExtraFields
so.topic: reference
---

Get the extra fields on NSPersonEntity as a map.

**Returns:** Map

```crmscript
NSPersonEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

