---
uid: crmscript_ref_NSTicketEntity_GetConnectId
title: Integer GetConnectId()
intellisense: NSTicketEntity.GetConnectId
keywords: NSTicketEntity, GetConnectId
so.topic: reference
---

# Integer GetConnectId()

If a ticket is connected to another ticket, this field is set to the id of the &apos;master&apos; ticket.

**Returns:** Integer

```crmscript
NSTicketEntity thing;
Integer connectId  = thing.GetConnectId();
```

