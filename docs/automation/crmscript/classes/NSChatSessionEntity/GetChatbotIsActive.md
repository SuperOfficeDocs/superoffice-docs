---
uid: crmscript_ref_NSChatSessionEntity_GetChatbotIsActive
title: Bool GetChatbotIsActive()
intellisense: NSChatSessionEntity.GetChatbotIsActive
keywords: NSChatSessionEntity, GetChatbotIsActive
so.topic: reference
---

Indicates that a chatbot is active on the session. This will cause bot triggers to fire. Set to 0 when bot hands off to user.

**Returns:** Bool


```crmscript
NSChatSessionEntity thing;
Bool chatbotIsActive  = thing.GetChatbotIsActive();
```


