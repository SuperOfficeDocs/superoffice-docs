---
uid: crmscript_ref_NSChatMessage_SetType
title: SetType(NSChatMessageType type)
intellisense: NSChatMessage.SetType
keywords: NSChatMessage, GetType
so.topic: reference
---

# SetType(NSChatMessageType type)

The type of the message.

**Parameter:** 
 - **type** NSChatMessageType
     - Enum: 0 = Invalid 
     - Enum: 1 = ToCustomer 
     - Enum: 2 = ToUser 
     - Enum: 3 = Special 

```crmscript
NSChatMessage thing;
NSChatMessageType type;
thing.SetType(type);
```

