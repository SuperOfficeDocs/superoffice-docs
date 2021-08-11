---
uid: crmscript_ref_NSTicketMessageEntity_SetType
title: SetType(TicketMessageType type)
intellisense: NSTicketMessageEntity.SetType
keywords: NSTicketMessageEntity, GetType
so.topic: reference
---

# SetType(TicketMessageType type)

The type of the message (plaintext/html).

**Parameter:** 
 - **type** TicketMessageType
     - Enum: 0 = Unknown 
     - Enum: 1 = Plain 
     - Enum: 2 = Html 

```crmscript
NSTicketMessageEntity thing;
TicketMessageType type;
thing.SetType(type);
```

