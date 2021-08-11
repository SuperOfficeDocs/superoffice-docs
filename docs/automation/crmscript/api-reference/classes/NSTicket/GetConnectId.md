---
uid: crmscript_ref_NSTicket_GetConnectId
title: Integer GetConnectId()
intellisense: NSTicket.GetConnectId
keywords: NSTicket, GetConnectId
so.topic: reference
---

# Integer GetConnectId()

If a ticket is connected to another ticket, this field is set to the id of the &apos;master&apos; ticket.

**Returns:** Integer

```crmscript
NSTicket thing;
Integer connectId  = thing.GetConnectId();
```

