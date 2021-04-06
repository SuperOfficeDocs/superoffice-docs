---
uid: crmscript_ref_NSTicketEntity_SetSlevel
title: SetSlevel(TicketSecurityLevel slevel)
intellisense: NSTicketEntity.SetSlevel
keywords: NSTicketEntity, GetSlevel
so.topic: reference
---

The securitylevel of the ticket.

**Parameter:** 
 - **slevel** TicketSecurityLevel
     - Enum: 0 = Unknown 
     - Enum: 1 = Internal 
     - Enum: 2 = External 

```crmscript
NSTicketEntity thing;
TicketSecurityLevel slevel;
thing.SetSlevel(slevel);
```

