---
uid: crmscript_ref_NSEMailEnvelope_SetFlags
title: SetFlags(Integer flags)
intellisense: NSEMailEnvelope.SetFlags
keywords: NSEMailEnvelope, GetFlags
so.topic: reference
---

# SetFlags(Integer flags)

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
NSEMailEnvelope thing;
Integer flags;
thing.SetFlags(flags);
```

