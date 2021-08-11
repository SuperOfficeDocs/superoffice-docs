---
uid: crmscript_ref_NSTicketMessage_GetSlevel
title: TicketSecurityLevel GetSlevel()
intellisense: NSTicketMessage.GetSlevel
keywords: NSTicketMessage, GetSlevel
so.topic: reference
---

# TicketSecurityLevel GetSlevel()

The securitylevel of the message.

**Returns:** TicketSecurityLevel

     - Enum: 0 = Unknown 
     - Enum: 1 = Internal 
     - Enum: 2 = External 

```crmscript
NSTicketMessage thing;
TicketSecurityLevel slevel  = thing.GetSlevel();
```

