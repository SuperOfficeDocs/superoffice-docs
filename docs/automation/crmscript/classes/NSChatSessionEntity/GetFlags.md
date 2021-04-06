---
uid: crmscript_ref_NSChatSessionEntity_GetFlags
title: ChatSessionFlags GetFlags()
intellisense: NSChatSessionEntity.GetFlags
keywords: NSChatSessionEntity, GetFlags
so.topic: reference
---

Various flags for the chat session

**Returns:** ChatSessionFlags

     - Enum: 0 = CustomerIsTyping 
     - Enum: 1 = UserIsTyping 

```crmscript
NSChatSessionEntity thing;
ChatSessionFlags flags  = thing.GetFlags();
```


