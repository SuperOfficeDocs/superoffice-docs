---
title: crmscript_ref_NSTicketMessageEntity_GetExtraFields
description: Map NSTicketMessageEntity.GetExtraFields()
intellisense: NSTicketMessageEntity.GetExtraFields
keywords: NSTicketMessageEntity, GetExtraFields
so.topic: reference
---

Get the extra fields as a map.

**Returns:** Map containing extra field values by field name.

```crmscript
NSTicketMessageEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

