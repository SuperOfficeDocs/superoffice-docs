---
title: crmscript_ref_NSTicketEntity_SetCustomFields
description: NSTicketEntity.SetCustomFields(Map udefs)
intellisense: NSTicketEntity.SetCustomFields
keywords: NSTicketEntity, SetCustomFields
so.topic: reference
---

Set the user-defined and extra fields as a map.

**Parameter:** 
 - **udefs** Map user defined field and extra field values encoded as strings.

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

