---
uid: crmscript_ref_NSTicketMessage_SetSlevel
title: SetSlevel(TicketSecurityLevel slevel)
intellisense: NSTicketMessage.SetSlevel
keywords: NSTicketMessage, GetSlevel
so.topic: reference
---

# SetSlevel(TicketSecurityLevel slevel)

The securitylevel of the message.

**Parameter:** 
 - **slevel** TicketSecurityLevel
     - Enum: 0 = Unknown 
     - Enum: 1 = Internal 
     - Enum: 2 = External 

```crmscript
NSTicketMessage thing;
TicketSecurityLevel slevel;
thing.SetSlevel(slevel);
```

