---
uid: crmscript_ref_NSChatSessionEntity_GetWhenFetched
title: DateTime GetWhenFetched()
intellisense: NSChatSessionEntity.GetWhenFetched
keywords: NSChatSessionEntity, GetWhenFetched
so.topic: reference
---

# DateTime GetWhenFetched()

The last time the customer&apos;s client refetched the data. Used to detect &apos;dead&apos; session.

**Returns:** DateTime

```crmscript
NSChatSessionEntity thing;
DateTime whenFetched  = thing.GetWhenFetched();
```

