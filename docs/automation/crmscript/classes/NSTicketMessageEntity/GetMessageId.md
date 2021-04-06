---
uid: crmscript_ref_NSTicketMessageEntity_GetMessageId
title: String GetMessageId()
intellisense: NSTicketMessageEntity.GetMessageId
keywords: NSTicketMessageEntity, GetMessageId
so.topic: reference
---

The X-Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets.

**Returns:** String


```crmscript
NSTicketMessageEntity thing;
String messageId  = thing.GetMessageId();
```


