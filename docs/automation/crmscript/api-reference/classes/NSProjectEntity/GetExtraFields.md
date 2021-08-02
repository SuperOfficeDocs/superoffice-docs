---
uid: crmscript_ref_NSProjectEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSProjectEntity.GetExtraFields
keywords: NSProjectEntity, GetExtraFields
so.topic: reference
---

Get the extra fields on ProjectEntity as a map.

**Returns:** Map

```crmscript
NSProjectEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

