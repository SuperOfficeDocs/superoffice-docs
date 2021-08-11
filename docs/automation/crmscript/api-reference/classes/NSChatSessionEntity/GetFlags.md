---
uid: crmscript_ref_NSChatSessionEntity_GetFlags
title: NSChatSessionFlags GetFlags()
intellisense: NSChatSessionEntity.GetFlags
keywords: NSChatSessionEntity, GetFlags
so.topic: reference
---

# NSChatSessionFlags GetFlags()

Various flags for the chat session

**Returns:** NSChatSessionFlags

     - Enum: 0 = CustomerIsTyping 
     - Enum: 1 = UserIsTyping 

```crmscript
NSChatSessionEntity thing;
NSChatSessionFlags flags  = thing.GetFlags();
```

