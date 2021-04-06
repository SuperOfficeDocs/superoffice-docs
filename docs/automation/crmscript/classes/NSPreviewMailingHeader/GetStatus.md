---
uid: crmscript_ref_NSPreviewMailingHeader_GetStatus
title: ShipmentStatus GetStatus()
intellisense: NSPreviewMailingHeader.GetStatus
keywords: NSPreviewMailingHeader, GetStatus
so.topic: reference
---

Sending/stopped/failed etc.

**Returns:** ShipmentStatus

     - Enum: 0 = None 
     - Enum: 1 = Ok 
     - Enum: 2 = Canceled 
     - Enum: 3 = Waiting 
     - Enum: 4 = Started 
     - Enum: 5 = StatusFailed 
     - Enum: 6 = Retry 
     - Enum: 7 = Populating 
     - Enum: 8 = Deleted 
     - Enum: 9 = AwaitPopulate 
     - Enum: 10 = PopulatingOnly 
     - Enum: 11 = PopulateAborted 
     - Enum: 12 = PopulateError 
     - Enum: 13 = TooManyRecipients 

```crmscript
NSPreviewMailingHeader thing;
ShipmentStatus status  = thing.GetStatus();
```


