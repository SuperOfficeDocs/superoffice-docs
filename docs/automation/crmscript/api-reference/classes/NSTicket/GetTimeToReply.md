---
uid: crmscript_ref_NSTicket_GetTimeToReply
title: Integer GetTimeToReply()
intellisense: NSTicket.GetTimeToReply
keywords: NSTicket, GetTimeToReply
so.topic: reference
---

The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&apos;s timeframe.

**Returns:** Integer


```crmscript
NSTicket thing;
Integer timeToReply  = thing.GetTimeToReply();
```


