---
uid: crmscript_ref_NSTicketEntity_GetTimeSpentExternally
title: Integer GetTimeSpentExternally()
intellisense: NSTicketEntity.GetTimeSpentExternally
keywords: NSTicketEntity, GetTimeSpentExternally
so.topic: reference
---

# Integer GetTimeSpentExternally()

The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state

**Returns:** Integer

```crmscript
NSTicketEntity thing;
Integer timeSpentExternally  = thing.GetTimeSpentExternally();
```

