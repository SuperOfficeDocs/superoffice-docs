---
uid: crmscript_ref_NSQuoteVersion_GetArchivedState
title: Integer GetArchivedState()
intellisense: NSQuoteVersion.GetArchivedState
keywords: NSQuoteVersion, GetArchivedState
so.topic: reference
---

State that this quote version had, right before it was changed to Archived; in this way we can show what happened before the archiving.

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
Integer archivedState  = thing.GetArchivedState();
```


