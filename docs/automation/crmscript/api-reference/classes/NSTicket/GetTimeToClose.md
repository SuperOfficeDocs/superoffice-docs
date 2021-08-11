---
uid: crmscript_ref_NSTicket_GetTimeToClose
title: Integer GetTimeToClose()
intellisense: NSTicket.GetTimeToClose
keywords: NSTicket, GetTimeToClose
so.topic: reference
---

# Integer GetTimeToClose()

The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&apos;s timeframe.

**Returns:** Integer

```crmscript
NSTicket thing;
Integer timeToClose  = thing.GetTimeToClose();
```

