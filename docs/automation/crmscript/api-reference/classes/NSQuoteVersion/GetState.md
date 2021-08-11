---
uid: crmscript_ref_NSQuoteVersion_GetState
title: Integer GetState()
intellisense: NSQuoteVersion.GetState
keywords: NSQuoteVersion, GetState
so.topic: reference
---

# Integer GetState()

Current state of this quote version.

**Returns:** Integer

     - Enum: 0 = Unknown 
     - Enum: 1 = Draft 
     - Enum: 2 = DraftNotCalculated 
     - Enum: 3 = DraftNeedsApproval 
     - Enum: 4 = DraftApproved 
     - Enum: 5 = DraftNotApproved 
     - Enum: 6 = Sent 
     - Enum: 7 = Archived 
     - Enum: 8 = Lost 
     - Enum: 9 = Sold 

```crmscript
NSQuoteVersion thing;
Integer state  = thing.GetState();
```

