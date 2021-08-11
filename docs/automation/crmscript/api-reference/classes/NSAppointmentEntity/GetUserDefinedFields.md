---
uid: crmscript_ref_NSAppointmentEntity_GetUserDefinedFields
title: Map GetUserDefinedFields()
intellisense: NSAppointmentEntity.GetUserDefinedFields
keywords: NSAppointmentEntity, GetUserDefinedFields
so.topic: reference
---

# Map GetUserDefinedFields()

Get the user-defined fields on the NSAppointmentEntity as a map.

**Returns:** Map containing user defined field values by field prog.id.

```crmscript
NSAppointmentEntity thing;
Map udefs = thing.GetUserDefinedFields();
log( udefs["SuperOffice:1"] ); // "[I:123]" - integer or list item id
log( udefs["SuperOffice:1:DisplayText"] ); // "bla bla" - list item value
log( udefs["custom.progid"] ); // "foobar" - string value
```

