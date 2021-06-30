---
uid: crmscript_ref_NSTicketEntity_SetMessages
title: SetMessages(TicketMessage[] messages)
intellisense: NSTicketEntity.SetMessages
keywords: NSTicketEntity, GetMessages
so.topic: reference
---

TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive.

**Parameter:** 
 - **messages** TicketMessage[]

```crmscript
NSTicketEntity thing;
TicketMessage[] messages;
thing.SetMessages(messages);
```

