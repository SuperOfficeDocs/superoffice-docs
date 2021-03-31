---
title: crmscript_ref_NSTicketCategoryEntity_GetCustomFields
description: Map NSTicketCategoryEntity.GetCustomFields()
intellisense: NSTicketCategoryEntity.GetCustomFields
keywords: NSTicketCategoryEntity, GetCustomFields
so.topic: reference
---

Get the user-defined + extra fields as a map.

**Returns:** Map containing user defined and extra field values by field name.

```crmscript
NSTicketCategoryEntity thing;
Map udefs = thing.GetCustomFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
log( udefs["x_bar"] ); // "[I:123]" - list item id
log( udefs["x_bar:DisplayText"] ); // "foobar" - list item name value
```

