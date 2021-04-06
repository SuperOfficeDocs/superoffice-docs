---
uid: crmscript_ref_NSEMailEntity_SetFlags
title: SetFlags(Integer flags)
intellisense: NSEMailEntity.SetFlags
keywords: NSEMailEntity, GetFlags
so.topic: reference
---

Flag status of this mail (unread, replied, deleted )

**Parameter:** 
 - **flags** Integer
     - Enum: 0 = None 
     - Enum: 1 = Seen 
     - Enum: 2 = Deleted 
     - Enum: 4 = Recent 
     - Enum: 8 = Flagged 
     - Enum: 16 = Draft 
     - Enum: 32 = Answered 

```crmscript
NSEMailEntity thing;
Integer flags;
thing.SetFlags(flags);
```

