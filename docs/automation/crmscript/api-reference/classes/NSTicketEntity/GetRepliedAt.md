---
uid: crmscript_ref_NSTicketEntity_GetRepliedAt
title: DateTime GetRepliedAt()
intellisense: NSTicketEntity.GetRepliedAt
keywords: NSTicketEntity, GetRepliedAt
so.topic: reference
---

# DateTime GetRepliedAt()

The datetime for when the ticket was replied to. I.e. the first external message added to the ticket.

**Returns:** DateTime

```crmscript
NSTicketEntity thing;
DateTime repliedAt  = thing.GetRepliedAt();
```

