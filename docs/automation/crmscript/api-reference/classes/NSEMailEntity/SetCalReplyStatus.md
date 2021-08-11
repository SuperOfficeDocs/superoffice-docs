---
uid: crmscript_ref_NSEMailEntity_SetCalReplyStatus
title: SetCalReplyStatus(Integer calReplyStatus)
intellisense: NSEMailEntity.SetCalReplyStatus
keywords: NSEMailEntity, GetCalReplyStatus
so.topic: reference
---

# SetCalReplyStatus(Integer calReplyStatus)

Reply status stored in calendar data for the ical method is REPLY

**Parameter:** 
 - **calReplyStatus** Integer
     - Enum: 0 = Unknown 
     - Enum: 1 = Accepted 
     - Enum: 2 = Declined 
     - Enum: 3 = Tentative 

```crmscript
NSEMailEntity thing;
Integer calReplyStatus;
thing.SetCalReplyStatus(calReplyStatus);
```

