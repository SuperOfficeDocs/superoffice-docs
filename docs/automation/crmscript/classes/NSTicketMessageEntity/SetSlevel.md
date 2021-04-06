---
uid: crmscript_ref_NSTicketMessageEntity_SetSlevel
title: SetSlevel(TicketSecurityLevel slevel)
intellisense: NSTicketMessageEntity.SetSlevel
keywords: NSTicketMessageEntity, GetSlevel
so.topic: reference
---

The securitylevel of the message.

**Parameter:** 
 - **slevel** TicketSecurityLevel
     - Enum: 0 = Unknown 
     - Enum: 1 = Internal 
     - Enum: 2 = External 

```crmscript
NSTicketMessageEntity thing;
TicketSecurityLevel slevel;
thing.SetSlevel(slevel);
```

