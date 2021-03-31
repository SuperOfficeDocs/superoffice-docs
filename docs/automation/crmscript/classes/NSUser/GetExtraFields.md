---
title: crmscript_ref_NSUser_GetExtraFields
description: Map NSUser.GetExtraFields()
intellisense: NSUser.GetExtraFields
keywords: NSUser, GetExtraFields
so.topic: reference
---

Get the extra fields as a map.

**Returns:** Map containing extra field values by field name.

```crmscript
NSUser thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

