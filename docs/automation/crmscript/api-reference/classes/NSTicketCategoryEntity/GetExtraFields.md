---
uid: crmscript_ref_NSTicketCategoryEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSTicketCategoryEntity.GetExtraFields
keywords: NSTicketCategoryEntity, GetExtraFields
so.topic: reference
---

# Map GetExtraFields()

Get the extra fields on NSTicketCategoryEntity as a map.

**Returns:** Map containing extra field values by field name.

```crmscript
NSTicketCategoryEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

