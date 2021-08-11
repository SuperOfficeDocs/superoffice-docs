---
uid: crmscript_ref_NSPreviewMailing_GetStatus
title: ShipmentAddrStatus GetStatus()
intellisense: NSPreviewMailing.GetStatus
keywords: NSPreviewMailing, GetStatus
so.topic: reference
---

# ShipmentAddrStatus GetStatus()

Status for sending to this particular recipient

**Returns:** ShipmentAddrStatus

     - Enum: 0 = Unknown 
     - Enum: 1 = Ready 
     - Enum: 2 = Duplicate 
     - Enum: 3 = Blocked 
     - Enum: 4 = Sent 
     - Enum: 5 = Bounced 
     - Enum: 6 = Opened 
     - Enum: 7 = Clicked 
     - Enum: 8 = SoftBounced 
     - Enum: 9 = NoSubscription 
     - Enum: 10 = Complained 
     - Enum: 11 = TooManyBounces 

```crmscript
NSPreviewMailing thing;
ShipmentAddrStatus status  = thing.GetStatus();
```

