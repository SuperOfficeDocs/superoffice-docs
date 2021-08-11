---
uid: crmscript_ref_NSTicketEntity_GetSlevel
title: TicketSecurityLevel GetSlevel()
intellisense: NSTicketEntity.GetSlevel
keywords: NSTicketEntity, GetSlevel
so.topic: reference
---

# TicketSecurityLevel GetSlevel()

The securitylevel of the ticket.

**Returns:** TicketSecurityLevel

     - Enum: 0 = Unknown 
     - Enum: 1 = Internal 
     - Enum: 2 = External 

```crmscript
NSTicketEntity thing;
TicketSecurityLevel slevel  = thing.GetSlevel();
```

