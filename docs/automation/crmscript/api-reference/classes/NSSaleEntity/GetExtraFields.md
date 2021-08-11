---
uid: crmscript_ref_NSSaleEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSSaleEntity.GetExtraFields
keywords: NSSaleEntity, GetExtraFields
so.topic: reference
---

# Map GetExtraFields()

Get the extra fields on SaleEntity as a map.

**Returns:** Map

```crmscript
NSSaleEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

