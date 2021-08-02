---
uid: crmscript_ref_NSTicketCategoryEntity_GetClosingStatus
title: Integer GetClosingStatus()
intellisense: NSTicketCategoryEntity.GetClosingStatus
keywords: NSTicketCategoryEntity, GetClosingStatus
so.topic: reference
---

An integer indicating if new requests should have the &apos;close request&apos; in this category checked as default, or if the users preferences should be selected.

**Returns:** Integer

     - Enum: 0 = UserDefined 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 

```crmscript
NSTicketCategoryEntity thing;
Integer closingStatus  = thing.GetClosingStatus();
```


