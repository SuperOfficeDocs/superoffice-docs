---
uid: crmscript_ref_NSTicketEntity_SetTimeToClose
title: SetTimeToClose(Integer timeToClose)
intellisense: NSTicketEntity.SetTimeToClose
keywords: NSTicketEntity, GetTimeToClose
so.topic: reference
---

The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&apos;s timeframe.

**Parameter:** 
 - **timeToClose** Integer

```crmscript
NSTicketEntity thing;
Integer timeToClose;
thing.SetTimeToClose(timeToClose);
```

