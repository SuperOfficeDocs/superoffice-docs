---
uid: crmscript_ref_NSTicketEntity_SetCustomFields
title: SetCustomFields(Map udefs)
intellisense: NSTicketEntity.SetCustomFields
keywords: NSTicketEntity, SetCustomFields
so.topic: reference
---

# SetCustomFields(Map udefs)

Set the user-defined and extra fields on a TicketEntity with a map.

**Parameter:** 
 - **udefs** Map

```crmscript
NSTicketEntity thing;
Map udefs;
udefs["SuperOffice:1"] = "[I:123]";
udefs["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
udefs["custom.progid"] = "foobar";
udefs["x_foo"] = "foobar";
udefs["x_bar"] = "456"; // List item id
thing.SetCustomFields(udefs);
```

