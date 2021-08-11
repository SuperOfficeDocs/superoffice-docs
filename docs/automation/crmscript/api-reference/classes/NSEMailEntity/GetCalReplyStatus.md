---
uid: crmscript_ref_NSEMailEntity_GetCalReplyStatus
title: Integer GetCalReplyStatus()
intellisense: NSEMailEntity.GetCalReplyStatus
keywords: NSEMailEntity, GetCalReplyStatus
so.topic: reference
---

# Integer GetCalReplyStatus()

Reply status stored in calendar data for the ical method is REPLY

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Accepted 
     - Enum: 2 = Declined 
     - Enum: 3 = Tentative 

```crmscript
NSEMailEntity thing;
Integer calReplyStatus  = thing.GetCalReplyStatus();
```

