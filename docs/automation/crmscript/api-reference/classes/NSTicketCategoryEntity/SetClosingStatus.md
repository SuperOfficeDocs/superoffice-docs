---
uid: crmscript_ref_NSTicketCategoryEntity_SetClosingStatus
title: SetClosingStatus(Integer closingStatus)
intellisense: NSTicketCategoryEntity.SetClosingStatus
keywords: NSTicketCategoryEntity, GetClosingStatus
so.topic: reference
---

# SetClosingStatus(Integer closingStatus)

An integer indicating if new requests should have the &apos;close request&apos; in this category checked as default, or if the users preferences should be selected.

**Parameter:** 
 - **closingStatus** Integer
     - Enum: 0 = UserDefined 
     - Enum: 1 = Active 
     - Enum: 2 = Closed 
     - Enum: 3 = Postponed 

```crmscript
NSTicketCategoryEntity thing;
Integer closingStatus;
thing.SetClosingStatus(closingStatus);
```

