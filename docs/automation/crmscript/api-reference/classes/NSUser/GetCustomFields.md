---
uid: crmscript_ref_NSUser_GetCustomFields
title: Map GetCustomFields()
intellisense: NSUser.GetCustomFields
keywords: NSUser, GetCustomFields
so.topic: reference
---

Get the user-defined + extra fields on a User as a map.

**Returns:** Map

```crmscript
NSUser thing;
Map udefs = thing.GetCustomFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
log( udefs["x_bar"] ); // "[I:123]" - list item id
log( udefs["x_bar:DisplayText"] ); // "foobar" - list item name value
```

