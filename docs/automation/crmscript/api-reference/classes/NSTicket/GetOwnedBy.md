---
uid: crmscript_ref_NSTicket_GetOwnedBy
title: Integer GetOwnedBy()
intellisense: NSTicket.GetOwnedBy
keywords: NSTicket, GetOwnedBy
so.topic: reference
---

# Integer GetOwnedBy()

The id of the user who owns the ticket. 1 (system user) if the ticket is unassigned.

**Returns:** Integer

```crmscript
NSTicket thing;
Integer ownedBy  = thing.GetOwnedBy();
```

