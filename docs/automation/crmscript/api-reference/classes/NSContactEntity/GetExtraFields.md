---
uid: crmscript_ref_NSContactEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSContactEntity.GetExtraFields
keywords: NSContactEntity, GetExtraFields
so.topic: reference
---

# Map GetExtraFields()

Get the extra fields on NSContactEntity as a map.

**Returns:** Map containing extra field values by field name.

```crmscript
NSContactEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

