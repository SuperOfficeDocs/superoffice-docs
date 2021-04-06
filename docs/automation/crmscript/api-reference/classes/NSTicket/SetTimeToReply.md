---
uid: crmscript_ref_NSTicket_SetTimeToReply
title: SetTimeToReply(Integer timeToReply)
intellisense: NSTicket.SetTimeToReply
keywords: NSTicket, GetTimeToReply
so.topic: reference
---

The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&apos;s timeframe.

**Parameter:** 
 - **timeToReply** Integer

```crmscript
NSTicket thing;
Integer timeToReply;
thing.SetTimeToReply(timeToReply);
```

