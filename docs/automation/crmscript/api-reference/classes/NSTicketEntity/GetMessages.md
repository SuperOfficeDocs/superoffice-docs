---
uid: crmscript_ref_NSTicketEntity_GetMessages
title: TicketMessage[] GetMessages()
intellisense: NSTicketEntity.GetMessages
keywords: NSTicketEntity, GetMessages
so.topic: reference
---

# TicketMessage[] GetMessages()

TicketMessageId, CreatedAt, SLevel, and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive.

**Returns:** TicketMessageArray

```crmscript
NSTicketEntity thing;
TicketMessage[] messages  = thing.GetMessages();
```

