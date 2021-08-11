---
uid: crmscript_ref_NSChatMessage_GetType
title: NSChatMessageType GetType()
intellisense: NSChatMessage.GetType
keywords: NSChatMessage, GetType
so.topic: reference
---

# NSChatMessageType GetType()

The type of the message.

**Returns:** NSChatMessageType

     - Enum: 0 = Invalid 
     - Enum: 1 = ToCustomer 
     - Enum: 2 = ToUser 
     - Enum: 3 = Special 

```crmscript
NSChatMessage thing;
NSChatMessageType type  = thing.GetType();
```

