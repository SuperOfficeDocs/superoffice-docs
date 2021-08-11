---
uid: crmscript_ref_NSTicket_GetRealTimeSpentExternally
title: Integer GetRealTimeSpentExternally()
intellisense: NSTicket.GetRealTimeSpentExternally
keywords: NSTicket, GetRealTimeSpentExternally
so.topic: reference
---

# Integer GetRealTimeSpentExternally()

The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state

**Returns:** Integer

```crmscript
NSTicket thing;
Integer realTimeSpentExternally  = thing.GetRealTimeSpentExternally();
```

