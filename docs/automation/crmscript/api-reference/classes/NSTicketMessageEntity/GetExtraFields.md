---
uid: crmscript_ref_NSTicketMessageEntity_GetExtraFields
title: Map GetExtraFields()
intellisense: NSTicketMessageEntity.GetExtraFields
keywords: NSTicketMessageEntity, GetExtraFields
so.topic: reference
---

Get the extra fields on TicketMessageEntity as a map.

**Returns:** Map

```crmscript
NSTicketMessageEntity thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

