---
uid: crmscript_ref_NSTicketEntity_GetMessages
title: TicketMessageArray GetMessages()
intellisense: NSTicketEntity.GetMessages
keywords: NSTicketEntity, GetMessages
so.topic: reference
---

TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive.

**Returns:** TicketMessageArray


```crmscript
NSTicketEntity thing;
TicketMessageArray messages  = thing.GetMessages();
```


