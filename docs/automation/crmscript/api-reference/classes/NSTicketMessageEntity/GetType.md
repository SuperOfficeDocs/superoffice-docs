---
uid: crmscript_ref_NSTicketMessageEntity_GetType
title: TicketMessageType GetType()
intellisense: NSTicketMessageEntity.GetType
keywords: NSTicketMessageEntity, GetType
so.topic: reference
---

# TicketMessageType GetType()

The type of the message (plaintext/html).

**Returns:** TicketMessageType

     - Enum: 0 = Unknown 
     - Enum: 1 = Plain 
     - Enum: 2 = Html 

```crmscript
NSTicketMessageEntity thing;
TicketMessageType type  = thing.GetType();
```

