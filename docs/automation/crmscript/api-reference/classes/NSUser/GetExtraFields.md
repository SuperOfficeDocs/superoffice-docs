---
uid: crmscript_ref_NSUser_GetExtraFields
title: Map GetExtraFields()
intellisense: NSUser.GetExtraFields
keywords: NSUser, GetExtraFields
so.topic: reference
---

# Map GetExtraFields()

Get the extra fields on User as a map.

**Returns:** Map

```crmscript
NSUser thing;
Map extras = thing.GetExtraFields();
log( extras["x_abc"] ); // "[I:123]" - integer or list item id
log( extras["x_abc:DisplayText"] ); // "bla bla" - list item value
log( extras["x_bla"] ); // "foobar" - string value
```

