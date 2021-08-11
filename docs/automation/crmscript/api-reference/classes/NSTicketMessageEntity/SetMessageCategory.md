---
uid: crmscript_ref_NSTicketMessageEntity_SetMessageCategory
title: SetMessageCategory(TicketMessageCategory messageCategory)
intellisense: NSTicketMessageEntity.SetMessageCategory
keywords: NSTicketMessageEntity, GetMessageCategory
so.topic: reference
---

# SetMessageCategory(TicketMessageCategory messageCategory)

Defines what kind of message this is.

**Parameter:** 
 - **messageCategory** TicketMessageCategory
     - Enum: 0 = Message 
     - Enum: 1 = Bounce 
     - Enum: 2 = OutboxFailed 

```crmscript
NSTicketMessageEntity thing;
TicketMessageCategory messageCategory;
thing.SetMessageCategory(messageCategory);
```

