---
uid: crmscript_ref_NSChatMessage_GetType
title: ChatMessageType GetType()
intellisense: NSChatMessage.GetType
keywords: NSChatMessage, GetType
so.topic: reference
---

The type of the message.

**Returns:** ChatMessageType

     - Enum: 0 = Invalid 
     - Enum: 1 = ToCustomer 
     - Enum: 2 = ToUser 
     - Enum: 3 = Special 

```crmscript
NSChatMessage thing;
ChatMessageType type  = thing.GetType();
```


