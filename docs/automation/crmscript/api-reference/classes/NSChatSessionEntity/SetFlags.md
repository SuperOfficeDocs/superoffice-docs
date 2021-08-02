---
uid: crmscript_ref_NSChatSessionEntity_SetFlags
title: SetFlags(NSChatSessionFlags flags)
intellisense: NSChatSessionEntity.SetFlags
keywords: NSChatSessionEntity, GetFlags
so.topic: reference
---

Various flags for the chat session

**Parameter:** 
 - **flags** NSChatSessionFlags
     - Enum: 0 = CustomerIsTyping 
     - Enum: 1 = UserIsTyping 

```crmscript
NSChatSessionEntity thing;
NSChatSessionFlags flags;
thing.SetFlags(flags);
```

