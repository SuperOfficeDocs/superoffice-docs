---
uid: crmscript_ref_NSTicketCategoryEntity_GetMsgClosingStatus
title: TicketCategoryClosingStatus GetMsgClosingStatus()
intellisense: NSTicketCategoryEntity.GetMsgClosingStatus
keywords: NSTicketCategoryEntity, GetMsgClosingStatus
so.topic: reference
---

An integer indicating if new messages should have the &apos;close request&apos; in this category checked as default, or if the users preferences should be selected.

**Returns:** TicketCategoryClosingStatus

     - Enum: 0 = UserDefined 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 

```crmscript
NSTicketCategoryEntity thing;
TicketCategoryClosingStatus msgClosingStatus  = thing.GetMsgClosingStatus();
```


