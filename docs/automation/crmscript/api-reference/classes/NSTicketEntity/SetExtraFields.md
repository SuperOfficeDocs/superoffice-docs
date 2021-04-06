---
uid: crmscript_ref_NSTicketEntity_SetExtraFields
title: SetExtraFields(Map extras)
intellisense: NSTicketEntity.SetExtraFields
keywords: NSTicketEntity, SetExtraFields
so.topic: reference
---

Set the extra field values on TicketEntity with a map.

**Parameter:** 
 - **extras** Map containing extra field values encoded as strings.

```crmscript
NSTicketEntity thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

