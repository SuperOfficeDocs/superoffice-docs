---
uid: crmscript_ref_NSTicketMessageEntity_GetMessageCategory
title: TicketMessageCategory GetMessageCategory()
intellisense: NSTicketMessageEntity.GetMessageCategory
keywords: NSTicketMessageEntity, GetMessageCategory
so.topic: reference
---

# TicketMessageCategory GetMessageCategory()

Defines what kind of message this is.

**Returns:** TicketMessageCategory

     - Enum: 0 = Message 
     - Enum: 1 = Bounce 
     - Enum: 2 = OutboxFailed 

```crmscript
NSTicketMessageEntity thing;
TicketMessageCategory messageCategory  = thing.GetMessageCategory();
```

