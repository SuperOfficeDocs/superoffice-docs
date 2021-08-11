---
uid: crmscript_ref_NSTicketEntity_SetTimeToReply
title: SetTimeToReply(Integer timeToReply)
intellisense: NSTicketEntity.SetTimeToReply
keywords: NSTicketEntity, GetTimeToReply
so.topic: reference
---

# SetTimeToReply(Integer timeToReply)

The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&apos;s timeframe.

**Parameter:** 
 - **timeToReply** Integer

```crmscript
NSTicketEntity thing;
Integer timeToReply;
thing.SetTimeToReply(timeToReply);
```

