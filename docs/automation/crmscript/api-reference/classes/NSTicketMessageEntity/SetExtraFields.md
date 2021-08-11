---
uid: crmscript_ref_NSTicketMessageEntity_SetExtraFields
title: SetExtraFields(Map extras)
intellisense: NSTicketMessageEntity.SetExtraFields
keywords: NSTicketMessageEntity, SetExtraFields
so.topic: reference
---

# SetExtraFields(Map extras)

Set the extra field values on TicketMessageEntity with a map.

**Parameter:** 
 - **extras** Map

```crmscript
NSTicketMessageEntity thing;
Map extras;
extras["SuperOffice:1"] = "[I:123]";
extras["SuperOffice:1"] = "123"; // this will also work, but beware of decimal point variations in different languages
extras["custom.progid"] = "foobar";
thing.SetExtraFields(extras);
```

