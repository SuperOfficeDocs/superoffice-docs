---
uid: crmscript_ref_NSTicketEntity_GetTimeToClose
title: Integer GetTimeToClose()
intellisense: NSTicketEntity.GetTimeToClose
keywords: NSTicketEntity, GetTimeToClose
so.topic: reference
---

# Integer GetTimeToClose()

The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&apos;s timeframe.

**Returns:** Integer

```crmscript
NSTicketEntity thing;
Integer timeToClose  = thing.GetTimeToClose();
```

